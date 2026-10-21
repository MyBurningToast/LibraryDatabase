namespace App;

public partial class MainForm : Form
{
    static readonly Color Green = Color.FromArgb(0x14, 0x61, 0x2F);
    static readonly Color Red = Color.FromArgb(0xA4, 0x00, 0x1E);

    readonly Library lib = Library.Fakedata();
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

        studentBox.DataSource = lib.Students.ToList();
        bookBox.DataSource = lib.Books.ToList();
        RefreshAll();
    }

    // events (connected to designer)

    void addButton_Click(object? sender, EventArgs e) => AddLoan();
    void returnButton_Click(object? sender, EventArgs e) => MarkReturned();
    void refreshButton_Click(object? sender, EventArgs e) => RefreshAll();
    void searchStudentsButton_Click(object? sender, EventArgs e) => Search(books: false);
    void searchBooksButton_Click(object? sender, EventArgs e) => Search(books: true);

    // actions

    void AddLoan()
    {
        if (studentBox.SelectedItem is not string who || bookBox.SelectedItem is not string book) return;
        var due = dueBox.Value.Date;

        if (due <= DateTime.Today)
        {
            Notify("Due date must be after today.", ok: false);
            return;
        }
        if (lib.Loans.Any(l => l.Book == book && l.Returned is null))
        {
            Notify($"\"{book}\" is already out.", ok: false);
            return;
        }

        lib.Loans.Add(new Loan(who, book, DateTime.Today, due));
        Notify("Loan added.", ok: true);
        RefreshAll();
    }

    void MarkReturned()
    {
        if (outGrid.CurrentRow?.Tag is not Loan loan) { Notify("Select a loan first.", ok: false); return; }
        loan.Returned = DateTime.Today;
        Notify($"\"{loan.Book}\" marked returned.", ok: true);
        RefreshAll();
    }

    void Search(bool books)
    {
        var q = queryBox.Text.Trim();
        var hits = lib.Loans
            .Where(l => (books ? l.Book : l.Student).Contains(q, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(l => l.Out)
            .ToList();

        searchTitle.Text = $"Loan history for \"{q}\" ({hits.Count} result{(hits.Count == 1 ? "" : "s")})";
        searchGrid.Rows.Clear();
        foreach (var l in hits)
        {
            AddRow(searchGrid, l, l.Student, l.Book, Fmt(l.Out), l.Returned is { } r ? Fmt(r) : "-");

        }
    }

    void RefreshAll()
    {
        outGrid.Rows.Clear();
        foreach (var l in lib.Loans.Where(l => l.Returned is null).OrderBy(l => l.Out))
        {
            AddRow(outGrid, l, l.Student, l.Book, Fmt(l.Out), Fmt(l.Due));
        }    

        var late = lib.Loans
            .Where(l => l.Returned is null && l.Due.Date < DateTime.Today)
            .OrderByDescending(DaysLate)
            .ToList();
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
        messageLabel.ForeColor = ok ? Red : Green;
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