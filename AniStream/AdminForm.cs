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
using OfficeOpenXml;
using System.IO;

namespace AniStream
{
    public partial class AdminForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["AnimeStreamingDB"].ConnectionString;
        private DataTable originalDataTable; // Store the original unfiltered data


        public AdminForm()
        {
            InitializeComponent();
        }

        private void LoadAnimeData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // query the anime table 
                    string query = "SELECT AnimeID, Title, AnimeDescription, ReleaseDate, Studio FROM anime";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable animeTable = new DataTable();
                    adapter.Fill(animeTable);

                    dataGridView1.DataSource = animeTable;
                    originalDataTable = animeTable; 

                  
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


                    
                    labelTable.Text = "ANIME TABLE";
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


        private void LoadUsersData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // qeery the users table 
                    string query = "SELECT UserID, Username, Email, CreatedAt, last_login AS LastLogin FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable usersTable = new DataTable();
                    adapter.Fill(usersTable);

                    
                    dataGridView1.DataSource = usersTable;
                    originalDataTable = usersTable;

                    
                    dataGridView1.Columns["UserID"].HeaderText = "ID";
                    dataGridView1.Columns["Username"].HeaderText = "Username";
                    dataGridView1.Columns["Email"].HeaderText = "Email";
                    dataGridView1.Columns["CreatedAt"].HeaderText = "Created At";
                    dataGridView1.Columns["LastLogin"].HeaderText = "Last Login";

                   
                    dataGridView1.Columns["UserID"].Width = 50;
                    dataGridView1.Columns["Username"].Width = 120;
                    dataGridView1.Columns["Email"].Width = 150;
                    dataGridView1.Columns["CreatedAt"].Width = 120;
                    dataGridView1.Columns["LastLogin"].Width = 120;

                    
                    labelTable.Text = "USERS TABLE";
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

        private void LoadReviewsData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // query
                    string query = @"
                        SELECT r.ReviewID, u.Username, a.Title AS AnimeTitle, r.Rating, r.Comments
                        FROM reviews r
                        JOIN users u ON r.UserID = u.UserID
                        JOIN anime a ON r.AnimeID = a.AnimeID";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable reviewsTable = new DataTable();
                    adapter.Fill(reviewsTable);

                    
                    dataGridView1.DataSource = reviewsTable;
                    originalDataTable = reviewsTable;

                    
                    dataGridView1.Columns["ReviewID"].HeaderText = "ID";
                    dataGridView1.Columns["Username"].HeaderText = "Username";
                    dataGridView1.Columns["AnimeTitle"].HeaderText = "Anime Title";
                    dataGridView1.Columns["Rating"].HeaderText = "Rating";
                    dataGridView1.Columns["Comments"].HeaderText = "Comments";

                    
                    dataGridView1.Columns["ReviewID"].Width = 50;
                    dataGridView1.Columns["Username"].Width = 120;
                    dataGridView1.Columns["AnimeTitle"].Width = 150;
                    dataGridView1.Columns["Rating"].Width = 80;
                    dataGridView1.Columns["Comments"].Width = 300;

                    
                    labelTable.Text = "REVIEWS TABLE";
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

        private void LoadAnimeRatingsData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    //call stored procedrue
                    string query = "CALL DisplayAnimeWithRatings()";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable ratingsTable = new DataTable();
                    adapter.Fill(ratingsTable);

                   
                    dataGridView1.DataSource = ratingsTable;
                    originalDataTable = ratingsTable;

                    
                    dataGridView1.Columns["Anime ID"].HeaderText = "ID";
                    dataGridView1.Columns["Title"].HeaderText = "Anime Title";
                    dataGridView1.Columns["Description"].HeaderText = "Description";
                    dataGridView1.Columns["Average Rating"].HeaderText = "Average Rating";

                   
                    dataGridView1.Columns["Average Rating"].DefaultCellStyle.Format = "N2";

                    
                    dataGridView1.Columns["Anime ID"].Width = 50;
                    dataGridView1.Columns["Title"].Width = 150;
                    dataGridView1.Columns["Description"].Width = 300;
                    dataGridView1.Columns["Average Rating"].Width = 100;

                    
                    labelTable.Text = "ANIME RATINGS TABLE";
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

        private void LoadAnimePopularityData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // query to findthe anime with highest Watchlist for each SnapshotDate
                    string query = @"
                        WITH RankedSnapshots AS (
                            SELECT 
                                a.Title AS AnimeName,
                                aps.WatchlistCount,
                                aps.ReviewCount,
                                aps.AverageRating,
                                aps.SnapshotDate,
                                RANK() OVER (PARTITION BY aps.SnapshotDate ORDER BY aps.WatchlistCount DESC) AS RankNum
                            FROM anime_popularity_snapshots aps
                            JOIN anime a ON aps.AnimeID = a.AnimeID
                        )
                        SELECT 
                            AnimeName,
                            WatchlistCount,
                            ReviewCount,
                            AverageRating,
                            SnapshotDate
                        FROM RankedSnapshots
                        WHERE RankNum = 1
                        ORDER BY SnapshotDate DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable popularityTable = new DataTable();
                    adapter.Fill(popularityTable);

                   
                    dataGridView1.DataSource = popularityTable;
                    originalDataTable = popularityTable;

                   
                    dataGridView1.Columns["AnimeName"].HeaderText = "Anime Name";
                    dataGridView1.Columns["WatchlistCount"].HeaderText = "Watchlist Count";
                    dataGridView1.Columns["ReviewCount"].HeaderText = "Review Count";
                    dataGridView1.Columns["AverageRating"].HeaderText = "Average Rating";
                    dataGridView1.Columns["SnapshotDate"].HeaderText = "Snapshot Date";

                    // averageRating to two decimal places
                    dataGridView1.Columns["AverageRating"].DefaultCellStyle.Format = "N2";

                    
                    dataGridView1.Columns["AnimeName"].Width = 150;
                    dataGridView1.Columns["WatchlistCount"].Width = 100;
                    dataGridView1.Columns["ReviewCount"].Width = 100;
                    dataGridView1.Columns["AverageRating"].Width = 100;
                    dataGridView1.Columns["SnapshotDate"].Width = 100;

                    // update labelTable
                    labelTable.Text = "ANIME POPULARITY TABLE";
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

        private void LoadLogsData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query the audit_log 
                    string query = "SELECT LogID, Action, TableName, Description, Timestamp FROM audit_log";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable logsTable = new DataTable();
                    adapter.Fill(logsTable);

                    
                    dataGridView1.DataSource = logsTable;
                    originalDataTable = logsTable;

                    
                    dataGridView1.Columns["LogID"].HeaderText = "ID";
                    dataGridView1.Columns["Action"].HeaderText = "Action";
                    dataGridView1.Columns["TableName"].HeaderText = "Table Name";
                    dataGridView1.Columns["Description"].HeaderText = "Description";
                    dataGridView1.Columns["Timestamp"].HeaderText = "Timestamp";

                   
                    dataGridView1.Columns["LogID"].Width = 50;
                    dataGridView1.Columns["Action"].Width = 100;
                    dataGridView1.Columns["TableName"].Width = 120;
                    dataGridView1.Columns["Description"].Width = 300;
                    dataGridView1.Columns["Timestamp"].Width = 120;

                    // Update labelTable
                    labelTable.Text = "LOGS TABLE";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // datagrid 
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            //label for admin
        }

        private void buttonAnime_Click(object sender, EventArgs e)
        {
            //anime button to list all anime in the datagrid
            LoadAnimeData();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            //users button to list all users
            LoadUsersData();
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {
            // reviews button to list al reviews
            LoadReviewsData();
        }

        private void buttonAddAnime_Click(object sender, EventArgs e)
        {
            //add anime button
            AddAnimeForm addanime = new AddAnimeForm();
            addanime.Show();
            //this.Close();

        }

        private void buttonREmoveAnime_Click(object sender, EventArgs e)
        {
            // remove anime
            if (labelTable.Text != "ANIME TABLE")
            {
                MessageBox.Show("Please select the anime table to remove an anime.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an anime to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int animeId = Convert.ToInt32(selectedRow.Cells["AnimeID"].Value);
                string animeTitle = selectedRow.Cells["Title"].Value.ToString();

                // confirm deletion
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{animeTitle}'? This will also remove related reviews, genres, and popularity data.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM anime WHERE AnimeID = @AnimeID", conn))
                        {
                            cmd.Parameters.AddWithValue("@AnimeID", animeId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // refresh the table
                    LoadAnimeData();
                    MessageBox.Show("Anime deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // update anime
            if (labelTable.Text != "ANIME TABLE")
            {
                MessageBox.Show("Please select the anime table to update an anime.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an anime to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int animeId = Convert.ToInt32(selectedRow.Cells["AnimeID"].Value);
                string title = selectedRow.Cells["Title"].Value.ToString();
                string description = selectedRow.Cells["AnimeDescription"].Value.ToString();
                DateTime releaseDate = Convert.ToDateTime(selectedRow.Cells["ReleaseDate"].Value);
                string studio = selectedRow.Cells["Studio"].Value.ToString();

                // get current genres
                List<int> genreIds = new List<int>();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT GenreID FROM animegenre WHERE AnimeID = @AnimeID", conn))
                    {
                        cmd.Parameters.AddWithValue("@AnimeID", animeId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                genreIds.Add(reader.GetInt32("GenreID"));
                            }
                        }
                    }
                }

                // Open AddAnimeForm in update mode
                AddAnimeForm updateAnimeForm = new AddAnimeForm(
                    isUpdate: true,
                    animeId: animeId,
                    title: title,
                    description: description,
                    releaseDate: releaseDate,
                    studio: studio,
                    genreIds: genreIds
                );
                updateAnimeForm.Show();
                LoadAnimeData(); // Refresh the anime table
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

        private void button2_Click(object sender, EventArgs e)
        {
            // anime ratings
            LoadAnimeRatingsData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // anime pupolarity
            LoadAnimePopularityData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // logout button
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void labelTable_Click(object sender, EventArgs e)
        {
            // this will change to ANIME TABLE, USERS TABLE, REVIEWS TABLE
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadAnimeData();
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            //logs
            LoadLogsData();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            //searchbar txtbox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search button
            try
            {
                
                string keyword = txtSearchBar.Text.Trim();

                // chek search bar is empty
                if (string.IsNullOrEmpty(keyword))
                {
                    // go baxck original data if search bar is nothing
                    dataGridView1.DataSource = originalDataTable;
                    return;
                }

                // Get the current table
                string currentTable = labelTable.Text;
                if (originalDataTable == null)
                {
                    MessageBox.Show("No table is currently loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // copy of the original DataTable
                DataTable filteredTable = originalDataTable.Clone();
                string filterExpression = "";

                // Define search columns based on the current table
                switch (currentTable)
                {
                    case "ANIME TABLE":
                        filterExpression = $"Title LIKE '%{keyword}%' OR AnimeDescription LIKE '%{keyword}%' OR Studio LIKE '%{keyword}%'";
                        break;
                    case "USERS TABLE":
                        filterExpression = $"Username LIKE '%{keyword}%' OR Email LIKE '%{keyword}%'";
                        break;
                    case "REVIEWS TABLE":
                        filterExpression = $"Username LIKE '%{keyword}%' OR AnimeTitle LIKE '%{keyword}%' OR Comments LIKE '%{keyword}%'";
                        break;
                    case "ANIME RATINGS TABLE":
                        filterExpression = $"Title LIKE '%{keyword}%' OR Description LIKE '%{keyword}%'";
                        break;
                    case "ANIME POPULARITY TABLE":
                        filterExpression = $"AnimeName LIKE '%{keyword}%'";
                        break;
                    case "LOGS TABLE":
                        filterExpression = $"Action LIKE '%{keyword}%' OR TableName LIKE '%{keyword}%' OR Description LIKE '%{keyword}%'";
                        break;
                    default:
                        MessageBox.Show("Unknown table selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Apply the filter
                DataRow[] filteredRows = originalDataTable.Select(filterExpression);

                // Check if rows match the filter
                if (filteredRows.Length == 0)
                {
                    MessageBox.Show("No results found for the given keyword.", "Nothing Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = filteredTable; // Show empty table
                    return;
                }

                // Copy filtered rows to the new DataTable
                foreach (DataRow row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                // Update the DataGridView with the filtered data
                dataGridView1.DataSource = filteredTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            //export to excel button
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to export.", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save Report as Excel";
                    saveFileDialog.FileName = $"{labelTable.Text.Replace(" ", "_")}_Report.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExcelPackage.License.SetNonCommercialPersonal("Aedrian");

                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Report");

                            // Write column headers
                            for (int col = 0; col < dataGridView1.Columns.Count; col++)
                            {
                                worksheet.Cells[1, col + 1].Value = dataGridView1.Columns[col].HeaderText;
                                worksheet.Cells[1, col + 1].Style.Font.Bold = true;
                            }

                            // Write data rows
                            for (int row = 0; row < dataGridView1.Rows.Count; row++)
                            {
                                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = dataGridView1.Rows[row].Cells[col].Value;
                                }
                            }

                            
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fileInfo);

                            MessageBox.Show("Excel report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
