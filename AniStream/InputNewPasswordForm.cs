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
    public partial class InputNewPasswordForm : Form
    {
        private readonly int userId;
        private string connectionString;

        public InputNewPasswordForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;

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

        private void labelEmail_Click(object sender, EventArgs e)
        {
            //label
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //go back button
            try
            {
                this.Close(); // Close form to return to previous form (e.g., ForgotPasswordForm)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error closing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelInstruction_Click(object sender, EventArgs e)
        {
            //label direction
        }

        private void textBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            // new password txtbox
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // re enter the password
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

                string newPassword = textBoxNewPass.Text.Trim();
                string confirmPassword = textBox1.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please enter and confirm the new password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if passwords match
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Basic password validation (e.g., minimum length)
                if (newPassword.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        // Update PasswordHash in users table
                        string query = "UPDATE users SET PasswordHash = @Password WHERE UserID = @UserID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully! Please log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Navigate to LoginForm
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Close(); // Close InputNewPasswordForm
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. User not found.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
             

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void InputNewPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
