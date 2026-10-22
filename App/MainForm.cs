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
        dueBox.Value = DateTime.Today.AddDays(14);
        foreach (var g in new[] { outGrid, overdueGrid, searchGrid }) StyleGrid(g);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode) return;

        studentBox.DisplayMember = "Name";
        bookBox.DisplayMember = "Name";
        studentBox.DataSource = Library.Students();
        RefreshAll();
    }

    // events (connected to designer)

    void addButton_Click(object? sender, EventArgs e) => AddLoan();
    void returnButton_Click(object? sender, EventArgs e) => MarkReturned();
    void searchStudentsButton_Click(object? sender, EventArgs e) => Search(books: false);
    void searchBooksButton_Click(object? sender, EventArgs e) => Search(books: true);
    void addStudentButton_Click(object? sender, EventArgs e) => AddStudent();
    void addBookButton_Click(object? sender, EventArgs e) => AddBook();

    // actions

    void AddLoan()
    {
        if (studentBox.SelectedItem is not Item who || bookBox.SelectedItem is not Item book) return;
        var due = dueBox.Value.Date;

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
        if (outGrid.CurrentRow?.Tag is not Loan loan) { Notify("Select a loan first.", ok: false); return; }
        Library.MarkReturned(loan.Id);
        Notify($"\"{loan.Book}\" marked returned.", ok: true);
        RefreshAll();
    }

    void AddStudent()
    {
        var name = newStudentNameBox.Text.Trim();
        if (name == "" || !long.TryParse(newStudentIdBox.Text, out var id))
        {
            MessageBox.Show("Enter a name and a numeric student number.");
            return;
        }

        if (!Library.AddStudent(id, name))
        {
            MessageBox.Show("A student with that number already exists.");
            return;
        }

        newStudentIdBox.Clear();
        newStudentNameBox.Clear();

        // student dropdown is only filled once in OnLoad, so reload it
        studentBox.DataSource = Library.Students();
        MessageBox.Show("Student added.");
    }

    void AddBook()
    {
        var title = newBookTitleBox.Text.Trim();
        var author = newBookAuthorBox.Text.Trim();
        if (title == "" || author == "" || !long.TryParse(newBookIdBox.Text, out var id))
        {
            MessageBox.Show("Enter a title, an author and a numeric book id.");
            return;
        }

        if (!Library.AddBook(id, title, author))
        {
            MessageBox.Show("A book with that id already exists.");
            return;
        }

        newBookIdBox.Clear();
        newBookTitleBox.Clear();
        newBookAuthorBox.Clear();

        // also refreshes the book dropdown
        RefreshAll();
        MessageBox.Show("Book added.");
    }

    void Search(bool books)
    {
        var q = queryBox.Text.Trim();
        var hits = books ? Library.SearchBooks(q) : Library.SearchStudents(q);

        searchTitle.Text = $"Loan history for \"{q}\" ({hits.Count} result{(hits.Count == 1 ? "" : "s")})";
        searchGrid.Rows.Clear();
        foreach (var l in hits)
        {
            AddRow(searchGrid, l, l.Student, l.Book, Fmt(l.Out), l.Returned is { } r ? Fmt(r) : "-");
        }
    }

    void RefreshAll()
    {
        // only books that not out
        bookBox.DataSource = Library.AvailableBooks();

        outGrid.Rows.Clear();
        foreach (var l in Library.LoansOut())
        {
            AddRow(outGrid, l, l.Student, l.Book, Fmt(l.Out), Fmt(l.Due));
        }

        var late = Library.Overdue();
        overdueTitle.Text = $"Overdue loans ({late.Count})";
        overdueGrid.Rows.Clear();
        foreach (var l in late)
        {
            var row = AddRow(overdueGrid, l, l.Student, l.Book, Fmt(l.Due), DaysLate(l));
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
        var row = g.Rows[g.Rows.Add(cells)];
        row.Tag = tag;
        return row;
    }

    // apply grid colours at runtime to not clutter the designer file
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
            SelectionBackColor = head,
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