namespace App;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabs = new TabControl();
        loansTab = new TabPage();
        loansLayout = new TableLayoutPanel();
        loansInput = new TableLayoutPanel();
        studentLabel = new Label();
        bookLabel = new Label();
        dueLabel = new Label();
        studentBox = new ComboBox();
        bookBox = new ComboBox();
        dueBox = new DateTimePicker();
        addButton = new Button();
        messageLabel = new Label();
        currentlyOutHeading = new Label();
        outGrid = new DataGridView();
        outStudentCol = new DataGridViewTextBoxColumn();
        outBookCol = new DataGridViewTextBoxColumn();
        outOutCol = new DataGridViewTextBoxColumn();
        outDueCol = new DataGridViewTextBoxColumn();
        returnButton = new Button();
        overdueTab = new TabPage();
        overdueLayout = new TableLayoutPanel();
        overdueHead = new TableLayoutPanel();
        overdueTitle = new Label();
        overdueGrid = new DataGridView();
        overdueStudentCol = new DataGridViewTextBoxColumn();
        overdueBookCol = new DataGridViewTextBoxColumn();
        overdueDueCol = new DataGridViewTextBoxColumn();
        overdueDaysCol = new DataGridViewTextBoxColumn();
        searchTab = new TabPage();
        searchLayout = new TableLayoutPanel();
        searchInput = new TableLayoutPanel();
        queryLabel = new Label();
        queryBox = new TextBox();
        searchStudentsButton = new Button();
        searchBooksButton = new Button();
        searchTitle = new Label();
        searchGrid = new DataGridView();
        searchStudentCol = new DataGridViewTextBoxColumn();
        searchBookCol = new DataGridViewTextBoxColumn();
        searchOutCol = new DataGridViewTextBoxColumn();
        searchReturnedCol = new DataGridViewTextBoxColumn();
        addTab = new TabPage();
        newStudentIdLabel = new Label();
        newStudentIdBox = new TextBox();
        newStudentNameLabel = new Label();
        newStudentNameBox = new TextBox();
        addStudentButton = new Button();
        newBookIdLabel = new Label();
        newBookIdBox = new TextBox();
        newBookTitleLabel = new Label();
        newBookTitleBox = new TextBox();
        newBookAuthorLabel = new Label();
        newBookAuthorBox = new TextBox();
        addBookButton = new Button();
        tabs.SuspendLayout();
        loansTab.SuspendLayout();
        loansLayout.SuspendLayout();
        loansInput.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)outGrid).BeginInit();
        overdueTab.SuspendLayout();
        overdueLayout.SuspendLayout();
        overdueHead.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)overdueGrid).BeginInit();
        searchTab.SuspendLayout();
        searchLayout.SuspendLayout();
        searchInput.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
        addTab.SuspendLayout();
        SuspendLayout();
        // 
        // tabs
        // 
        tabs.Controls.Add(loansTab);
        tabs.Controls.Add(overdueTab);
        tabs.Controls.Add(searchTab);
        tabs.Controls.Add(addTab);
        tabs.Dock = DockStyle.Fill;
        tabs.Location = new Point(0, 0);
        tabs.Name = "tabs";
        tabs.Padding = new Point(18, 6);
        tabs.SelectedIndex = 0;
        tabs.Size = new Size(880, 560);
        tabs.TabIndex = 0;
        // 
        // loansTab
        // 
        loansTab.BackColor = Color.White;
        loansTab.Controls.Add(loansLayout);
        loansTab.Location = new Point(4, 30);
        loansTab.Name = "loansTab";
        loansTab.Padding = new Padding(16, 16, 16, 16);
        loansTab.Size = new Size(872, 526);
        loansTab.TabIndex = 0;
        loansTab.Text = "Loans";
        // 
        // loansLayout
        // 
        loansLayout.ColumnCount = 1;
        loansLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        loansLayout.Controls.Add(loansInput, 0, 0);
        loansLayout.Controls.Add(messageLabel, 0, 1);
        loansLayout.Controls.Add(currentlyOutHeading, 0, 2);
        loansLayout.Controls.Add(outGrid, 0, 3);
        loansLayout.Controls.Add(returnButton, 0, 4);
        loansLayout.Dock = DockStyle.Fill;
        loansLayout.Location = new Point(16, 16);
        loansLayout.Name = "loansLayout";
        loansLayout.RowCount = 5;
        loansLayout.RowStyles.Add(new RowStyle());
        loansLayout.RowStyles.Add(new RowStyle());
        loansLayout.RowStyles.Add(new RowStyle());
        loansLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        loansLayout.RowStyles.Add(new RowStyle());
        loansLayout.Size = new Size(840, 494);
        loansLayout.TabIndex = 0;
        // 
        // loansInput
        // 
        loansInput.AutoSize = true;
        loansInput.ColumnCount = 4;
        loansInput.ColumnStyles.Add(new ColumnStyle());
        loansInput.ColumnStyles.Add(new ColumnStyle());
        loansInput.ColumnStyles.Add(new ColumnStyle());
        loansInput.ColumnStyles.Add(new ColumnStyle());
        loansInput.Controls.Add(studentLabel, 0, 0);
        loansInput.Controls.Add(bookLabel, 1, 0);
        loansInput.Controls.Add(dueLabel, 2, 0);
        loansInput.Controls.Add(studentBox, 0, 1);
        loansInput.Controls.Add(bookBox, 1, 1);
        loansInput.Controls.Add(dueBox, 2, 1);
        loansInput.Controls.Add(addButton, 3, 1);
        loansInput.Dock = DockStyle.Fill;
        loansInput.Location = new Point(0, 0);
        loansInput.Margin = new Padding(0);
        loansInput.Name = "loansInput";
        loansInput.RowCount = 2;
        loansInput.RowStyles.Add(new RowStyle());
        loansInput.RowStyles.Add(new RowStyle());
        loansInput.Size = new Size(840, 51);
        loansInput.TabIndex = 0;
        // 
        // studentLabel
        // 
        studentLabel.AutoSize = true;
        studentLabel.Location = new Point(0, 0);
        studentLabel.Margin = new Padding(0, 0, 0, 4);
        studentLabel.Name = "studentLabel";
        studentLabel.Size = new Size(48, 15);
        studentLabel.TabIndex = 0;
        studentLabel.Text = "Student";
        // 
        // bookLabel
        // 
        bookLabel.AutoSize = true;
        bookLabel.Location = new Point(212, 0);
        bookLabel.Margin = new Padding(0, 0, 0, 4);
        bookLabel.Name = "bookLabel";
        bookLabel.Size = new Size(34, 15);
        bookLabel.TabIndex = 1;
        bookLabel.Text = "Book";
        // 
        // dueLabel
        // 
        dueLabel.AutoSize = true;
        dueLabel.Location = new Point(464, 0);
        dueLabel.Margin = new Padding(0, 0, 0, 4);
        dueLabel.Name = "dueLabel";
        dueLabel.Size = new Size(54, 15);
        dueLabel.TabIndex = 2;
        dueLabel.Text = "Due date";
        // 
        // studentBox
        // 
        studentBox.Anchor = AnchorStyles.Left;
        studentBox.DropDownStyle = ComboBoxStyle.DropDownList;
        studentBox.FormattingEnabled = true;
        studentBox.Location = new Point(0, 23);
        studentBox.Margin = new Padding(0, 0, 12, 0);
        studentBox.Name = "studentBox";
        studentBox.Size = new Size(200, 23);
        studentBox.TabIndex = 3;
        // 
        // bookBox
        // 
        bookBox.Anchor = AnchorStyles.Left;
        bookBox.DropDownStyle = ComboBoxStyle.DropDownList;
        bookBox.FormattingEnabled = true;
        bookBox.Location = new Point(212, 23);
        bookBox.Margin = new Padding(0, 0, 12, 0);
        bookBox.Name = "bookBox";
        bookBox.Size = new Size(240, 23);
        bookBox.TabIndex = 4;
        // 
        // dueBox
        // 
        dueBox.Anchor = AnchorStyles.Left;
        dueBox.CustomFormat = "dd/MM/yyyy";
        dueBox.Format = DateTimePickerFormat.Custom;
        dueBox.Location = new Point(464, 23);
        dueBox.Margin = new Padding(0, 0, 12, 0);
        dueBox.Name = "dueBox";
        dueBox.Size = new Size(120, 23);
        dueBox.TabIndex = 5;
        // 
        // addButton
        // 
        addButton.Anchor = AnchorStyles.Left;
        addButton.AutoSize = true;
        addButton.BackColor = Color.FromArgb(26, 95, 180);
        addButton.FlatAppearance.BorderColor = Color.FromArgb(26, 95, 180);
        addButton.FlatStyle = FlatStyle.Flat;
        addButton.ForeColor = Color.White;
        addButton.Location = new Point(596, 19);
        addButton.Margin = new Padding(0);
        addButton.MinimumSize = new Size(0, 32);
        addButton.Name = "addButton";
        addButton.Padding = new Padding(8, 0, 8, 0);
        addButton.Size = new Size(98, 32);
        addButton.TabIndex = 6;
        addButton.Text = "Add loan";
        addButton.UseVisualStyleBackColor = false;
        addButton.Click += addButton_Click;
        // 
        // messageLabel
        // 
        messageLabel.AutoSize = true;
        messageLabel.Location = new Point(0, 55);
        messageLabel.Margin = new Padding(0, 4, 0, 4);
        messageLabel.Name = "messageLabel";
        messageLabel.Size = new Size(10, 15);
        messageLabel.TabIndex = 1;
        messageLabel.Text = " ";
        // 
        // currentlyOutHeading
        // 
        currentlyOutHeading.AutoSize = true;
        currentlyOutHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        currentlyOutHeading.Location = new Point(0, 82);
        currentlyOutHeading.Margin = new Padding(0, 8, 0, 8);
        currentlyOutHeading.Name = "currentlyOutHeading";
        currentlyOutHeading.Size = new Size(111, 21);
        currentlyOutHeading.TabIndex = 2;
        currentlyOutHeading.Text = "Currently out";
        // 
        // outGrid
        // 
        outGrid.AllowUserToAddRows = false;
        outGrid.AllowUserToDeleteRows = false;
        outGrid.AllowUserToResizeRows = false;
        outGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        outGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        outGrid.Columns.AddRange(new DataGridViewColumn[] { outStudentCol, outBookCol, outOutCol, outDueCol });
        outGrid.Dock = DockStyle.Fill;
        outGrid.Location = new Point(3, 114);
        outGrid.MultiSelect = false;
        outGrid.Name = "outGrid";
        outGrid.ReadOnly = true;
        outGrid.RowHeadersVisible = false;
        outGrid.RowHeadersWidth = 51;
        outGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        outGrid.Size = new Size(834, 339);
        outGrid.TabIndex = 3;
        // 
        // outStudentCol
        // 
        outStudentCol.HeaderText = "Student";
        outStudentCol.MinimumWidth = 6;
        outStudentCol.Name = "outStudentCol";
        outStudentCol.ReadOnly = true;
        // 
        // outBookCol
        // 
        outBookCol.HeaderText = "Book";
        outBookCol.MinimumWidth = 6;
        outBookCol.Name = "outBookCol";
        outBookCol.ReadOnly = true;
        // 
        // outOutCol
        // 
        outOutCol.HeaderText = "Out";
        outOutCol.MinimumWidth = 6;
        outOutCol.Name = "outOutCol";
        outOutCol.ReadOnly = true;
        // 
        // outDueCol
        // 
        outDueCol.HeaderText = "Due";
        outDueCol.MinimumWidth = 6;
        outDueCol.Name = "outDueCol";
        outDueCol.ReadOnly = true;
        // 
        // returnButton
        // 
        returnButton.Anchor = AnchorStyles.Right;
        returnButton.AutoSize = true;
        returnButton.BackColor = Color.White;
        returnButton.FlatAppearance.BorderColor = Color.FromArgb(26, 95, 180);
        returnButton.FlatStyle = FlatStyle.Flat;
        returnButton.ForeColor = Color.FromArgb(26, 95, 180);
        returnButton.Location = new Point(707, 459);
        returnButton.MinimumSize = new Size(0, 32);
        returnButton.Name = "returnButton";
        returnButton.Padding = new Padding(8, 0, 8, 0);
        returnButton.Size = new Size(130, 32);
        returnButton.TabIndex = 4;
        returnButton.Text = "Mark returned";
        returnButton.UseVisualStyleBackColor = false;
        returnButton.Click += returnButton_Click;
        // 
        // overdueTab
        // 
        overdueTab.BackColor = Color.White;
        overdueTab.Controls.Add(overdueLayout);
        overdueTab.Location = new Point(4, 30);
        overdueTab.Name = "overdueTab";
        overdueTab.Padding = new Padding(16, 16, 16, 16);
        overdueTab.Size = new Size(872, 526);
        overdueTab.TabIndex = 1;
        overdueTab.Text = "Overdue";
        // 
        // overdueLayout
        // 
        overdueLayout.ColumnCount = 1;
        overdueLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        overdueLayout.Controls.Add(overdueHead, 0, 0);
        overdueLayout.Controls.Add(overdueGrid, 0, 1);
        overdueLayout.Dock = DockStyle.Fill;
        overdueLayout.Location = new Point(16, 16);
        overdueLayout.Name = "overdueLayout";
        overdueLayout.RowCount = 2;
        overdueLayout.RowStyles.Add(new RowStyle());
        overdueLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        overdueLayout.Size = new Size(840, 494);
        overdueLayout.TabIndex = 0;
        // 
        // overdueHead
        // 
        overdueHead.AutoSize = true;
        overdueHead.ColumnCount = 2;
        overdueHead.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        overdueHead.ColumnStyles.Add(new ColumnStyle());
        overdueHead.Controls.Add(overdueTitle, 0, 0);
        overdueHead.Dock = DockStyle.Fill;
        overdueHead.Location = new Point(0, 0);
        overdueHead.Margin = new Padding(0);
        overdueHead.Name = "overdueHead";
        overdueHead.RowCount = 1;
        overdueHead.RowStyles.Add(new RowStyle());
        overdueHead.Size = new Size(840, 37);
        overdueHead.TabIndex = 0;
        // 
        // overdueTitle
        // 
        overdueTitle.Anchor = AnchorStyles.Left;
        overdueTitle.AutoSize = true;
        overdueTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        overdueTitle.Location = new Point(0, 8);
        overdueTitle.Margin = new Padding(0, 8, 0, 8);
        overdueTitle.Name = "overdueTitle";
        overdueTitle.Size = new Size(145, 21);
        overdueTitle.TabIndex = 0;
        overdueTitle.Text = "Overdue loans (0)";
        // 
        // overdueGrid
        // 
        overdueGrid.AllowUserToAddRows = false;
        overdueGrid.AllowUserToDeleteRows = false;
        overdueGrid.AllowUserToResizeRows = false;
        overdueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        overdueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        overdueGrid.Columns.AddRange(new DataGridViewColumn[] { overdueStudentCol, overdueBookCol, overdueDueCol, overdueDaysCol });
        overdueGrid.Dock = DockStyle.Fill;
        overdueGrid.Location = new Point(3, 40);
        overdueGrid.MultiSelect = false;
        overdueGrid.Name = "overdueGrid";
        overdueGrid.ReadOnly = true;
        overdueGrid.RowHeadersVisible = false;
        overdueGrid.RowHeadersWidth = 51;
        overdueGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        overdueGrid.Size = new Size(834, 451);
        overdueGrid.TabIndex = 1;
        // 
        // overdueStudentCol
        // 
        overdueStudentCol.HeaderText = "Student";
        overdueStudentCol.MinimumWidth = 6;
        overdueStudentCol.Name = "overdueStudentCol";
        overdueStudentCol.ReadOnly = true;
        // 
        // overdueBookCol
        // 
        overdueBookCol.HeaderText = "Book";
        overdueBookCol.MinimumWidth = 6;
        overdueBookCol.Name = "overdueBookCol";
        overdueBookCol.ReadOnly = true;
        // 
        // overdueDueCol
        // 
        overdueDueCol.HeaderText = "Due";
        overdueDueCol.MinimumWidth = 6;
        overdueDueCol.Name = "overdueDueCol";
        overdueDueCol.ReadOnly = true;
        // 
        // overdueDaysCol
        // 
        overdueDaysCol.HeaderText = "Days late";
        overdueDaysCol.MinimumWidth = 6;
        overdueDaysCol.Name = "overdueDaysCol";
        overdueDaysCol.ReadOnly = true;
        // 
        // searchTab
        // 
        searchTab.BackColor = Color.White;
        searchTab.Controls.Add(searchLayout);
        searchTab.Location = new Point(4, 30);
        searchTab.Name = "searchTab";
        searchTab.Padding = new Padding(16, 16, 16, 16);
        searchTab.Size = new Size(872, 526);
        searchTab.TabIndex = 2;
        searchTab.Text = "Search";
        // 
        // searchLayout
        // 
        searchLayout.ColumnCount = 1;
        searchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        searchLayout.Controls.Add(searchInput, 0, 0);
        searchLayout.Controls.Add(searchTitle, 0, 1);
        searchLayout.Controls.Add(searchGrid, 0, 2);
        searchLayout.Dock = DockStyle.Fill;
        searchLayout.Location = new Point(16, 16);
        searchLayout.Name = "searchLayout";
        searchLayout.RowCount = 3;
        searchLayout.RowStyles.Add(new RowStyle());
        searchLayout.RowStyles.Add(new RowStyle());
        searchLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        searchLayout.Size = new Size(840, 494);
        searchLayout.TabIndex = 0;
        // 
        // searchInput
        // 
        searchInput.AutoSize = true;
        searchInput.ColumnCount = 3;
        searchInput.ColumnStyles.Add(new ColumnStyle());
        searchInput.ColumnStyles.Add(new ColumnStyle());
        searchInput.ColumnStyles.Add(new ColumnStyle());
        searchInput.Controls.Add(queryLabel, 0, 0);
        searchInput.Controls.Add(queryBox, 0, 1);
        searchInput.Controls.Add(searchStudentsButton, 1, 1);
        searchInput.Controls.Add(searchBooksButton, 2, 1);
        searchInput.Dock = DockStyle.Fill;
        searchInput.Location = new Point(0, 0);
        searchInput.Margin = new Padding(0);
        searchInput.Name = "searchInput";
        searchInput.RowCount = 2;
        searchInput.RowStyles.Add(new RowStyle());
        searchInput.RowStyles.Add(new RowStyle());
        searchInput.Size = new Size(840, 51);
        searchInput.TabIndex = 0;
        // 
        // queryLabel
        // 
        queryLabel.AutoSize = true;
        queryLabel.Location = new Point(0, 0);
        queryLabel.Margin = new Padding(0, 0, 0, 4);
        queryLabel.Name = "queryLabel";
        queryLabel.Size = new Size(60, 15);
        queryLabel.TabIndex = 0;
        queryLabel.Text = "Search for";
        // 
        // queryBox
        // 
        queryBox.Anchor = AnchorStyles.Left;
        queryBox.Location = new Point(0, 23);
        queryBox.Margin = new Padding(0, 0, 12, 0);
        queryBox.Name = "queryBox";
        queryBox.Size = new Size(260, 23);
        queryBox.TabIndex = 1;
        // 
        // searchStudentsButton
        // 
        searchStudentsButton.Anchor = AnchorStyles.Left;
        searchStudentsButton.AutoSize = true;
        searchStudentsButton.BackColor = Color.FromArgb(26, 95, 180);
        searchStudentsButton.FlatAppearance.BorderColor = Color.FromArgb(26, 95, 180);
        searchStudentsButton.FlatStyle = FlatStyle.Flat;
        searchStudentsButton.ForeColor = Color.White;
        searchStudentsButton.Location = new Point(272, 19);
        searchStudentsButton.Margin = new Padding(0, 0, 12, 0);
        searchStudentsButton.MinimumSize = new Size(0, 32);
        searchStudentsButton.Name = "searchStudentsButton";
        searchStudentsButton.Padding = new Padding(8, 0, 8, 0);
        searchStudentsButton.Size = new Size(140, 32);
        searchStudentsButton.TabIndex = 2;
        searchStudentsButton.Text = "Search students";
        searchStudentsButton.UseVisualStyleBackColor = false;
        searchStudentsButton.Click += searchStudentsButton_Click;
        // 
        // searchBooksButton
        // 
        searchBooksButton.Anchor = AnchorStyles.Left;
        searchBooksButton.AutoSize = true;
        searchBooksButton.BackColor = Color.White;
        searchBooksButton.FlatAppearance.BorderColor = Color.FromArgb(26, 95, 180);
        searchBooksButton.FlatStyle = FlatStyle.Flat;
        searchBooksButton.ForeColor = Color.FromArgb(26, 95, 180);
        searchBooksButton.Location = new Point(424, 19);
        searchBooksButton.Margin = new Padding(0);
        searchBooksButton.MinimumSize = new Size(0, 32);
        searchBooksButton.Name = "searchBooksButton";
        searchBooksButton.Padding = new Padding(8, 0, 8, 0);
        searchBooksButton.Size = new Size(125, 32);
        searchBooksButton.TabIndex = 3;
        searchBooksButton.Text = "Search books";
        searchBooksButton.UseVisualStyleBackColor = false;
        searchBooksButton.Click += searchBooksButton_Click;
        // 
        // searchTitle
        // 
        searchTitle.AutoSize = true;
        searchTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        searchTitle.Location = new Point(0, 59);
        searchTitle.Margin = new Padding(0, 8, 0, 8);
        searchTitle.Name = "searchTitle";
        searchTitle.Size = new Size(305, 21);
        searchTitle.TabIndex = 1;
        searchTitle.Text = "Search loan history by student or book";
        // 
        // searchGrid
        // 
        searchGrid.AllowUserToAddRows = false;
        searchGrid.AllowUserToDeleteRows = false;
        searchGrid.AllowUserToResizeRows = false;
        searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        searchGrid.Columns.AddRange(new DataGridViewColumn[] { searchStudentCol, searchBookCol, searchOutCol, searchReturnedCol });
        searchGrid.Dock = DockStyle.Fill;
        searchGrid.Location = new Point(3, 91);
        searchGrid.MultiSelect = false;
        searchGrid.Name = "searchGrid";
        searchGrid.ReadOnly = true;
        searchGrid.RowHeadersVisible = false;
        searchGrid.RowHeadersWidth = 51;
        searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        searchGrid.Size = new Size(834, 400);
        searchGrid.TabIndex = 2;
        // 
        // searchStudentCol
        // 
        searchStudentCol.HeaderText = "Student";
        searchStudentCol.MinimumWidth = 6;
        searchStudentCol.Name = "searchStudentCol";
        searchStudentCol.ReadOnly = true;
        // 
        // searchBookCol
        // 
        searchBookCol.HeaderText = "Book";
        searchBookCol.MinimumWidth = 6;
        searchBookCol.Name = "searchBookCol";
        searchBookCol.ReadOnly = true;
        // 
        // searchOutCol
        // 
        searchOutCol.HeaderText = "Out";
        searchOutCol.MinimumWidth = 6;
        searchOutCol.Name = "searchOutCol";
        searchOutCol.ReadOnly = true;
        // 
        // searchReturnedCol
        // 
        searchReturnedCol.HeaderText = "Returned";
        searchReturnedCol.MinimumWidth = 6;
        searchReturnedCol.Name = "searchReturnedCol";
        searchReturnedCol.ReadOnly = true;
        // 
        // addTab
        // 
        addTab.Controls.Add(newStudentIdLabel);
        addTab.Controls.Add(newStudentIdBox);
        addTab.Controls.Add(newStudentNameLabel);
        addTab.Controls.Add(newStudentNameBox);
        addTab.Controls.Add(addStudentButton);
        addTab.Controls.Add(newBookIdLabel);
        addTab.Controls.Add(newBookIdBox);
        addTab.Controls.Add(newBookTitleLabel);
        addTab.Controls.Add(newBookTitleBox);
        addTab.Controls.Add(newBookAuthorLabel);
        addTab.Controls.Add(newBookAuthorBox);
        addTab.Controls.Add(addBookButton);
        addTab.Location = new Point(4, 30);
        addTab.Name = "addTab";
        addTab.Padding = new Padding(16);
        addTab.Size = new Size(872, 526);
        addTab.TabIndex = 3;
        addTab.Text = "Add";
        addTab.UseVisualStyleBackColor = true;
        // 
        // newStudentIdLabel
        // 
        newStudentIdLabel.AutoSize = true;
        newStudentIdLabel.Location = new Point(16, 16);
        newStudentIdLabel.Name = "newStudentIdLabel";
        newStudentIdLabel.Size = new Size(100, 15);
        newStudentIdLabel.TabIndex = 0;
        newStudentIdLabel.Text = "Student number";
        // 
        // newStudentIdBox
        // 
        newStudentIdBox.Location = new Point(16, 36);
        newStudentIdBox.Name = "newStudentIdBox";
        newStudentIdBox.Size = new Size(200, 23);
        newStudentIdBox.TabIndex = 1;
        // 
        // newStudentNameLabel
        // 
        newStudentNameLabel.AutoSize = true;
        newStudentNameLabel.Location = new Point(16, 76);
        newStudentNameLabel.Name = "newStudentNameLabel";
        newStudentNameLabel.Size = new Size(100, 15);
        newStudentNameLabel.TabIndex = 2;
        newStudentNameLabel.Text = "Student name";
        // 
        // newStudentNameBox
        // 
        newStudentNameBox.Location = new Point(16, 96);
        newStudentNameBox.Name = "newStudentNameBox";
        newStudentNameBox.Size = new Size(200, 23);
        newStudentNameBox.TabIndex = 3;
        // 
        // addStudentButton
        // 
        addStudentButton.Location = new Point(16, 136);
        addStudentButton.Name = "addStudentButton";
        addStudentButton.Size = new Size(120, 30);
        addStudentButton.TabIndex = 4;
        addStudentButton.Text = "Add student";
        addStudentButton.UseVisualStyleBackColor = true;
        addStudentButton.Click += addStudentButton_Click;
        // 
        // newBookIdLabel
        // 
        newBookIdLabel.AutoSize = true;
        newBookIdLabel.Location = new Point(300, 16);
        newBookIdLabel.Name = "newBookIdLabel";
        newBookIdLabel.Size = new Size(100, 15);
        newBookIdLabel.TabIndex = 5;
        newBookIdLabel.Text = "Book id";
        // 
        // newBookIdBox
        // 
        newBookIdBox.Location = new Point(300, 36);
        newBookIdBox.Name = "newBookIdBox";
        newBookIdBox.Size = new Size(200, 23);
        newBookIdBox.TabIndex = 6;
        // 
        // newBookTitleLabel
        // 
        newBookTitleLabel.AutoSize = true;
        newBookTitleLabel.Location = new Point(300, 76);
        newBookTitleLabel.Name = "newBookTitleLabel";
        newBookTitleLabel.Size = new Size(100, 15);
        newBookTitleLabel.TabIndex = 7;
        newBookTitleLabel.Text = "Book title";
        // 
        // newBookTitleBox
        // 
        newBookTitleBox.Location = new Point(300, 96);
        newBookTitleBox.Name = "newBookTitleBox";
        newBookTitleBox.Size = new Size(200, 23);
        newBookTitleBox.TabIndex = 8;
        // 
        // newBookAuthorLabel
        // 
        newBookAuthorLabel.AutoSize = true;
        newBookAuthorLabel.Location = new Point(300, 136);
        newBookAuthorLabel.Name = "newBookAuthorLabel";
        newBookAuthorLabel.Size = new Size(100, 15);
        newBookAuthorLabel.TabIndex = 9;
        newBookAuthorLabel.Text = "Book author";
        // 
        // newBookAuthorBox
        // 
        newBookAuthorBox.Location = new Point(300, 156);
        newBookAuthorBox.Name = "newBookAuthorBox";
        newBookAuthorBox.Size = new Size(200, 23);
        newBookAuthorBox.TabIndex = 10;
        // 
        // addBookButton
        // 
        addBookButton.Location = new Point(300, 196);
        addBookButton.Name = "addBookButton";
        addBookButton.Size = new Size(120, 30);
        addBookButton.TabIndex = 11;
        addBookButton.Text = "Add book";
        addBookButton.UseVisualStyleBackColor = true;
        addBookButton.Click += addBookButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 243, 243);
        ClientSize = new Size(880, 560);
        Controls.Add(tabs);
        MinimumSize = new Size(760, 478);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Loan Manager";
        Load += MainForm_Load;
        tabs.ResumeLayout(false);
        loansTab.ResumeLayout(false);
        loansLayout.ResumeLayout(false);
        loansLayout.PerformLayout();
        loansInput.ResumeLayout(false);
        loansInput.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)outGrid).EndInit();
        overdueTab.ResumeLayout(false);
        overdueLayout.ResumeLayout(false);
        overdueLayout.PerformLayout();
        overdueHead.ResumeLayout(false);
        overdueHead.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)overdueGrid).EndInit();
        searchTab.ResumeLayout(false);
        searchLayout.ResumeLayout(false);
        searchLayout.PerformLayout();
        searchInput.ResumeLayout(false);
        searchInput.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
        addTab.ResumeLayout(false);
        addTab.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TabControl tabs;
    private System.Windows.Forms.TabPage loansTab;
    private System.Windows.Forms.TableLayoutPanel loansLayout;
    private System.Windows.Forms.TableLayoutPanel loansInput;
    private System.Windows.Forms.Label studentLabel;
    private System.Windows.Forms.Label bookLabel;
    private System.Windows.Forms.Label dueLabel;
    private System.Windows.Forms.ComboBox studentBox;
    private System.Windows.Forms.ComboBox bookBox;
    private System.Windows.Forms.DateTimePicker dueBox;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Label messageLabel;
    private System.Windows.Forms.Label currentlyOutHeading;
    private System.Windows.Forms.DataGridView outGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn outStudentCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn outBookCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn outOutCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn outDueCol;
    private System.Windows.Forms.Button returnButton;
    private System.Windows.Forms.TabPage overdueTab;
    private System.Windows.Forms.TableLayoutPanel overdueLayout;
    private System.Windows.Forms.TableLayoutPanel overdueHead;
    private System.Windows.Forms.Label overdueTitle;
    private System.Windows.Forms.DataGridView overdueGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn overdueStudentCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn overdueBookCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn overdueDueCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn overdueDaysCol;
    private System.Windows.Forms.TabPage searchTab;
    private System.Windows.Forms.TableLayoutPanel searchLayout;
    private System.Windows.Forms.TableLayoutPanel searchInput;
    private System.Windows.Forms.Label queryLabel;
    private System.Windows.Forms.TextBox queryBox;
    private System.Windows.Forms.Button searchStudentsButton;
    private System.Windows.Forms.Button searchBooksButton;
    private System.Windows.Forms.Label searchTitle;
    private System.Windows.Forms.DataGridView searchGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn searchStudentCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn searchBookCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn searchOutCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn searchReturnedCol;
    private TabPage addTab;
    private Label newStudentIdLabel;
    private TextBox newStudentIdBox;
    private Label newStudentNameLabel;
    private TextBox newStudentNameBox;
    private Button addStudentButton;
    private Label newBookIdLabel;
    private TextBox newBookIdBox;
    private Label newBookTitleLabel;
    private TextBox newBookTitleBox;
    private Label newBookAuthorLabel;
    private TextBox newBookAuthorBox;
    private Button addBookButton;
}