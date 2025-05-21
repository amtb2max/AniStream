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
    public partial class AddAnimeForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["AnimeStreamingDB"].ConnectionString;
        private readonly bool isUpdateMode;
        private  int animeId;

        public AddAnimeForm(bool isUpdate = false, int animeId = 0, string title = "", string description = "", DateTime? releaseDate = null, string studio = "", List<int> genreIds = null)
        {
            InitializeComponent();
            isUpdateMode = isUpdate;
            this.animeId = animeId;

            // Set form mode
            labelTable.Text = isUpdate ? "UPDATE ANIME" : "ADD ANIME";
            buttonLogin.Text = isUpdate ? "Update Anime" : "Add Anime";

            // Populate fields for update mode
            if (isUpdate)
            {
                textBoxTittle.Text = title;
                textBoxDescription.Text = description;
                dateTimePicker1.Value = releaseDate ?? DateTime.Today;
                textBoxStudio.Text = studio;

                // Set genre checkboxes
                if (genreIds != null)
                {
                    int[] allGenreIds = new int[] { 1, 2, 5, 4, 3, 10, 6, 8, 7, 9 }; // Action, Adventure, Comedy, Drama, Fantasy, Thriller, Sci-Fi, Romance, Mystery, Horror
                    checkBox1.Checked = genreIds.Contains(allGenreIds[0]);
                    checkBox2.Checked = genreIds.Contains(allGenreIds[1]);
                    checkBox3.Checked = genreIds.Contains(allGenreIds[2]);
                    checkBox4.Checked = genreIds.Contains(allGenreIds[3]);
                    checkBox5.Checked = genreIds.Contains(allGenreIds[4]);
                    checkBox6.Checked = genreIds.Contains(allGenreIds[5]);
                    checkBox7.Checked = genreIds.Contains(allGenreIds[6]);
                    checkBox8.Checked = genreIds.Contains(allGenreIds[7]);
                    checkBox9.Checked = genreIds.Contains(allGenreIds[8]);
                    checkBox10.Checked = genreIds.Contains(allGenreIds[9]);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // title label
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //action
        }

        private void AddAnimeForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTittle_TextChanged(object sender, EventArgs e)
        {
            // title txtbox
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // date picker
        }

        private void textBoxStudio_TextChanged(object sender, EventArgs e)
        {
            // studio txtbox
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            //description
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //adventure
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //comedy
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //drama
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //fantasy
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            //horror
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            //mystery
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //romance
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //SCi-fi
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //Thriller
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // add anime button
            // validate inputs
            if (string.IsNullOrWhiteSpace(textBoxTittle.Text))
            {
                MessageBox.Show("Please enter an anime title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxTittle.Text.Trim().Length > 100)
            {
                MessageBox.Show("Title must be 100 characters or less.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxStudio.Text))
            {
                MessageBox.Show("Please enter a studio name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxStudio.Text.Trim().Length > 100)
            {
                MessageBox.Show("Studio name must be 100 characters or less.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check if at least one genre is selected
            bool[] genreChecks = new bool[] {
                checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked,
                checkBox6.Checked, checkBox7.Checked, checkBox8.Checked, checkBox9.Checked, checkBox10.Checked
            };
            if (!genreChecks.Any(checkedGenre => checkedGenre))
            {
                MessageBox.Show("Please select at least one genre.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (isUpdateMode)
                    {
                        // call the UpdateAnime stored procedure
                        using (MySqlCommand cmd = new MySqlCommand("UpdateAnime", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("anime_id", animeId);
                            cmd.Parameters.AddWithValue("anime_title", textBoxTittle.Text.Trim());
                            cmd.Parameters.AddWithValue("anime_description", textBoxDescription.Text.Trim());
                            cmd.Parameters.AddWithValue("release_date", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("studio_name", textBoxStudio.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }

                        // Delete existing genres
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM animegenre WHERE AnimeID = @AnimeID", conn))
                        {
                            cmd.Parameters.AddWithValue("@AnimeID", animeId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Call the InsertNewAnime stored procedure
                        using (MySqlCommand cmd = new MySqlCommand("InsertNewAnime", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("anime_title", textBoxTittle.Text.Trim());
                            cmd.Parameters.AddWithValue("anime_description", textBoxDescription.Text.Trim());
                            cmd.Parameters.AddWithValue("release_date", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("studio_name", textBoxStudio.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }

                        // Get the newly inserted AnimeID
                        using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
                        {
                            animeId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }

                    // Insert selected genres
                    int[] genreIds = new int[] { 1, 2, 5, 4, 3, 10, 6, 8, 7, 9 }; // Action, Adventure, Comedy, Drama, Fantasy, Thriller, Sci-Fi, Romance, Mystery, Horror
                    for (int i = 0; i < genreChecks.Length; i++)
                    {
                        if (genreChecks[i])
                        {
                            int genreId = genreIds[i];
                            using (MySqlCommand cmd = new MySqlCommand(
                                "INSERT INTO animegenre (AnimeID, GenreID) VALUES (@AnimeID, @GenreID)", conn))
                            {
                                cmd.Parameters.AddWithValue("@AnimeID", animeId);
                                cmd.Parameters.AddWithValue("@GenreID", genreId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show(isUpdateMode ? "Anime updated successfully!" : "Anime added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //AdminForm adminForm = new AdminForm();
                    //adminForm.Show();
                    this.Close();
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //AdminForm addminForm = new AdminForm();
            //addminForm.Show();
            this.Close();
        }

        private void labelTable_Click(object sender, EventArgs e)
        {
            // add anime label
        }
    }
}
