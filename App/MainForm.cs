
namespace App;

public partial class MainForm : Form
{
    readonly Font boldFont;

    public MainForm()
    {
        InitializeComponent();

        boldFont = new Font(Font, FontStyle.Bold);
        dueBox.Value = DateTime.Today.AddDays(14);

        foreach (var g in new[] { outGrid, overdueGrid, searchGrid })
            StyleGrid(g);
    }

    void addButton_Click(object? sender, EventArgs e) { }
    void returnButton_Click(object? sender, EventArgs e) { }
    void refreshButton_Click(object? sender, EventArgs e) { }
    void searchStudentsButton_Click(object? sender, EventArgs e) { }
    void searchBooksButton_Click(object? sender, EventArgs e) { }

    private void MainForm_Load(object sender, EventArgs e) { }

    // Apply grid colours at runtime to keep the designer file clean.
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

        g.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(0xCF, 0xE2, 0xFF);
        g.DefaultCellStyle.SelectionForeColor = Color.Black;
        g.DefaultCellStyle.Padding = new Padding(2, 3, 2, 3);
    }
}
