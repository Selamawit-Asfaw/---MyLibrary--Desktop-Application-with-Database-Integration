using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        private const string ConnectionString = @"Server=(localdb)\ProjectModels;Database=Mylibrary;Integrated Security=True;";
        private BindingSource booksBindingSource = new BindingSource();
        private BindingSource borrowersBindingSource = new BindingSource();
        private BindingSource issuedBooksBindingSource = new BindingSource();

        private int currentBookId = -1;
        private int currentBorrowerId = -1;

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            InitializeBorrowersGridView();
            LoadBooks();
            LoadBorrowers();
            LoadIssuedBooks();

            this.btnAddInternalBook.Click += BtnAddInternalBook_Click;
            this.btnSaveEditedBook.Click += BtnSaveEditedBook_Click;
            this.btnAddInternalBorrower.Click += BtnAddInternalBorrower_Click;
            this.btnSaveEditedBorrower.Click += BtnSaveEditedBorrower_Click;
            this.btnApplyBookFilter.Click += btnApplyBookFilter_Click;
            this.btnIssueOnTab.Click += BtnIssueOnTab_Click;
            this.btnReturnBook.Click += btnReturnBook_Click;

            HideAllInputPanels();
        }

        private void InitializeBorrowersGridView()
        {
            dgvBorrowers.AutoGenerateColumns = false;
            dgvBorrowers.Columns.Clear();

            dgvBorrowers.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "BorrowerID",
                HeaderText = "ID",
                Name = "colBorrowerID",
                Width = 50
            });

            dgvBorrowers.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                Name = "colName",
                Width = 150
            });

            dgvBorrowers.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Name = "colEmail",
                Width = 200
            });

            dgvBorrowers.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Phone",
                HeaderText = "Phone",
                Name = "colPhone",
                Width = 120
            });
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void HideAllInputPanels()
        {
            pnlAddBook.Visible = false;
            pnlEditBook.Visible = false;
            pnlAddBorrower.Visible = false;
            pnlEditBorrower.Visible = false;
        }

        private void LoadBooks(string authorFilter = null, int? startYear = null, int? endYear = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    StringBuilder queryBuilder = new StringBuilder("SELECT BookID, Title, Author, Year, AvailableCopies FROM Books");
                    List<SqlParameter> parameters = new List<SqlParameter>();
                    bool whereAdded = false;

                    if (!string.IsNullOrEmpty(authorFilter))
                    {
                        queryBuilder.Append(" WHERE Author LIKE @AuthorFilter");
                        parameters.Add(new SqlParameter("@AuthorFilter", "%" + authorFilter + "%"));
                        whereAdded = true;
                    }

                    if (startYear.HasValue && endYear.HasValue)
                    {
                        queryBuilder.Append(whereAdded ? " AND" : " WHERE");
                        queryBuilder.Append(" Year BETWEEN @StartYear AND @EndYear");
                        parameters.Add(new SqlParameter("@StartYear", startYear.Value));
                        parameters.Add(new SqlParameter("@EndYear", endYear.Value));
                        whereAdded = true;
                    }
                    else if (startYear.HasValue)
                    {
                        queryBuilder.Append(whereAdded ? " AND" : " WHERE");
                        queryBuilder.Append(" Year >= @StartYear");
                        parameters.Add(new SqlParameter("@StartYear", startYear.Value));
                        whereAdded = true;
                    }
                    else if (endYear.HasValue)
                    {
                        queryBuilder.Append(whereAdded ? " AND" : " WHERE");
                        queryBuilder.Append(" Year <= @EndYear");
                        parameters.Add(new SqlParameter("@EndYear", endYear.Value));
                        whereAdded = true;
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(queryBuilder.ToString(), connection);
                    adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());

                    DataTable booksTable = new DataTable();
                    adapter.Fill(booksTable);
                    booksBindingSource.DataSource = booksTable;
                    dgvBooks.DataSource = booksBindingSource;
                    LoadBooksIntoComboBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooksIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT BookID, Title FROM Books WHERE AvailableCopies > 0 ORDER BY Title";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable booksTable = new DataTable();
                    adapter.Fill(booksTable);

                    if (cmbIssueBook != null)
                    {
                        cmbIssueBook.DisplayMember = "Title";
                        cmbIssueBook.ValueMember = "BookID";
                        cmbIssueBook.DataSource = booksTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books for issue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApplyBookFilter_Click(object sender, EventArgs e)
        {
            string author = txtFilterAuthor.Text.Trim();
            int? startYear = null;
            int? endYear = null;

            if (!string.IsNullOrEmpty(txtFilterYearStart.Text.Trim()) && int.TryParse(txtFilterYearStart.Text.Trim(), out int sYear))
            {
                startYear = sYear;
            }
            if (!string.IsNullOrEmpty(txtFilterYearEnd.Text.Trim()) && int.TryParse(txtFilterYearEnd.Text.Trim(), out int eYear))
            {
                endYear = eYear;
            }

            if (startYear.HasValue && endYear.HasValue && startYear.Value > endYear.Value)
            {
                MessageBox.Show("Start year cannot be greater than end year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadBooks(author, startYear, endYear);
        }

        private void LoadBorrowers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT BorrowerID, Name, Email, Phone FROM Borrowers ORDER BY Name";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable borrowersTable = new DataTable();
                    adapter.Fill(borrowersTable);
                    borrowersBindingSource.DataSource = borrowersTable;
                    dgvBorrowers.DataSource = borrowersBindingSource;
                    LoadBorrowersIntoComboBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBorrowersIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT BorrowerID, Name FROM Borrowers ORDER BY Name";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable borrowersTable = new DataTable();
                    adapter.Fill(borrowersTable);

                    if (cmbIssueBorrower != null)
                    {
                        cmbIssueBorrower.DisplayMember = "Name";
                        cmbIssueBorrower.ValueMember = "BorrowerID";
                        cmbIssueBorrower.DataSource = borrowersTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowers for issue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadIssuedBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT ib.IssueID, b.Title AS BookTitle, br.Name AS BorrowerName,
                                  ib.IssueDate, ib.DueDate
                                  FROM IssuedBooks ib
                                  INNER JOIN Books b ON ib.BookID = b.BookID
                                  INNER JOIN Borrowers br ON ib.BorrowerID = br.BorrowerID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable issuedBooksTable = new DataTable();
                    adapter.Fill(issuedBooksTable);
                    issuedBooksBindingSource.DataSource = issuedBooksTable;
                    dgvIssuedBooks.DataSource = issuedBooksBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading issued books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            HideAllInputPanels();
            pnlAddBook.Visible = true;
            txtAddBookTitle.Clear();
            txtAddBookAuthor.Clear();
            txtAddBookYear.Clear();
            txtAddBookCopies.Clear();
        }

        private void BtnAddInternalBook_Click(object sender, EventArgs e)
        {
            string title = txtAddBookTitle.Text.Trim();
            string author = txtAddBookAuthor.Text.Trim();

            if (!int.TryParse(txtAddBookYear.Text.Trim(), out int year) || year < 1000 || year > DateTime.Now.Year + 5)
            {
                MessageBox.Show("Please enter a valid year (e.g., 1000-present).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtAddBookCopies.Text.Trim(), out int copies) || copies < 0)
            {
                MessageBox.Show("Please enter a valid number of copies (non-negative integer).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please enter title and author.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Books (Title, Author, Year, AvailableCopies) VALUES (@Title, @Author, @Year, @AvailableCopies)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@AvailableCopies", copies);
                        command.ExecuteNonQuery();
                        LoadBooks();
                        HideAllInputPanels();
                        MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                HideAllInputPanels();
                pnlEditBook.Visible = true;

                DataRowView selectedRow = (DataRowView)dgvBooks.SelectedRows[0].DataBoundItem;
                currentBookId = Convert.ToInt32(selectedRow["BookID"]);
                txtEditBookTitle.Text = selectedRow["Title"].ToString();
                txtEditBookAuthor.Text = selectedRow["Author"].ToString();
                txtEditBookYear.Text = selectedRow["Year"].ToString();
                txtEditBookCopies.Text = selectedRow["AvailableCopies"].ToString();
            }
            else
            {
                MessageBox.Show("Please select a book to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSaveEditedBook_Click(object sender, EventArgs e)
        {
            if (currentBookId == -1)
            {
                MessageBox.Show("No book selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string title = txtEditBookTitle.Text.Trim();
            string author = txtEditBookAuthor.Text.Trim();

            if (!int.TryParse(txtEditBookYear.Text.Trim(), out int year) || year < 1000 || year > DateTime.Now.Year + 5)
            {
                MessageBox.Show("Please enter a valid year (e.g., 1000-present).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtEditBookCopies.Text.Trim(), out int copies) || copies < 0)
            {
                MessageBox.Show("Please enter a valid number of copies (non-negative integer).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please enter title and author.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Books SET Title = @Title, Author = @Author, Year = @Year, AvailableCopies = @AvailableCopies WHERE BookID = @BookID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@AvailableCopies", copies);
                        command.Parameters.AddWithValue("@BookID", currentBookId);
                        command.ExecuteNonQuery();
                        LoadBooks();
                        HideAllInputPanels();
                        MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0 &&
                MessageBox.Show("Delete selected book? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        int bookId = Convert.ToInt32(((DataRowView)dgvBooks.SelectedRows[0].DataBoundItem)["BookID"]);
                        string query = "DELETE FROM Books WHERE BookID = @BookID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", bookId);
                            command.ExecuteNonQuery();
                            LoadBooks();
                            MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}\nEnsure no issued books are linked to this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            HideAllInputPanels();
            pnlAddBorrower.Visible = true;
            txtAddBorrowerName.Clear();
            txtAddBorrowerEmail.Clear();
            txtAddBorrowerPhone.Clear();
        }

        private void BtnAddInternalBorrower_Click(object sender, EventArgs e)
        {
            string name = txtAddBorrowerName.Text.Trim();
            string email = txtAddBorrowerEmail.Text.Trim();
            string phone = txtAddBorrowerPhone.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter borrower name and email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Borrowers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone);
                        command.ExecuteNonQuery();
                        LoadBorrowers();
                        HideAllInputPanels();
                        MessageBox.Show("Borrower added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding borrower: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditBorrower_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count > 0)
            {
                HideAllInputPanels();
                pnlEditBorrower.Visible = true;

                DataRowView selectedRow = (DataRowView)dgvBorrowers.SelectedRows[0].DataBoundItem;
                currentBorrowerId = Convert.ToInt32(selectedRow["BorrowerID"]);
                txtEditBorrowerName.Text = selectedRow["Name"].ToString();
                txtEditBorrowerEmail.Text = selectedRow["Email"].ToString();
                txtEditBorrowerPhone.Text = selectedRow["Phone"].ToString();
            }
            else
            {
                MessageBox.Show("Please select a borrower to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSaveEditedBorrower_Click(object sender, EventArgs e)
        {
            if (currentBorrowerId == -1)
            {
                MessageBox.Show("No borrower selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtEditBorrowerName.Text.Trim();
            string email = txtEditBorrowerEmail.Text.Trim();
            string phone = txtEditBorrowerPhone.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter borrower name and email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Borrowers SET Name = @Name, Email = @Email, Phone = @Phone WHERE BorrowerID = @BorrowerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone);
                        command.Parameters.AddWithValue("@BorrowerID", currentBorrowerId);
                        command.ExecuteNonQuery();
                        LoadBorrowers();
                        HideAllInputPanels();
                        MessageBox.Show("Borrower updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating borrower: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBorrower_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count > 0 &&
                MessageBox.Show("Delete selected borrower? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        int borrowerId = Convert.ToInt32(((DataRowView)dgvBorrowers.SelectedRows[0].DataBoundItem)["BorrowerID"]);
                        string query = "DELETE FROM Borrowers WHERE BorrowerID = @BorrowerID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BorrowerID", borrowerId);
                            command.ExecuteNonQuery();
                            LoadBorrowers();
                            MessageBox.Show("Borrower deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting borrower: {ex.Message}\nEnsure no issued books are linked to this borrower.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnIssueOnTab_Click(object sender, EventArgs e)
        {
            if (cmbIssueBook.SelectedValue == null)
            {
                MessageBox.Show("Please select a book to issue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbIssueBorrower.SelectedValue == null)
            {
                MessageBox.Show("Please select a borrower.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(cmbIssueBook.SelectedValue);
            int borrowerId = Convert.ToInt32(cmbIssueBorrower.SelectedValue);
            DateTime issueDate = DateTime.Now;
            DateTime dueDate = dtpIssue.Value.Date;

            if (dueDate <= issueDate.Date)
            {
                MessageBox.Show("Due date must be after the issue date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PerformBookIssue(bookId, borrowerId, issueDate, dueDate);
        }

        private void PerformBookIssue(int bookId, int borrowerId, DateTime issueDate, DateTime dueDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string checkCopiesQuery = "SELECT AvailableCopies FROM Books WHERE BookID = @BookID";
                    int availableCopies;
                    using (SqlCommand cmd = new SqlCommand(checkCopiesQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        availableCopies = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (availableCopies <= 0)
                    {
                        MessageBox.Show("No available copies of this book.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string decrementCopiesQuery = "UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @BookID";
                    using (SqlCommand cmd = new SqlCommand(decrementCopiesQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.ExecuteNonQuery();
                    }

                    string issueBookQuery = "INSERT INTO IssuedBooks (BookID, BorrowerID, IssueDate, DueDate) VALUES (@BookID, @BorrowerID, @IssueDate, @DueDate)";
                    using (SqlCommand command = new SqlCommand(issueBookQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        command.Parameters.AddWithValue("@BorrowerID", borrowerId);
                        command.Parameters.AddWithValue("@IssueDate", issueDate);
                        command.Parameters.AddWithValue("@DueDate", dueDate);
                        command.ExecuteNonQuery();
                        LoadBooks();
                        LoadIssuedBooks();
                        MessageBox.Show("Book issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error issuing book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgvIssuedBooks.SelectedRows.Count > 0 &&
                MessageBox.Show("Confirm return of selected book?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        int issueId = Convert.ToInt32(((DataRowView)dgvIssuedBooks.SelectedRows[0].DataBoundItem)["IssueID"]);

                        string getBookIdQuery = "SELECT BookID FROM IssuedBooks WHERE IssueID = @IssueID";
                        int bookId;

                        using (SqlCommand getBookIdCommand = new SqlCommand(getBookIdQuery, connection))
                        {
                            getBookIdCommand.Parameters.AddWithValue("@IssueID", issueId);
                            bookId = Convert.ToInt32(getBookIdCommand.ExecuteScalar());
                        }

                        string updateQuery = "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @BookID";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@BookID", bookId);
                            updateCommand.ExecuteNonQuery();
                        }

                        string deleteQuery = "DELETE FROM IssuedBooks WHERE IssueID = @IssueID";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@IssueID", issueId);
                            deleteCommand.ExecuteNonQuery();
                        }

                        LoadBooks();
                        LoadIssuedBooks();
                        MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error returning book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            bool rowSelected = dgvBooks.SelectedRows.Count > 0;
            btnEditBook.Enabled = rowSelected;
            btnDeleteBook.Enabled = rowSelected;

            if (pnlAddBook.Visible || pnlEditBook.Visible || pnlAddBorrower.Visible || pnlEditBorrower.Visible)
            {
                HideAllInputPanels();
            }
        }

        private void dgvBorrowers_SelectionChanged(object sender, EventArgs e)
        {
            bool rowSelected = dgvBorrowers.SelectedRows.Count > 0;
            btnEditBorrower.Enabled = rowSelected;
            btnDeleteBorrower.Enabled = rowSelected;

            if (pnlAddBorrower.Visible || pnlEditBorrower.Visible || pnlAddBook.Visible || pnlEditBook.Visible)
            {
                HideAllInputPanels();
            }
        }

        private void dgvIssuedBooks_SelectionChanged(object sender, EventArgs e)
        {
            btnReturnBook.Enabled = dgvIssuedBooks.SelectedRows.Count > 0;
        }

        private void btnReturnBook_Click_1(object sender, EventArgs e) { }
    }
}