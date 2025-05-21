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
    public partial class ForgotPasswordForm : Form
    {
        private string connectionString;

        public ForgotPasswordForm()
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

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            //anistream txt label
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // email 
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // proceed button
            try
            {
                // Check if connection string is loaded
                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Database connection is not configured.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string email = textBoxEmail.Text.Trim();

                // Validate input
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please enter an email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Basic email format validation (optional)
                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        // Query users table for Email match
                        string query = "SELECT UserID FROM users WHERE Email = @Email";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Email", email);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);
                            MessageBox.Show("Email found! Proceed to reset password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            InputNewPasswordForm nextForm = new InputNewPasswordForm(userId);
                            nextForm.ShowDialog();
                            this.Close(); // Close ForgotPasswordForm
                        }
                        else
                        {
                            MessageBox.Show("Account not found.", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // go back
            try
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close(); // Close form to return to previous form (e.g., ForgotPasswordForm)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error closing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
