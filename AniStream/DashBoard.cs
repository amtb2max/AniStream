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
    public partial class DashBoard : Form
    {
        private readonly int userId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["AnimeStreamingDB"].ConnectionString;
        private string currentView; // Tracks current view: "AllAnime", "Watchlist", "TopRated"

        public DashBoard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUsername();
            LoadAnimeData();
        }

        private void LoadUsername()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Username FROM users WHERE UserID = @UserID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        lblUser.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblUser.Text = "Unknown User";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblUser.Text = "Error";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblUser.Text = "Error";
                }
            }
        }

        private void LoadAnimeData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query the anime table directly to get AnimeID, Title, AnimeDescription, ReleaseDate, and-studio
                    string query = "SELECT AnimeID, Title, AnimeDescription, ReleaseDate, Studio FROM anime";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable animeTable = new DataTable();
                    adapter.Fill(animeTable);

                    dataGridView1.DataSource = animeTable;
                    currentView = "AllAnime";

                    // Customize column headers
                    dataGridView1.Columns["AnimeID"].HeaderText = "ID";
                    dataGridView1.Columns["Title"].HeaderText = "Anime Title";
                    dataGridView1.Columns["AnimeDescription"].HeaderText = "Description";
                    dataGridView1.Columns["ReleaseDate"].HeaderText = "Release Date";
                    dataGridView1.Columns["Studio"].HeaderText = "Studio";

                    // Optional: Adjust column widths
                    dataGridView1.Columns["AnimeID"].Width = 50;
                    dataGridView1.Columns["Title"].Width = 150;
                    dataGridView1.Columns["AnimeDescription"].Width = 300;
                    dataGridView1.Columns["ReleaseDate"].Width = 100;
                    dataGridView1.Columns["Studio"].Width = 120;
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

        private void LoadWatchlistData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT w.WatchlistID, a.Title, w.AnimeID
                        FROM watchlist w
                        JOIN anime a ON w.AnimeID = a.AnimeID
                        WHERE w.UserID = @UserID";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);
                    DataTable watchlistTable = new DataTable();
                    adapter.Fill(watchlistTable);

                    if (watchlistTable.Rows.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Your watchlist is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataGridView1.DataSource = watchlistTable;
                    currentView = "Watchlist";

                    // Customize column headers and visibility
                    dataGridView1.Columns["WatchlistID"].HeaderText = "Watchlist ID";
                    dataGridView1.Columns["Title"].HeaderText = "Anime Title";
                    dataGridView1.Columns["AnimeID"].Visible = false; // Hide AnimeID but keep for clicks

                    // Adjust column widths
                    dataGridView1.Columns["WatchlistID"].Width = 100;
                    dataGridView1.Columns["Title"].Width = 200;

                    // Remove highlighting
                    dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                    dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error in LoadWatchlistData: {ex.Message}\nSQL State: {ex.SqlState}\nError Code: {ex.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error in LoadWatchlistData: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadTopRatedAnimeData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT AnimeID, Title, AvgRating FROM view_topratedanime";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable topRatedTable = new DataTable();
                    adapter.Fill(topRatedTable);

                    if (topRatedTable.Rows.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("No top-rated anime found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataGridView1.DataSource = topRatedTable;
                    currentView = "TopRated";

                    dataGridView1.Columns["AnimeID"].Visible = false;
                    dataGridView1.Columns["Title"].HeaderText = "Anime Title";
                    dataGridView1.Columns["AvgRating"].HeaderText = "Average Rating";

                    dataGridView1.Columns["Title"].Width = 200;
                    dataGridView1.Columns["AvgRating"].Width = 100;

                    // Format AverageRating to 2 decimal places
                    dataGridView1.Columns["AvgRating"].DefaultCellStyle.Format = "N2";

                    dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                    dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error in LoadTopRatedAnimeData: {ex.Message}\nSQL State: {ex.SqlState}\nError Code: {ex.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error in LoadTopRatedAnimeData: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchAnime(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                // If keyword is empty, reload the current view
                if (currentView == "AllAnime")
                    LoadAnimeData();
                else if (currentView == "Watchlist")
                    LoadWatchlistData();
                else if (currentView == "TopRated")
                    LoadTopRatedAnimeData();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "";
                    MySqlDataAdapter adapter;

                    if (currentView == "AllAnime")
                    {
                        query = @"
                            SELECT AnimeID, Title, AnimeDescription, ReleaseDate, Studio
                            FROM anime
                            WHERE Title LIKE @Keyword";
                        adapter = new MySqlDataAdapter(query, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                    }
                    else if (currentView == "Watchlist")
                    {
                        query = @"
                            SELECT w.WatchlistID, a.Title, w.AnimeID
                            FROM watchlist w
                            JOIN anime a ON w.AnimeID = a.AnimeID
                            WHERE w.UserID = @UserID AND a.Title LIKE @Keyword";
                        adapter = new MySqlDataAdapter(query, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);
                        adapter.SelectCommand.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                    }
                    else // TopRated
                    {
                        query = @"
                            SELECT AnimeID, Title, AvgRating
                            FROM view_topratedanime
                            WHERE Title LIKE @Keyword";
                        adapter = new MySqlDataAdapter(query, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@Keyword", $"%{keyword}%");
                    }

                    DataTable searchTable = new DataTable();
                    adapter.Fill(searchTable);

                    if (searchTable.Rows.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("No anime found matching the keyword.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataGridView1.DataSource = searchTable;

                    // Configure columns based on current view
                    if (currentView == "AllAnime")
                    {
                        dataGridView1.Columns["AnimeID"].HeaderText = "ID";
                        dataGridView1.Columns["Title"].HeaderText = "Anime Title";
                        dataGridView1.Columns["AnimeDescription"].HeaderText = "Description";
                        dataGridView1.Columns["ReleaseDate"].HeaderText = "Release Date";
                        dataGridView1.Columns["Studio"].HeaderText = "Studio";

                        dataGridView1.Columns["AnimeID"].Width = 50;
                        dataGridView1.Columns["Title"].Width = 150;
                        dataGridView1.Columns["AnimeDescription"].Width = 300;
                        dataGridView1.Columns["ReleaseDate"].Width = 100;
                        dataGridView1.Columns["Studio"].Width = 120;
                    }
                    else if (currentView == "Watchlist")
                    {
                        dataGridView1.Columns["WatchlistID"].HeaderText = "Watchlist ID";
                        dataGridView1.Columns["Title"].HeaderText = "Anime Title";
                        dataGridView1.Columns["AnimeID"].Visible = false;

                        dataGridView1.Columns["WatchlistID"].Width = 100;
                        dataGridView1.Columns["Title"].Width = 200;
                    }
                    else // TopRated
                    {
                        dataGridView1.Columns["AnimeID"].Visible = false;
                        dataGridView1.Columns["Title"].HeaderText = "Anime Title";
                        dataGridView1.Columns["AvgRating"].HeaderText = "Average Rating";

                        dataGridView1.Columns["Title"].Width = 200;
                        dataGridView1.Columns["AvgRating"].Width = 100;

                        dataGridView1.Columns["AvgRating"].DefaultCellStyle.Format = "N2";
                    }

                    dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                    dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error in SearchAnime: {ex.Message}\nSQL State: {ex.SqlState}\nError Code: {ex.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error in SearchAnime: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            //username will show the username of the user
        }

        private void btnWatchlist_Click(object sender, EventArgs e)
        {
            //watchlist button
            LoadWatchlistData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //aniStream label
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Myprofile button
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //reviews button
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // top rated anime button
            LoadTopRatedAnimeData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //logout button
            // Logout: Close DashBoard and show LoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            //searchbar textbox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search button
            SearchAnime(txtSearchBar.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data grid to show anime
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int animeId = Convert.ToInt32(row.Cells["AnimeID"].Value);
                AnimeDetails animeDetailsForm = new AnimeDetails(animeId, userId);
                animeDetailsForm.Show();
            }
        }

        private void buttonAnime_Click(object sender, EventArgs e)
        {
            LoadAnimeData();
        }
    }
}
