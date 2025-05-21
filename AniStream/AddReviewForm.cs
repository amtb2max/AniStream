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
    public partial class AddReviewForm : Form
    {
        private readonly int userId;
        private readonly int animeId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["AnimeStreamingDB"].ConnectionString;

        public AddReviewForm(int userId, int animeId)
        {
            InitializeComponent();
            this.userId = userId;
            this.animeId = animeId;
        }

        private void comboBoxRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            //rating 1-5 only
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // comments
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!int.TryParse(comboBoxRating.SelectedItem?.ToString(), out int rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Please select a rating between 1 and 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string comments = textBoxComment.Text.Trim();
            if (string.IsNullOrEmpty(comments))
            {
                MessageBox.Show("Please enter a comment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comments.Length > 1000)
            {
                MessageBox.Show("Comments cannot exceed 1000 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the user has already reviewed this anime
                    string checkQuery = "SELECT COUNT(*) FROM reviews WHERE UserID = @UserID AND AnimeID = @AnimeID";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@UserID", userId);
                    checkCmd.Parameters.AddWithValue("@AnimeID", animeId);
                    long exists = (long)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("You have already reviewed this anime.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Insert review
                    string insertQuery = @"
                        INSERT INTO reviews (UserID, AnimeID, Rating, Comments)
                        VALUES (@UserID, @AnimeID, @Rating, @Comments)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserID", userId);
                    insertCmd.Parameters.AddWithValue("@AnimeID", animeId);
                    insertCmd.Parameters.AddWithValue("@Rating", rating);
                    insertCmd.Parameters.AddWithValue("@Comments", comments);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Review added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("You have already reviewed this anime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Number == 1452)
                    {
                        MessageBox.Show($"Invalid UserID or AnimeID. (UserID: {userId}, AnimeID: {animeId})", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Database error in AddReview: {ex.Message}\nSQL State: {ex.SqlState}\nError Code: {ex.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error in AddReview: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
