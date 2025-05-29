using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibraryProject;

namespace LibraryProject
{
    public partial class LoginForm : Form
    {
        private const string ConnectionString = @"Server=(localdb)\ProjectModels;Database=Mylibrary;Integrated Security=True;";

        public LoginForm()
        {
            InitializeComponent();
            // Initialize password to be hidden (using standard password char)
            textBoxPassword.UseSystemPasswordChar = true;
        }

        // Your original unchanged login button code
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelErrorMessage.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            labelErrorMessage.Text = "Invalid username or password.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database or during login: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
        }

        // Fixed Show Password functionality
        private void showpasswordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordcheckbox.Checked)
            {
                // Show actual password characters
                textBoxPassword.PasswordChar = '\0'; // Null character shows actual text
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password with dots
                textBoxPassword.UseSystemPasswordChar = true;
            }

            // Force the textbox to refresh
            string temp = textBoxPassword.Text;
            textBoxPassword.Text = "";
            textBoxPassword.Text = temp;
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
            // Original label click handler
        }
    }
}