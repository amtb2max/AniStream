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
    public partial class AnimeDetails : Form
    {
        private readonly int animeId;
        private readonly int userId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["AnimeStreamingDB"].ConnectionString;
        public AnimeDetails(int animeId, int userId)
        {
            InitializeComponent();
            this.animeId = animeId;
            this.userId = userId;
            LoadAnimeDetails();
            LoadReviews();
        }

        private void LoadAnimeDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT a.Title, a.AnimeDescription, a.ReleaseDate, a.Studio, GetAnimeGenre(a.AnimeID) AS Genres
                        FROM anime a
                        WHERE a.AnimeID = @AnimeID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AnimeID", animeId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelTitle.Text = reader["Title"].ToString();
                            labelDescription.Text = reader["AnimeDescription"].ToString();
                            labelReleaseDate.Text = Convert.ToDateTime(reader["ReleaseDate"]).ToString("yyyy-MM-dd");
                            labelStudio.Text = reader["Studio"].ToString();
                            labelGenre.Text = reader["Genres"]?.ToString() ?? "No genres available";
                        }
                        else
                        {
                            MessageBox.Show("Anime not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error in LoadAnimeDetails (AnimeID: {animeId}): {ex.Message}\nSQL State: {ex.SqlState}\nError Code: {ex.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error in LoadAnimeDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void LoadReviews()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT u.Username, r.Rating, r.Comments
                        FROM reviews r
                        JOIN users u ON r.UserID = u.UserID
                        JOIN anime a ON r.AnimeID = a.AnimeID
                        WHERE r.AnimeID = @AnimeID";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@AnimeID", animeId);
                    DataTable reviewsTable = new DataTable();
                    adapter.Fill(reviewsTable);

                    if (reviewsTable.Rows.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("No reviews found for this anime.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView1.DataSource = reviewsTable;

                        // Customize column headers
                        dataGridView1.Columns["Username"].HeaderText = "User";
                        dataGridView1.Columns["Rating"].HeaderText = "Rating";
                        dataGridView1.Columns["Comments"].HeaderText = "Comment";

                        // Adjust column widths
                        dataGridView1.Columns["Username"].Width = 100;
                        dataGridView1.Columns["Rating"].Width = 50;
                        dataGridView1.Columns["Comments"].Width = 300;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error in LoadReviews (AnimeID: {animeId}): {ex.Message}\nSQL State: {ex.SqlState}\nError Code: {ex.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error in LoadReviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            // title
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {
            // description
        }

        private void labelReleaseDate_Click(object sender, EventArgs e)
        {
            //release date
        }

        private void labelStudio_Click(object sender, EventArgs e)
        {
            //studio
        }

        private void labelGenre_Click(object sender, EventArgs e)
        {
            //genre
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // reviews datagrid
        }

        private void buttonAddWatchlist_Click(object sender, EventArgs e)
        {
            // add to watchlist 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the anime is already in the user's watchlist
                    string checkQuery = "SELECT COUNT(*) FROM watchlist WHERE UserID = @UserID AND AnimeID = @AnimeID";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@UserID", userId);
                    checkCmd.Parameters.AddWithValue("@AnimeID", animeId);
                    long exists = (long)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("This anime is already in your watchlist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Insert into watchlist
                    string insertQuery = "INSERT INTO watchlist (UserID, AnimeID) VALUES (@UserID, @AnimeID)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserID", userId);
                    insertCmd.Parameters.AddWithValue("@AnimeID", animeId);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Added to watchlist successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Duplicate entry error
                    {
                        MessageBox.Show("This anime is already in your watchlist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Number == 1452) // Foreign key constraint violation
                    {
                        MessageBox.Show($"Invalid UserID or AnimeID. (UserID: {userId}, AnimeID: {animeId})", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Database error in AddWatchlist: {ex.Message}\nSQL State: {ex.SqlState}\nError Code: {ex.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error in AddWatchlist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            // add review
            AddReviewForm addreview  = new AddReviewForm(userId, animeId);
            addreview.Show();
            LoadReviews();
        }
    }
}
