using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AniStream
{
    public partial class RegisterForm : Form
    {
        private string connectionString;

        public RegisterForm()
        {
            InitializeComponent();
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["AnimeStreamingDB"].ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load connection string: {ex.Message}", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // email txtbox
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            // username txtbox
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // passsword txtbox
        }

        private void textBoxConfirmPass_TextChanged(object sender, EventArgs e)
        {
            //confirm password
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //register button

            try
            {
                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Database connection is not configured.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string email = textBoxEmail.Text.Trim();
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();
                string confirmPassword = textBoxConfirmPass.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate email format
                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (email.Length > 100)
                {
                    MessageBox.Show("Email must be 100 characters or less.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate username
                if (username.Length > 50)
                {
                    MessageBox.Show("Username must be 50 characters or less.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate password match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Password validation
                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!password.Any(char.IsUpper) || !password.Any(char.IsDigit))
                {
                    MessageBox.Show("Password must include an uppercase letter and a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Check for existing email
                        string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE Email = @Email";
                        MySqlCommand checkEmailCmd = new MySqlCommand(checkEmailQuery, conn);
                        checkEmailCmd.Parameters.AddWithValue("@Email", email);
                        long emailCount = (long)checkEmailCmd.ExecuteScalar();
                        if (emailCount > 0)
                        {
                            MessageBox.Show("This email is already registered.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Check for existing username
                        string checkUsernameQuery = "SELECT COUNT(*) FROM users WHERE Username = @Username";
                        MySqlCommand checkUsernameCmd = new MySqlCommand(checkUsernameQuery, conn);
                        checkUsernameCmd.Parameters.AddWithValue("@Username", username);
                        long usernameCount = (long)checkUsernameCmd.ExecuteScalar();
                        if (usernameCount > 0)
                        {
                            MessageBox.Show("This username is already taken.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Insert new user
                        string insertQuery = "INSERT INTO users (Username, Email, PasswordHash) VALUES (@Username, @Email, @Password)";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@Password", password); // Plain text
                                                                                  

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1062) // Duplicate entry
                        {
                            if (ex.Message.Contains("Username"))
                                MessageBox.Show("This username is already taken.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else if (ex.Message.Contains("Email"))
                                MessageBox.Show("This email is already registered.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show("Duplicate entry error.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // go back button

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Clear textboxes
            textBoxEmail.Text = string.Empty;
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxConfirmPass.Text = string.Empty;
           
        }
    }
}
