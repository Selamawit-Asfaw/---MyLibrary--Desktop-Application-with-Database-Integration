namespace LibraryProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Books = new System.Windows.Forms.TabControl();
            this.booksTabPage = new System.Windows.Forms.TabPage();
            this.pnlEditBook = new System.Windows.Forms.Panel();
            this.btnSaveEditedBook = new System.Windows.Forms.Button();
            this.txtEditBookCopies = new System.Windows.Forms.TextBox();
            this.lblEditBookCopies = new System.Windows.Forms.Label();
            this.txtEditBookYear = new System.Windows.Forms.TextBox();
            this.lblEditBookYear = new System.Windows.Forms.Label();
            this.txtEditBookAuthor = new System.Windows.Forms.TextBox();
            this.lblEditBookAuthor = new System.Windows.Forms.Label();
            this.txtEditBookTitle = new System.Windows.Forms.TextBox();
            this.lblEditBookTitle = new System.Windows.Forms.Label();
            this.pnlAddBook = new System.Windows.Forms.Panel();
            this.btnAddInternalBook = new System.Windows.Forms.Button();
            this.txtAddBookCopies = new System.Windows.Forms.TextBox();
            this.lblAddBookCopies = new System.Windows.Forms.Label();
            this.txtAddBookYear = new System.Windows.Forms.TextBox();
            this.lblAddBookYear = new System.Windows.Forms.Label();
            this.txtAddBookAuthor = new System.Windows.Forms.TextBox();
            this.lblAddBookAuthor = new System.Windows.Forms.Label();
            this.txtAddBookTitle = new System.Windows.Forms.TextBox();
            this.lblAddBookTitle = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panelBooksActions = new System.Windows.Forms.Panel();
            this.lblFilterYearRange = new System.Windows.Forms.Label();
            this.txtFilterYearEnd = new System.Windows.Forms.TextBox();
            this.lblFilterYearTo = new System.Windows.Forms.Label();
            this.txtFilterYearStart = new System.Windows.Forms.TextBox();
            this.btnApplyBookFilter = new System.Windows.Forms.Button();
            this.txtFilterAuthor = new System.Windows.Forms.TextBox();
            this.lblFilterAuthor = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.borrowersTabPage = new System.Windows.Forms.TabPage();
            this.pnlEditBorrower = new System.Windows.Forms.Panel();
            this.btnSaveEditedBorrower = new System.Windows.Forms.Button();
            this.txtEditBorrowerPhone = new System.Windows.Forms.TextBox();
            this.lblEditBorrowerPhone = new System.Windows.Forms.Label();
            this.txtEditBorrowerEmail = new System.Windows.Forms.TextBox();
            this.lblEditBorrowerEmail = new System.Windows.Forms.Label();
            this.txtEditBorrowerName = new System.Windows.Forms.TextBox();
            this.lblEditBorrowerName = new System.Windows.Forms.Label();
            this.pnlAddBorrower = new System.Windows.Forms.Panel();
            this.btnAddInternalBorrower = new System.Windows.Forms.Button();
            this.txtAddBorrowerPhone = new System.Windows.Forms.TextBox();
            this.lblAddBorrowerPhone = new System.Windows.Forms.Label();
            this.txtAddBorrowerEmail = new System.Windows.Forms.TextBox();
            this.lblAddBorrowerEmail = new System.Windows.Forms.Label();
            this.txtAddBorrowerName = new System.Windows.Forms.TextBox();
            this.lblAddBorrowerName = new System.Windows.Forms.Label();
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.panelBorrowersActions = new System.Windows.Forms.Panel();
            this.btnDeleteBorrower = new System.Windows.Forms.Button();
            this.btnEditBorrower = new System.Windows.Forms.Button();
            this.btnAddBorrower = new System.Windows.Forms.Button();
            this.issuedBooksTabPage = new System.Windows.Forms.TabPage();
            this.pnlIssueOnTab = new System.Windows.Forms.Panel();
            this.btnIssueOnTab = new System.Windows.Forms.Button();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDueDateOnTab = new System.Windows.Forms.Label();
            this.cmbIssueBorrower = new System.Windows.Forms.ComboBox();
            this.lblSelectBorrower = new System.Windows.Forms.Label();
            this.cmbIssueBook = new System.Windows.Forms.ComboBox();
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.panelIssuedBooksActions = new System.Windows.Forms.Panel();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.Books.SuspendLayout();
            this.booksTabPage.SuspendLayout();
            this.pnlEditBook.SuspendLayout();
            this.pnlAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelBooksActions.SuspendLayout();
            this.borrowersTabPage.SuspendLayout();
            this.pnlEditBorrower.SuspendLayout();
            this.pnlAddBorrower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            this.panelBorrowersActions.SuspendLayout();
            this.issuedBooksTabPage.SuspendLayout();
            this.pnlIssueOnTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            this.panelIssuedBooksActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Books
            // 
            this.Books.Controls.Add(this.booksTabPage);
            this.Books.Controls.Add(this.borrowersTabPage);
            this.Books.Controls.Add(this.issuedBooksTabPage);
            this.Books.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Books.Location = new System.Drawing.Point(0, 0);
            this.Books.Name = "Books";
            this.Books.SelectedIndex = 0;
            this.Books.Size = new System.Drawing.Size(800, 450);
            this.Books.TabIndex = 0;
            // 
            // booksTabPage
            // 
            this.booksTabPage.Controls.Add(this.pnlEditBook);
            this.booksTabPage.Controls.Add(this.pnlAddBook);
            this.booksTabPage.Controls.Add(this.dgvBooks);
            this.booksTabPage.Controls.Add(this.panelBooksActions);
            this.booksTabPage.Location = new System.Drawing.Point(4, 29);
            this.booksTabPage.Name = "booksTabPage";
            this.booksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.booksTabPage.Size = new System.Drawing.Size(792, 417);
            this.booksTabPage.TabIndex = 0;
            this.booksTabPage.Text = "Books";
            this.booksTabPage.UseVisualStyleBackColor = true;
            // 
            // pnlEditBook
            // 
            this.pnlEditBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditBook.Controls.Add(this.btnSaveEditedBook);
            this.pnlEditBook.Controls.Add(this.txtEditBookCopies);
            this.pnlEditBook.Controls.Add(this.lblEditBookCopies);
            this.pnlEditBook.Controls.Add(this.txtEditBookYear);
            this.pnlEditBook.Controls.Add(this.lblEditBookYear);
            this.pnlEditBook.Controls.Add(this.txtEditBookAuthor);
            this.pnlEditBook.Controls.Add(this.lblEditBookAuthor);
            this.pnlEditBook.Controls.Add(this.txtEditBookTitle);
            this.pnlEditBook.Controls.Add(this.lblEditBookTitle);
            this.pnlEditBook.Location = new System.Drawing.Point(480, 150);
            this.pnlEditBook.Name = "pnlEditBook";
            this.pnlEditBook.Size = new System.Drawing.Size(300, 250);
            this.pnlEditBook.TabIndex = 3;
            this.pnlEditBook.Visible = false;
            // 
            // btnSaveEditedBook
            // 
            this.btnSaveEditedBook.BackColor = System.Drawing.Color.Gray;
            this.btnSaveEditedBook.Location = new System.Drawing.Point(100, 200);
            this.btnSaveEditedBook.Name = "btnSaveEditedBook";
            this.btnSaveEditedBook.Size = new System.Drawing.Size(120, 35);
            this.btnSaveEditedBook.TabIndex = 8;
            this.btnSaveEditedBook.Text = "Save Changes";
            this.btnSaveEditedBook.UseVisualStyleBackColor = false;
            // 
            // txtEditBookCopies
            // 
            this.txtEditBookCopies.Location = new System.Drawing.Point(100, 160);
            this.txtEditBookCopies.Name = "txtEditBookCopies";
            this.txtEditBookCopies.Size = new System.Drawing.Size(170, 26);
            this.txtEditBookCopies.TabIndex = 7;
            // 
            // lblEditBookCopies
            // 
            this.lblEditBookCopies.AutoSize = true;
            this.lblEditBookCopies.Location = new System.Drawing.Point(20, 160);
            this.lblEditBookCopies.Name = "lblEditBookCopies";
            this.lblEditBookCopies.Size = new System.Drawing.Size(62, 20);
            this.lblEditBookCopies.TabIndex = 6;
            this.lblEditBookCopies.Text = "Copies:";
            // 
            // txtEditBookYear
            // 
            this.txtEditBookYear.Location = new System.Drawing.Point(100, 120);
            this.txtEditBookYear.Name = "txtEditBookYear";
            this.txtEditBookYear.Size = new System.Drawing.Size(170, 26);
            this.txtEditBookYear.TabIndex = 5;
            // 
            // lblEditBookYear
            // 
            this.lblEditBookYear.AutoSize = true;
            this.lblEditBookYear.Location = new System.Drawing.Point(20, 120);
            this.lblEditBookYear.Name = "lblEditBookYear";
            this.lblEditBookYear.Size = new System.Drawing.Size(47, 20);
            this.lblEditBookYear.TabIndex = 4;
            this.lblEditBookYear.Text = "Year:";
            // 
            // txtEditBookAuthor
            // 
            this.txtEditBookAuthor.Location = new System.Drawing.Point(100, 80);
            this.txtEditBookAuthor.Name = "txtEditBookAuthor";
            this.txtEditBookAuthor.Size = new System.Drawing.Size(170, 26);
            this.txtEditBookAuthor.TabIndex = 3;
            // 
            // lblEditBookAuthor
            // 
            this.lblEditBookAuthor.AutoSize = true;
            this.lblEditBookAuthor.Location = new System.Drawing.Point(20, 80);
            this.lblEditBookAuthor.Name = "lblEditBookAuthor";
            this.lblEditBookAuthor.Size = new System.Drawing.Size(61, 20);
            this.lblEditBookAuthor.TabIndex = 2;
            this.lblEditBookAuthor.Text = "Author:";
            // 
            // txtEditBookTitle
            // 
            this.txtEditBookTitle.Location = new System.Drawing.Point(100, 40);
            this.txtEditBookTitle.Name = "txtEditBookTitle";
            this.txtEditBookTitle.Size = new System.Drawing.Size(170, 26);
            this.txtEditBookTitle.TabIndex = 1;
            // 
            // lblEditBookTitle
            // 
            this.lblEditBookTitle.AutoSize = true;
            this.lblEditBookTitle.Location = new System.Drawing.Point(20, 40);
            this.lblEditBookTitle.Name = "lblEditBookTitle";
            this.lblEditBookTitle.Size = new System.Drawing.Size(42, 20);
            this.lblEditBookTitle.TabIndex = 0;
            this.lblEditBookTitle.Text = "Title:";
            // 
            // pnlAddBook
            // 
            this.pnlAddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddBook.Controls.Add(this.btnAddInternalBook);
            this.pnlAddBook.Controls.Add(this.txtAddBookCopies);
            this.pnlAddBook.Controls.Add(this.lblAddBookCopies);
            this.pnlAddBook.Controls.Add(this.txtAddBookYear);
            this.pnlAddBook.Controls.Add(this.lblAddBookYear);
            this.pnlAddBook.Controls.Add(this.txtAddBookAuthor);
            this.pnlAddBook.Controls.Add(this.lblAddBookAuthor);
            this.pnlAddBook.Controls.Add(this.txtAddBookTitle);
            this.pnlAddBook.Controls.Add(this.lblAddBookTitle);
            this.pnlAddBook.Location = new System.Drawing.Point(480, 150);
            this.pnlAddBook.Name = "pnlAddBook";
            this.pnlAddBook.Size = new System.Drawing.Size(300, 250);
            this.pnlAddBook.TabIndex = 2;
            this.pnlAddBook.Visible = false;
            // 
            // btnAddInternalBook
            // 
            this.btnAddInternalBook.Location = new System.Drawing.Point(100, 200);
            this.btnAddInternalBook.Name = "btnAddInternalBook";
            this.btnAddInternalBook.Size = new System.Drawing.Size(120, 35);
            this.btnAddInternalBook.TabIndex = 8;
            this.btnAddInternalBook.Text = "Add Book";
            this.btnAddInternalBook.UseVisualStyleBackColor = true;
            // 
            // txtAddBookCopies
            // 
            this.txtAddBookCopies.Location = new System.Drawing.Point(100, 160);
            this.txtAddBookCopies.Name = "txtAddBookCopies";
            this.txtAddBookCopies.Size = new System.Drawing.Size(170, 26);
            this.txtAddBookCopies.TabIndex = 7;
            // 
            // lblAddBookCopies
            // 
            this.lblAddBookCopies.AutoSize = true;
            this.lblAddBookCopies.Location = new System.Drawing.Point(20, 160);
            this.lblAddBookCopies.Name = "lblAddBookCopies";
            this.lblAddBookCopies.Size = new System.Drawing.Size(62, 20);
            this.lblAddBookCopies.TabIndex = 6;
            this.lblAddBookCopies.Text = "Copies:";
            // 
            // txtAddBookYear
            // 
            this.txtAddBookYear.Location = new System.Drawing.Point(100, 120);
            this.txtAddBookYear.Name = "txtAddBookYear";
            this.txtAddBookYear.Size = new System.Drawing.Size(170, 26);
            this.txtAddBookYear.TabIndex = 5;
            // 
            // lblAddBookYear
            // 
            this.lblAddBookYear.AutoSize = true;
            this.lblAddBookYear.Location = new System.Drawing.Point(20, 120);
            this.lblAddBookYear.Name = "lblAddBookYear";
            this.lblAddBookYear.Size = new System.Drawing.Size(47, 20);
            this.lblAddBookYear.TabIndex = 4;
            this.lblAddBookYear.Text = "Year:";
            // 
            // txtAddBookAuthor
            // 
            this.txtAddBookAuthor.Location = new System.Drawing.Point(100, 80);
            this.txtAddBookAuthor.Name = "txtAddBookAuthor";
            this.txtAddBookAuthor.Size = new System.Drawing.Size(170, 26);
            this.txtAddBookAuthor.TabIndex = 3;
            // 
            // lblAddBookAuthor
            // 
            this.lblAddBookAuthor.AutoSize = true;
            this.lblAddBookAuthor.Location = new System.Drawing.Point(20, 80);
            this.lblAddBookAuthor.Name = "lblAddBookAuthor";
            this.lblAddBookAuthor.Size = new System.Drawing.Size(61, 20);
            this.lblAddBookAuthor.TabIndex = 2;
            this.lblAddBookAuthor.Text = "Author:";
            // 
            // txtAddBookTitle
            // 
            this.txtAddBookTitle.Location = new System.Drawing.Point(100, 40);
            this.txtAddBookTitle.Name = "txtAddBookTitle";
            this.txtAddBookTitle.Size = new System.Drawing.Size(170, 26);
            this.txtAddBookTitle.TabIndex = 1;
            // 
            // lblAddBookTitle
            // 
            this.lblAddBookTitle.AutoSize = true;
            this.lblAddBookTitle.Location = new System.Drawing.Point(20, 40);
            this.lblAddBookTitle.Name = "lblAddBookTitle";
            this.lblAddBookTitle.Size = new System.Drawing.Size(42, 20);
            this.lblAddBookTitle.TabIndex = 0;
            this.lblAddBookTitle.Text = "Title:";
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.dgvBooks.Location = new System.Drawing.Point(3, 90);
            this.dgvBooks.Name = "dgvBooks";
            //this.dgvBooks.RowHeadersWidth = 62;
            //this.dgvBooks.RowTemplate.Height = 28;
            //this.dgvBooks.Size = new System.Drawing.Size(786, 324);
           // this.dgvBooks.TabIndex = 1;
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // panelBooksActions
            // 
            this.panelBooksActions.Controls.Add(this.lblFilterYearRange);
            this.panelBooksActions.Controls.Add(this.txtFilterYearEnd);
            this.panelBooksActions.Controls.Add(this.lblFilterYearTo);
            this.panelBooksActions.Controls.Add(this.txtFilterYearStart);
            this.panelBooksActions.Controls.Add(this.btnApplyBookFilter);
            this.panelBooksActions.Controls.Add(this.txtFilterAuthor);
            this.panelBooksActions.Controls.Add(this.lblFilterAuthor);
            this.panelBooksActions.Controls.Add(this.btnDeleteBook);
            this.panelBooksActions.Controls.Add(this.btnEditBook);
            this.panelBooksActions.Controls.Add(this.btnAddBook);
            this.panelBooksActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBooksActions.Location = new System.Drawing.Point(3, 3);
            this.panelBooksActions.Name = "panelBooksActions";
            this.panelBooksActions.Size = new System.Drawing.Size(786, 87);
            this.panelBooksActions.TabIndex = 0;
            // 
            // lblFilterYearRange
            // 
            this.lblFilterYearRange.AutoSize = true;
            this.lblFilterYearRange.Location = new System.Drawing.Point(450, 14);
            this.lblFilterYearRange.Name = "lblFilterYearRange";
            this.lblFilterYearRange.Size = new System.Drawing.Size(99, 20);
            this.lblFilterYearRange.TabIndex = 10;
            this.lblFilterYearRange.Text = "Year Range:";
            // 
            // txtFilterYearEnd
            // 
            this.txtFilterYearEnd.Location = new System.Drawing.Point(672, 11);
            this.txtFilterYearEnd.Name = "txtFilterYearEnd";
            this.txtFilterYearEnd.Size = new System.Drawing.Size(80, 26);
            this.txtFilterYearEnd.TabIndex = 9;
            // 
            // lblFilterYearTo
            // 
            this.lblFilterYearTo.AutoSize = true;
            this.lblFilterYearTo.Location = new System.Drawing.Point(642, 14);
            this.lblFilterYearTo.Name = "lblFilterYearTo";
            this.lblFilterYearTo.Size = new System.Drawing.Size(27, 20);
            this.lblFilterYearTo.TabIndex = 8;
            this.lblFilterYearTo.Text = "To";
            // 
            // txtFilterYearStart
            // 
            this.txtFilterYearStart.Location = new System.Drawing.Point(557, 11);
            this.txtFilterYearStart.Name = "txtFilterYearStart";
            this.txtFilterYearStart.Size = new System.Drawing.Size(80, 26);
            this.txtFilterYearStart.TabIndex = 7;
            // 
            // btnApplyBookFilter
            // 
            this.btnApplyBookFilter.Location = new System.Drawing.Point(557, 44);
            this.btnApplyBookFilter.Name = "btnApplyBookFilter";
            this.btnApplyBookFilter.Size = new System.Drawing.Size(120, 35);
            this.btnApplyBookFilter.TabIndex = 6;
            this.btnApplyBookFilter.Text = "Apply Filter";
            this.btnApplyBookFilter.UseVisualStyleBackColor = true;
            this.btnApplyBookFilter.Click += new System.EventHandler(this.btnApplyBookFilter_Click);
            // 
            // txtFilterAuthor
            // 
            this.txtFilterAuthor.Location = new System.Drawing.Point(300, 47);
            this.txtFilterAuthor.Name = "txtFilterAuthor";
            this.txtFilterAuthor.Size = new System.Drawing.Size(150, 26);
            this.txtFilterAuthor.TabIndex = 5;
            // 
            // lblFilterAuthor
            // 
            this.lblFilterAuthor.AutoSize = true;
            this.lblFilterAuthor.Location = new System.Drawing.Point(230, 50);
            this.lblFilterAuthor.Name = "lblFilterAuthor";
            this.lblFilterAuthor.Size = new System.Drawing.Size(61, 20);
            this.lblFilterAuthor.TabIndex = 4;
            this.lblFilterAuthor.Text = "Author:";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteBook.Location = new System.Drawing.Point(225, 11);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.Gray;
            this.btnEditBook.Location = new System.Drawing.Point(119, 11);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(100, 35);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Text = "Edit";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Gray;
            this.btnAddBook.Location = new System.Drawing.Point(13, 11);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 35);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // borrowersTabPage
            // 
            this.borrowersTabPage.Controls.Add(this.pnlEditBorrower);
            this.borrowersTabPage.Controls.Add(this.pnlAddBorrower);
            this.borrowersTabPage.Controls.Add(this.dgvBorrowers);
            this.borrowersTabPage.Controls.Add(this.panelBorrowersActions);
            this.borrowersTabPage.Location = new System.Drawing.Point(4, 29);
            this.borrowersTabPage.Name = "borrowersTabPage";
            this.borrowersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.borrowersTabPage.Size = new System.Drawing.Size(792, 417);
            this.borrowersTabPage.TabIndex = 1;
            this.borrowersTabPage.Text = "Borrowers";
            this.borrowersTabPage.UseVisualStyleBackColor = true;
            // 
            // pnlEditBorrower
            // 
            this.pnlEditBorrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditBorrower.Controls.Add(this.btnSaveEditedBorrower);
            this.pnlEditBorrower.Controls.Add(this.txtEditBorrowerPhone);
            this.pnlEditBorrower.Controls.Add(this.lblEditBorrowerPhone);
            this.pnlEditBorrower.Controls.Add(this.txtEditBorrowerEmail);
            this.pnlEditBorrower.Controls.Add(this.lblEditBorrowerEmail);
            this.pnlEditBorrower.Controls.Add(this.txtEditBorrowerName);
            this.pnlEditBorrower.Controls.Add(this.lblEditBorrowerName);
            this.pnlEditBorrower.Location = new System.Drawing.Point(480, 150);
            this.pnlEditBorrower.Name = "pnlEditBorrower";
            this.pnlEditBorrower.Size = new System.Drawing.Size(300, 200);
            this.pnlEditBorrower.TabIndex = 3;
            this.pnlEditBorrower.Visible = false;
            // 
            // btnSaveEditedBorrower
            // 
            this.btnSaveEditedBorrower.BackColor = System.Drawing.Color.Gray;
            this.btnSaveEditedBorrower.Location = new System.Drawing.Point(100, 150);
            this.btnSaveEditedBorrower.Name = "btnSaveEditedBorrower";
            this.btnSaveEditedBorrower.Size = new System.Drawing.Size(120, 35);
            this.btnSaveEditedBorrower.TabIndex = 6;
            this.btnSaveEditedBorrower.Text = "Save Changes";
            this.btnSaveEditedBorrower.UseVisualStyleBackColor = false;
            // 
            // txtEditBorrowerPhone
            // 
            this.txtEditBorrowerPhone.Location = new System.Drawing.Point(100, 100);
            this.txtEditBorrowerPhone.Name = "txtEditBorrowerPhone";
            this.txtEditBorrowerPhone.Size = new System.Drawing.Size(170, 26);
            this.txtEditBorrowerPhone.TabIndex = 5;
            // 
            // lblEditBorrowerPhone
            // 
            this.lblEditBorrowerPhone.AutoSize = true;
            this.lblEditBorrowerPhone.Location = new System.Drawing.Point(20, 100);
            this.lblEditBorrowerPhone.Name = "lblEditBorrowerPhone";
            this.lblEditBorrowerPhone.Size = new System.Drawing.Size(59, 20);
            this.lblEditBorrowerPhone.TabIndex = 4;
            this.lblEditBorrowerPhone.Text = "Phone:";
            // 
            // txtEditBorrowerEmail
            // 
            this.txtEditBorrowerEmail.Location = new System.Drawing.Point(100, 60);
            this.txtEditBorrowerEmail.Name = "txtEditBorrowerEmail";
            this.txtEditBorrowerEmail.Size = new System.Drawing.Size(170, 26);
            this.txtEditBorrowerEmail.TabIndex = 3;
            // 
            // lblEditBorrowerEmail
            // 
            this.lblEditBorrowerEmail.AutoSize = true;
            this.lblEditBorrowerEmail.Location = new System.Drawing.Point(20, 60);
            this.lblEditBorrowerEmail.Name = "lblEditBorrowerEmail";
            this.lblEditBorrowerEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEditBorrowerEmail.TabIndex = 2;
            this.lblEditBorrowerEmail.Text = "Email:";
            // 
            // txtEditBorrowerName
            // 
            this.txtEditBorrowerName.Location = new System.Drawing.Point(100, 20);
            this.txtEditBorrowerName.Name = "txtEditBorrowerName";
            this.txtEditBorrowerName.Size = new System.Drawing.Size(170, 26);
            this.txtEditBorrowerName.TabIndex = 1;
            // 
            // lblEditBorrowerName
            // 
            this.lblEditBorrowerName.AutoSize = true;
            this.lblEditBorrowerName.Location = new System.Drawing.Point(20, 20);
            this.lblEditBorrowerName.Name = "lblEditBorrowerName";
            this.lblEditBorrowerName.Size = new System.Drawing.Size(55, 20);
            this.lblEditBorrowerName.TabIndex = 0;
            this.lblEditBorrowerName.Text = "Name:";
            // 
            // pnlAddBorrower
            // 
            this.pnlAddBorrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddBorrower.Controls.Add(this.btnAddInternalBorrower);
            this.pnlAddBorrower.Controls.Add(this.txtAddBorrowerPhone);
            this.pnlAddBorrower.Controls.Add(this.lblAddBorrowerPhone);
            this.pnlAddBorrower.Controls.Add(this.txtAddBorrowerEmail);
            this.pnlAddBorrower.Controls.Add(this.lblAddBorrowerEmail);
            this.pnlAddBorrower.Controls.Add(this.txtAddBorrowerName);
            this.pnlAddBorrower.Controls.Add(this.lblAddBorrowerName);
            this.pnlAddBorrower.Location = new System.Drawing.Point(480, 150);
            this.pnlAddBorrower.Name = "pnlAddBorrower";
            this.pnlAddBorrower.Size = new System.Drawing.Size(300, 200);
            this.pnlAddBorrower.TabIndex = 2;
            this.pnlAddBorrower.Visible = false;
            // 
            // btnAddInternalBorrower
            // 
            this.btnAddInternalBorrower.Location = new System.Drawing.Point(100, 150);
            this.btnAddInternalBorrower.Name = "btnAddInternalBorrower";
            this.btnAddInternalBorrower.Size = new System.Drawing.Size(120, 35);
            this.btnAddInternalBorrower.TabIndex = 6;
            this.btnAddInternalBorrower.Text = "Add Borrower";
            this.btnAddInternalBorrower.UseVisualStyleBackColor = true;
            // 
            // txtAddBorrowerPhone
            // 
            this.txtAddBorrowerPhone.Location = new System.Drawing.Point(100, 100);
            this.txtAddBorrowerPhone.Name = "txtAddBorrowerPhone";
            this.txtAddBorrowerPhone.Size = new System.Drawing.Size(170, 26);
            this.txtAddBorrowerPhone.TabIndex = 5;
            // 
            // lblAddBorrowerPhone
            // 
            this.lblAddBorrowerPhone.AutoSize = true;
            this.lblAddBorrowerPhone.Location = new System.Drawing.Point(20, 100);
            this.lblAddBorrowerPhone.Name = "lblAddBorrowerPhone";
            this.lblAddBorrowerPhone.Size = new System.Drawing.Size(59, 20);
            this.lblAddBorrowerPhone.TabIndex = 4;
            this.lblAddBorrowerPhone.Text = "Phone:";
            // 
            // txtAddBorrowerEmail
            // 
            this.txtAddBorrowerEmail.Location = new System.Drawing.Point(100, 60);
            this.txtAddBorrowerEmail.Name = "txtAddBorrowerEmail";
            this.txtAddBorrowerEmail.Size = new System.Drawing.Size(170, 26);
            this.txtAddBorrowerEmail.TabIndex = 3;
            // 
            // lblAddBorrowerEmail
            // 
            this.lblAddBorrowerEmail.AutoSize = true;
            this.lblAddBorrowerEmail.Location = new System.Drawing.Point(20, 60);
            this.lblAddBorrowerEmail.Name = "lblAddBorrowerEmail";
            this.lblAddBorrowerEmail.Size = new System.Drawing.Size(52, 20);
            this.lblAddBorrowerEmail.TabIndex = 2;
            this.lblAddBorrowerEmail.Text = "Email:";
            // 
            // txtAddBorrowerName
            // 
            this.txtAddBorrowerName.Location = new System.Drawing.Point(100, 20);
            this.txtAddBorrowerName.Name = "txtAddBorrowerName";
            this.txtAddBorrowerName.Size = new System.Drawing.Size(170, 26);
            this.txtAddBorrowerName.TabIndex = 1;
            // 
            // lblAddBorrowerName
            // 
            this.lblAddBorrowerName.AutoSize = true;
            this.lblAddBorrowerName.Location = new System.Drawing.Point(20, 20);
            this.lblAddBorrowerName.Name = "lblAddBorrowerName";
            this.lblAddBorrowerName.Size = new System.Drawing.Size(55, 20);
            this.lblAddBorrowerName.TabIndex = 0;
            this.lblAddBorrowerName.Text = "Name:";
            // 
            // dgvBorrowers
            // 
            this.dgvBorrowers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowers.Location = new System.Drawing.Point(3, 58);
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.RowHeadersWidth = 62;
            this.dgvBorrowers.RowTemplate.Height = 28;
            this.dgvBorrowers.Size = new System.Drawing.Size(786, 356);
            this.dgvBorrowers.TabIndex = 1;
            this.dgvBorrowers.SelectionChanged += new System.EventHandler(this.dgvBorrowers_SelectionChanged);
            // 
            // panelBorrowersActions
            // 
            this.panelBorrowersActions.Controls.Add(this.btnDeleteBorrower);
            this.panelBorrowersActions.Controls.Add(this.btnEditBorrower);
            this.panelBorrowersActions.Controls.Add(this.btnAddBorrower);
            this.panelBorrowersActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorrowersActions.Location = new System.Drawing.Point(3, 3);
            this.panelBorrowersActions.Name = "panelBorrowersActions";
            this.panelBorrowersActions.Size = new System.Drawing.Size(786, 55);
            this.panelBorrowersActions.TabIndex = 0;
            // 
            // btnDeleteBorrower
            // 
            this.btnDeleteBorrower.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteBorrower.Location = new System.Drawing.Point(225, 11);
            this.btnDeleteBorrower.Name = "btnDeleteBorrower";
            this.btnDeleteBorrower.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteBorrower.TabIndex = 2;
            this.btnDeleteBorrower.Text = "Delete";
            this.btnDeleteBorrower.UseVisualStyleBackColor = false;
            this.btnDeleteBorrower.Click += new System.EventHandler(this.btnDeleteBorrower_Click);
            // 
            // btnEditBorrower
            // 
            this.btnEditBorrower.BackColor = System.Drawing.Color.Gray;
            this.btnEditBorrower.Location = new System.Drawing.Point(119, 11);
            this.btnEditBorrower.Name = "btnEditBorrower";
            this.btnEditBorrower.Size = new System.Drawing.Size(100, 35);
            this.btnEditBorrower.TabIndex = 1;
            this.btnEditBorrower.Text = "Edit";
            this.btnEditBorrower.UseVisualStyleBackColor = false;
            this.btnEditBorrower.Click += new System.EventHandler(this.btnEditBorrower_Click);
            // 
            // btnAddBorrower
            // 
            this.btnAddBorrower.BackColor = System.Drawing.Color.Gray;
            this.btnAddBorrower.Location = new System.Drawing.Point(13, 11);
            this.btnAddBorrower.Name = "btnAddBorrower";
            this.btnAddBorrower.Size = new System.Drawing.Size(100, 35);
            this.btnAddBorrower.TabIndex = 0;
            this.btnAddBorrower.Text = "Add";
            this.btnAddBorrower.UseVisualStyleBackColor = false;
            this.btnAddBorrower.Click += new System.EventHandler(this.btnAddBorrower_Click);
            // 
            // issuedBooksTabPage
            // 
            this.issuedBooksTabPage.Controls.Add(this.pnlIssueOnTab);
            this.issuedBooksTabPage.Controls.Add(this.dgvIssuedBooks);
            this.issuedBooksTabPage.Controls.Add(this.panelIssuedBooksActions);
            this.issuedBooksTabPage.Location = new System.Drawing.Point(4, 29);
            this.issuedBooksTabPage.Name = "issuedBooksTabPage";
            this.issuedBooksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.issuedBooksTabPage.Size = new System.Drawing.Size(792, 417);
            this.issuedBooksTabPage.TabIndex = 2;
            this.issuedBooksTabPage.Text = "Issued Books";
            this.issuedBooksTabPage.UseVisualStyleBackColor = true;
            // 
            // pnlIssueOnTab
            // 
            this.pnlIssueOnTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIssueOnTab.Controls.Add(this.btnIssueOnTab);
            this.pnlIssueOnTab.Controls.Add(this.dtpIssue);
            this.pnlIssueOnTab.Controls.Add(this.lblIssueDueDateOnTab);
            this.pnlIssueOnTab.Controls.Add(this.cmbIssueBorrower);
            this.pnlIssueOnTab.Controls.Add(this.lblSelectBorrower);
            this.pnlIssueOnTab.Controls.Add(this.cmbIssueBook);
            this.pnlIssueOnTab.Controls.Add(this.lblSelectBook);
            this.pnlIssueOnTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlIssueOnTab.Location = new System.Drawing.Point(455, 58);
            this.pnlIssueOnTab.Name = "pnlIssueOnTab";
            this.pnlIssueOnTab.Size = new System.Drawing.Size(334, 356);
            this.pnlIssueOnTab.TabIndex = 2;
            // 
            // btnIssueOnTab
            // 
            this.btnIssueOnTab.BackColor = System.Drawing.Color.Gray;
            this.btnIssueOnTab.Location = new System.Drawing.Point(110, 180);
            this.btnIssueOnTab.Name = "btnIssueOnTab";
            this.btnIssueOnTab.Size = new System.Drawing.Size(120, 35);
            this.btnIssueOnTab.TabIndex = 6;
            this.btnIssueOnTab.Text = "Issue Book";
            this.btnIssueOnTab.UseVisualStyleBackColor = false;
            // 
            // dtpIssue
            // 
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssue.Location = new System.Drawing.Point(150, 130);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(150, 26);
            this.dtpIssue.TabIndex = 5;
            // 
            // lblIssueDueDateOnTab
            // 
            this.lblIssueDueDateOnTab.AutoSize = true;
            this.lblIssueDueDateOnTab.Location = new System.Drawing.Point(20, 130);
            this.lblIssueDueDateOnTab.Name = "lblIssueDueDateOnTab";
            this.lblIssueDueDateOnTab.Size = new System.Drawing.Size(82, 20);
            this.lblIssueDueDateOnTab.TabIndex = 4;
            this.lblIssueDueDateOnTab.Text = "Due Date:";
            // 
            // cmbIssueBorrower
            // 
            this.cmbIssueBorrower.BackColor = System.Drawing.Color.Silver;
            this.cmbIssueBorrower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueBorrower.FormattingEnabled = true;
            this.cmbIssueBorrower.Location = new System.Drawing.Point(150, 80);
            this.cmbIssueBorrower.Name = "cmbIssueBorrower";
            this.cmbIssueBorrower.Size = new System.Drawing.Size(150, 28);
            this.cmbIssueBorrower.TabIndex = 3;
            // 
            // lblSelectBorrower
            // 
            this.lblSelectBorrower.AutoSize = true;
            this.lblSelectBorrower.Location = new System.Drawing.Point(20, 80);
            this.lblSelectBorrower.Name = "lblSelectBorrower";
            this.lblSelectBorrower.Size = new System.Drawing.Size(126, 20);
            this.lblSelectBorrower.TabIndex = 2;
            this.lblSelectBorrower.Text = "Select Borrower:";
            // 
            // cmbIssueBook
            // 
            this.cmbIssueBook.BackColor = System.Drawing.Color.Silver;
            this.cmbIssueBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueBook.FormattingEnabled = true;
            this.cmbIssueBook.Location = new System.Drawing.Point(150, 30);
            this.cmbIssueBook.Name = "cmbIssueBook";
            this.cmbIssueBook.Size = new System.Drawing.Size(150, 28);
            this.cmbIssueBook.TabIndex = 1;
            // 
            // lblSelectBook
            // 
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.Location = new System.Drawing.Point(20, 30);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(99, 20);
            this.lblSelectBook.TabIndex = 0;
            this.lblSelectBook.Text = "Select Book:";
            // 
            // dgvIssuedBooks
            // 
            this.dgvIssuedBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssuedBooks.Location = new System.Drawing.Point(3, 58);
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.RowHeadersWidth = 62;
            this.dgvIssuedBooks.RowTemplate.Height = 28;
            this.dgvIssuedBooks.Size = new System.Drawing.Size(786, 356);
            this.dgvIssuedBooks.TabIndex = 1;
            this.dgvIssuedBooks.SelectionChanged += new System.EventHandler(this.dgvIssuedBooks_SelectionChanged);
            // 
            // panelIssuedBooksActions
            // 
            this.panelIssuedBooksActions.Controls.Add(this.btnReturnBook);
            this.panelIssuedBooksActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIssuedBooksActions.Location = new System.Drawing.Point(3, 3);
            this.panelIssuedBooksActions.Name = "panelIssuedBooksActions";
            this.panelIssuedBooksActions.Size = new System.Drawing.Size(786, 55);
            this.panelIssuedBooksActions.TabIndex = 0;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.Brown;
            this.btnReturnBook.Location = new System.Drawing.Point(0, 0);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(87, 33);
            this.btnReturnBook.TabIndex = 0;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Books);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Books.ResumeLayout(false);
            this.booksTabPage.ResumeLayout(false);
            this.pnlEditBook.ResumeLayout(false);
            this.pnlEditBook.PerformLayout();
            this.pnlAddBook.ResumeLayout(false);
            this.pnlAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelBooksActions.ResumeLayout(false);
            this.panelBooksActions.PerformLayout();
            this.borrowersTabPage.ResumeLayout(false);
            this.pnlEditBorrower.ResumeLayout(false);
            this.pnlEditBorrower.PerformLayout();
            this.pnlAddBorrower.ResumeLayout(false);
            this.pnlAddBorrower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            this.panelBorrowersActions.ResumeLayout(false);
            this.issuedBooksTabPage.ResumeLayout(false);
            this.pnlIssueOnTab.ResumeLayout(false);
            this.pnlIssueOnTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            this.panelIssuedBooksActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Books;
        private System.Windows.Forms.TabPage booksTabPage;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panelBooksActions;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TabPage borrowersTabPage;
        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Panel panelBorrowersActions;
        private System.Windows.Forms.Button btnDeleteBorrower;
        private System.Windows.Forms.Button btnEditBorrower;
        private System.Windows.Forms.Button btnAddBorrower;
        private System.Windows.Forms.TabPage issuedBooksTabPage;
        private System.Windows.Forms.DataGridView dgvIssuedBooks;
        private System.Windows.Forms.Panel panelIssuedBooksActions;
        private System.Windows.Forms.Button btnReturnBook;

        // Controls for embedded Add/Edit functionality (panels that pop up)
        private System.Windows.Forms.Panel pnlAddBook;
        private System.Windows.Forms.Label lblAddBookTitle;
        private System.Windows.Forms.TextBox txtAddBookTitle;
        private System.Windows.Forms.Label lblAddBookAuthor;
        private System.Windows.Forms.TextBox txtAddBookAuthor;
        private System.Windows.Forms.Label lblAddBookYear;
        private System.Windows.Forms.TextBox txtAddBookYear;
        private System.Windows.Forms.Label lblAddBookCopies;
        private System.Windows.Forms.TextBox txtAddBookCopies;
        private System.Windows.Forms.Button btnAddInternalBook;

        private System.Windows.Forms.Panel pnlEditBook;
        private System.Windows.Forms.Button btnSaveEditedBook;
        private System.Windows.Forms.TextBox txtEditBookCopies;
        private System.Windows.Forms.Label lblEditBookCopies;
        private System.Windows.Forms.TextBox txtEditBookYear;
        private System.Windows.Forms.Label lblEditBookYear;
        private System.Windows.Forms.TextBox txtEditBookAuthor;
        private System.Windows.Forms.Label lblEditBookAuthor;
        private System.Windows.Forms.TextBox txtEditBookTitle;
        private System.Windows.Forms.Label lblEditBookTitle;

        private System.Windows.Forms.Panel pnlAddBorrower;
        private System.Windows.Forms.Button btnAddInternalBorrower;
        private System.Windows.Forms.TextBox txtAddBorrowerPhone;
        private System.Windows.Forms.Label lblAddBorrowerPhone;
        private System.Windows.Forms.TextBox txtAddBorrowerEmail;
        private System.Windows.Forms.Label lblAddBorrowerEmail;
        private System.Windows.Forms.TextBox txtAddBorrowerName;
        private System.Windows.Forms.Label lblAddBorrowerName;

        private System.Windows.Forms.Panel pnlEditBorrower;
        private System.Windows.Forms.Button btnSaveEditedBorrower;
        private System.Windows.Forms.TextBox txtEditBorrowerPhone;
        private System.Windows.Forms.Label lblEditBorrowerPhone;
        private System.Windows.Forms.TextBox txtEditBorrowerEmail;
        private System.Windows.Forms.Label lblEditBorrowerEmail;
        private System.Windows.Forms.TextBox txtEditBorrowerName;
        private System.Windows.Forms.Label lblEditBorrowerName;

        // Controls for Filtering Books
        private System.Windows.Forms.TextBox txtFilterAuthor;
        private System.Windows.Forms.Label lblFilterAuthor;
        private System.Windows.Forms.TextBox txtFilterYearEnd;
        private System.Windows.Forms.Label lblFilterYearTo;
        private System.Windows.Forms.TextBox txtFilterYearStart;
        private System.Windows.Forms.Label lblFilterYearRange;
        private System.Windows.Forms.Button btnApplyBookFilter;

        // Controls for Issue Book directly on Issued Books Tab
        private System.Windows.Forms.Panel pnlIssueOnTab; // Panel to hold issue controls
        private System.Windows.Forms.Button btnIssueOnTab;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.Label lblIssueDueDateOnTab;
        private System.Windows.Forms.ComboBox cmbIssueBook;
        private System.Windows.Forms.Label lblSelectBook;
        private System.Windows.Forms.ComboBox cmbIssueBorrower;
        private System.Windows.Forms.Label lblSelectBorrower;
    }
}
