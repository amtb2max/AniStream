using MySql.Data.MySqlClient;
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

namespace AniStream
{
    public partial class LoginForm : Form
    {
        // Declare connectionString as a class-level field
        private string connectionString;

        public LoginForm()
        {
            InitializeComponent();

            try
            {
                // Load connection string from App.config
                connectionString = ConfigurationManager.ConnectionStrings["AnimeStreamingDB"].ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load connection string: {ex.Message}", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Exit form if connection string is missing
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //aniStream label
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Check if connection string is loaded
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Database connection is not configured.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            //validte if admin admin
            if( email == "admin" && password == "admin")
            {
                AdminForm adminform = new AdminForm();
                adminform.Show();
                this.Hide();
                return;
            }

            // Validate input
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query users table for Email match
                    string query = "SELECT UserID, PasswordHash FROM users WHERE Email = @Email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedPassword = reader["PasswordHash"].ToString();
                        // Simplified password check; in production, use proper hashing (e.g., BCrypt)
                        if (storedPassword == password)
                        {
                            int userId = reader.GetInt32("UserID");
                            reader.Close();

                            // Update last_login
                            query = "UPDATE users SET last_login = NOW() WHERE UserID = @UserID";
                            cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DashBoard dashboard = new DashBoard(userId);
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account not found, please register first.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Optional: Navigate to RegisterForm if it exists
                        // RegisterForm registerForm = new RegisterForm();
                        // registerForm.ShowDialog();
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // register
            try
            {
                RegisterForm registerForm = new RegisterForm();
                registerForm.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Register form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //forgot password
            try
            {
                ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
                forgotPasswordForm.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Forgot Password form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
