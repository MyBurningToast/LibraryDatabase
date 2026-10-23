namespace App;

public partial class MainForm : Form
{
    static readonly Color Green = Color.FromArgb(20, 97, 47);
    static readonly Color Red = Color.FromArgb(164, 0, 30);

    readonly Font boldFont;

    public MainForm()
    {
        InitializeComponent();

        boldFont = new Font(Font, FontStyle.Bold);
        dueBox.Value = DateTime.Today.AddDays(14); // default due date is 2 weeks from today

        // loop through all 3 grids and apply the same styling
        foreach (var g in new[] { outGrid, overdueGrid, searchGrid }) StyleGrid(g);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode) return; // skip setup when viewed in designer (just while developing)

        studentBox.DisplayMember = "Name"; // show each name in the dropdown
        bookBox.DisplayMember = "Name";

        // fill the dropdown with Item objects
        studentBox.DataSource = Library.Students();
        RefreshAll();
    }

    // connect the buttons to their actions

    void addButton_Click(object? sender, EventArgs e) => AddLoan();
    void returnButton_Click(object? sender, EventArgs e) => MarkReturned();
    void searchStudentsButton_Click(object? sender, EventArgs e) => Search(books: false);
    void searchBooksButton_Click(object? sender, EventArgs e) => Search(books: true);
    void addStudentButton_Click(object? sender, EventArgs e) => AddStudent();
    void addBookButton_Click(object? sender, EventArgs e) => AddBook();

    // actions

    void AddLoan()
    {
        // valid item in dropdown selected
        if (studentBox.SelectedItem is not Item who || bookBox.SelectedItem is not Item book) return;

        var due = dueBox.Value.Date; // remove time from date

        if (due <= DateTime.Today)
        {
            Notify("Due date must be after today.", ok: false);
            return;
        }

        Library.AddLoan(who.Id, book.Id, due);
        Notify("Loan added.", ok: true);
        RefreshAll();
    }

    void MarkReturned()
    {
        // get the loan stored on the selected row
        if (outGrid.CurrentRow?.Tag is not Loan loan)
        {
            Notify("Select a loan first.", ok: false);
            return;
        }

        Library.MarkReturned(loan.Id);
        Notify($"\"{loan.Book}\" marked returned.", ok: true);
        RefreshAll();
    }

    void AddStudent()
    {
        var name = newStudentNameBox.Text.Trim(); // whitespace on start and end

        // validate name
        if (name == "" || !long.TryParse(newStudentIdBox.Text, out var id))
        {
            MessageBox.Show("Enter a name and a numeric student number.");
            return;
        }

        // validate studen number
        if (!Library.AddStudent(id, name, out bool wasCheckError))
        {
            if (wasCheckError)
            {
                MessageBox.Show("A student ID cannot be less than zero.");
                return;
            }
            MessageBox.Show("A student with that number already exists.");
            return;
        }

        newStudentIdBox.Clear();
        newStudentNameBox.Clear();

        // reload the dropdown
        studentBox.DataSource = Library.Students();
        MessageBox.Show("Student added.");
    }

    void AddBook()
    {
        var title = newBookTitleBox.Text.Trim();
        var author = newBookAuthorBox.Text.Trim();

        // validate book
        if (title == "" || author == "" || !long.TryParse(newBookIdBox.Text, out var id))
        {
            MessageBox.Show("Enter a title, an author and a numeric book id.");
            return;
        }

        // validate book id
        if (!Library.AddBook(id, title, author, out bool wasCheckError))
        {
            if (wasCheckError)
            {
                MessageBox.Show("A book ID cannot be less than zero.");
                return;
            }
            MessageBox.Show("A book with that id already exists.");
            return;
        }

        newBookIdBox.Clear();
        newBookTitleBox.Clear();
        newBookAuthorBox.Clear();

        RefreshAll();
        MessageBox.Show("Book added.");
    }

    void Search(bool books)
    {
        var q = queryBox.Text.Trim();

        var hits = books ? Library.SearchBooks(q) : Library.SearchStudents(q);

        searchTitle.Text = $"Loan history for \"{q}\" ({hits.Count} result{(hits.Count == 1 ? "" : "s")})";

        searchGrid.Rows.Clear(); // remove old results

        foreach (var loan in hits)
        {
            AddRow(
                searchGrid, // grid to add the row to
                loan, // store the loan on the row
                loan.Student, // show the students name
                loan.Book, // show the books name
                Fmt(loan.Out), // format the loan date

                // format the return date if it exists, otherwise show "-"
                // is { } means not null (to be honst, could have just done != null but i just learned abut it so im going to use it)
                loan.Returned is { } r ? Fmt(r) : "-"
            );
        }
    }

    void RefreshAll()
    {
        // only show books that not currently loaned out
        bookBox.DataSource = Library.AvailableBooks();

        outGrid.Rows.Clear(); // old rows

        foreach (var l in Library.LoansOut())
        {
            var row = AddRow(outGrid, l, l.Student, l.Book, Fmt(l.Out), Fmt(l.Due));

            if (l.Due.Date < DateTime.Today)
            {
                // make overdue loans row red
                row.DefaultCellStyle.ForeColor = Red;
                row.DefaultCellStyle.SelectionForeColor = Red;
                row.DefaultCellStyle.Font = boldFont;
            }
        }

        var late = Library.Overdue(); // get all loans that past their due date
        overdueTitle.Text = $"Overdue loans ({late.Count})";
        overdueGrid.Rows.Clear();

        foreach (var l in late)
        {
            var row = AddRow(overdueGrid, l, l.Student, l.Book, Fmt(l.Due), DaysLate(l));

            // highlight the due date in red and bold
            row.Cells[3].Style = new DataGridViewCellStyle { ForeColor = Red, Font = boldFont };
        }
    }

    static int DaysLate(Loan l) => (DateTime.Today - l.Due.Date).Days;

    static string Fmt(DateTime d) => d.ToString("yyyy-MM-dd");

    void Notify(string text, bool ok)
    {
        messageLabel.ForeColor = ok ? Green : Red;
        messageLabel.Text = text;
    }

    static DataGridViewRow AddRow(DataGridView g, Loan tag, params object[] cells)
    {
        // add a row using the supplied values
        var row = g.Rows[g.Rows.Add(cells)];

        // store the loan on the row so it can be retrievd when selected
        row.Tag = tag;
        return row;
    }

    // apply grid colours at runtime to keep the designer file cleaner
    // i read that this was good practice
    static void StyleGrid(DataGridView g)
    {
        var head = Color.FromArgb(0xEC, 0xEC, 0xEC);
        g.BackgroundColor = Color.White;
        g.BorderStyle = BorderStyle.FixedSingle;
        g.GridColor = Color.FromArgb(0xDD, 0xDD, 0xDD);
        g.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        g.EnableHeadersVisualStyles = false;

        g.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = head,
            SelectionBackColor = head, // keep the header colour when selected
            ForeColor = Color.Black,
            SelectionForeColor = Color.Black,
            Font = new Font(g.Font, FontStyle.Bold),
            Padding = new Padding(2, 4, 2, 4)
        };

        g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0xCF, 0xE2, 0xFF);
        g.DefaultCellStyle.SelectionForeColor = Color.Black;
        g.DefaultCellStyle.Padding = new Padding(2, 3, 2, 3);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }
}
