using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AniStream
{
    public partial class HomeScreen : Form
    {
        // Hardcoded data (structured for MySQL: anime table with AnimeID, Title, Description, Studio)
        private List<(int AnimeID, string Title, string Description, string Studio)> animeList =
            new List<(int, string, string, string)>
        {
            (1, "Attack On Titan",
                "Centuries ago, mankind was slaughtered to near extinction by monstrous humanoid creatures called Titans, forcing humans to hide in fear behind enormous concentric walls. What makes these giants truly terrifying is that their taste for human flesh is not born out of hunger but what appears to be out of pleasure. To ensure their survival, the remnants of humanity began living within defensive barriers, resulting in one hundred years without a single titan encounter. However, that fragile calm is soon shattered when a colossal Titan manages to breach the supposedly impregnable outer wall, reigniting the fight for survival against the man-eating abominations. After witnessing a horrific personal loss at the hands of the invading creatures, Eren Yeager dedicates his life to their eradication by enlisting into the Survey Corps, an elite military unit that combats the merciless humanoids outside the protection of the walls. Eren, his adopted sister Mikasa Ackerman, and his childhood friend Armin Arlert join the brutal war against the Titans and race to discover a way of defeating them before the last walls are breached.",
                "Wit Studio"),
            (2, "Demon Slayer",
                "Tanjiro Kamado becomes a demon slayer to save his sister Nezuko, who was turned into a demon, and avenge his family.",
                "Ufotable"),
            (3, "My Hero Academia",
                "Izuku Midoriya, a quirkless boy, inherits the powers of the world's greatest hero and trains to become a pro hero.",
                "Bones"),
            (4, "Naruto Shippuden",
                "Naruto Uzumaki continues his journey to become Hokage, facing powerful enemies and uncovering his destiny.",
                "Studio Pierrot"),
            (5, "One Piece",
                "Monkey D. Luffy and his pirate crew search for the legendary treasure One Piece to become the Pirate King.",
                "Toei Animation"),
            (6, "Solo Leveling",
                "Sung Jinwoo, a weak hunter, gains a mysterious power that allows him to level up and face stronger enemies.",
                "A-1 Pictures"),
            (7, "Kimi no Nawa",
                "Two teenagers, Mitsuha and Taki, mysteriously swap bodies and work to prevent a disaster while unraveling their connection.",
                "CoMix Wave Films"),
            (8, "Overflow",
                "A romantic comedy involving college students caught in unexpected and steamy situations.",
                "Studio Hōkiboshi"),
            (9, "Highschool DxD",
                "Issei Hyoudou, a high school student, becomes a demon servant and navigates a world of angels, demons, and battles.",
                "TNK"),
            (10, "Redo of Healer",
                "Keyaru, a healer, gains the ability to redo his life and seeks revenge on those who wronged him in a dark fantasy world.",
                "TNK")
        };

        // Hardcoded Genre and Release Date for each anime (not in animeList)
        private readonly Dictionary<int, (string Genre, string ReleaseDate)> animeDetails =
            new Dictionary<int, (string, string)>
        {
            { 1, ("Action, Drama, Suspense", "April 07, 2013") },
            { 2, ("Action, Supernatural", "April 06, 2019") },
            { 3, ("Action, Superhero", "April 03, 2016") },
            { 4, ("Action, Adventure", "February 15, 2007") },
            { 5, ("Adventure, Comedy", "October 20, 1999") },
            { 6, ("Action, Fantasy", "January 07, 2024") },
            { 7, ("Romance, Supernatural", "August 26, 2016") },
            { 8, ("Romance, Ecchi", "January 06, 2020") },
            { 9, ("Action, Ecchi", "January 06, 2012") },
            { 10, ("Fantasy, Ecchi", "January 13, 2021") }
        };

        public HomeScreen()
        {
            InitializeComponent();

            // Initialize DataGridView properties
            SetupDataGridView();

            // Load data into DataGridView
            LoadAnimeData();
        }

        private void SetupDataGridView()
        {
            // Configure DataGridView properties
            dataGridShowAnime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridShowAnime.AllowUserToAddRows = false;
            dataGridShowAnime.AllowUserToDeleteRows = false;
            dataGridShowAnime.ReadOnly = true;
            dataGridShowAnime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridShowAnime.MultiSelect = false;
            dataGridShowAnime.ScrollBars = ScrollBars.Vertical;

            // Set background to match form or make transparent
            dataGridShowAnime.BackgroundColor = this.BackColor; // Matches form (SystemColors.ControlText)
            // Optional: Uncomment for transparent effect
            // dataGridShowAnime.BackgroundColor = Color.Transparent;
            dataGridShowAnime.GridColor = this.BackColor;
            dataGridShowAnime.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Clear existing columns
            dataGridShowAnime.Columns.Clear();

            // Add Number column
            DataGridViewTextBoxColumn numberColumn = new DataGridViewTextBoxColumn
            {
                Name = "Number",
                HeaderText = "No.",
                DataPropertyName = "Number",
                Width = 100
            };
            dataGridShowAnime.Columns.Add(numberColumn);

            // Add Title column
            DataGridViewTextBoxColumn titleColumn = new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Anime Title",
                DataPropertyName = "Title",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridShowAnime.Columns.Add(titleColumn);

            // Attach selection changed event (instead of CellContentClick)
            dataGridShowAnime.SelectionChanged += DataGridShowAnime_SelectionChanged;
        }

        private void LoadAnimeData()
        {
            // Create DataTable for DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("Number", typeof(int));
            dt.Columns.Add("Title", typeof(string));

            // Populate with hardcoded data
            for (int i = 0; i < animeList.Count; i++)
            {
                dt.Rows.Add(i + 1, animeList[i].Title);
            }

            // Bind to DataGridView
            dataGridShowAnime.DataSource = dt;

            // Clear initial selection to prevent SelectionChanged firing on startup
            dataGridShowAnime.ClearSelection();
        }

        private void DataGridShowAnime_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridShowAnime.SelectedRows.Count > 0)
            //{
            //    // Get selected row data
            //    int number = Convert.ToInt32(dataGridShowAnime.SelectedRows[0].Cells["Number"].Value);
            //    string title = dataGridShowAnime.SelectedRows[0].Cells["Title"].Value.ToString();

            //    // Placeholder for future functionality
            //    MessageBox.Show($"Selected Anime: {title} (No. {number})", "Anime Selected",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if (dataGridShowAnime.SelectedRows.Count > 0)
            {
                int number = Convert.ToInt32(dataGridShowAnime.SelectedRows[0].Cells["Number"].Value);
                // Find the anime by number (number is 1-based, list is 0-based)
                var selectedAnime = animeList[number - 1];
                lblAnimeTitle.Text = selectedAnime.Title;
                // Combine description with hardcoded details
                if (animeDetails.TryGetValue(selectedAnime.AnimeID, out var details))
                {
                    lblDescription.Text = $"{selectedAnime.Description}\n\n" +
                                         $"Genre: {details.Genre}\n" +
                                         $"Studio: {selectedAnime.Studio}\n" +
                                         $"Release Date: {details.ReleaseDate}";
                }
                else
                {
                    lblDescription.Text = selectedAnime.Description; // Fallback
                }
            }
            else
            {
                lblAnimeTitle.Text = "No anime selected";
                lblDescription.Text = "Select an anime to view its description.";
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            // Placeholder for user label click (e.g., login/logout)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kept for compatibility, but SelectionChanged is preferred for row selection
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}