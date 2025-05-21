namespace AniStream
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearchBar = new TextBox();
            button1 = new Button();
            lblUser = new Label();
            btnWatchlist = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button5 = new Button();
            buttonAnime = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Snap ITC", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 43);
            label1.TabIndex = 1;
            label1.Text = "AniStream";
            label1.Click += label1_Click;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(260, 23);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.PlaceholderText = "Search anime here";
            txtSearchBar.Size = new Size(444, 23);
            txtSearchBar.TabIndex = 3;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(710, 22);
            button1.Name = "button1";
            button1.Size = new Size(54, 25);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(795, 27);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(82, 19);
            lblUser.TabIndex = 5;
            lblUser.Text = "Hi, Guest!";
            lblUser.Click += lblUser_Click;
            // 
            // btnWatchlist
            // 
            btnWatchlist.BackColor = Color.Goldenrod;
            btnWatchlist.FlatAppearance.BorderSize = 0;
            btnWatchlist.FlatStyle = FlatStyle.Flat;
            btnWatchlist.Location = new Point(795, 138);
            btnWatchlist.Name = "btnWatchlist";
            btnWatchlist.Size = new Size(98, 25);
            btnWatchlist.TabIndex = 6;
            btnWatchlist.Text = "My Watchlist";
            btnWatchlist.UseVisualStyleBackColor = false;
            btnWatchlist.Click += btnWatchlist_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = Color.Goldenrod;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(752, 422);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(795, 485);
            button3.Name = "button3";
            button3.Size = new Size(98, 25);
            button3.TabIndex = 9;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Goldenrod;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(795, 186);
            button5.Name = "button5";
            button5.Size = new Size(98, 39);
            button5.TabIndex = 11;
            button5.Text = "Top Rated Anime";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // buttonAnime
            // 
            buttonAnime.BackColor = Color.Goldenrod;
            buttonAnime.FlatAppearance.BorderSize = 0;
            buttonAnime.FlatStyle = FlatStyle.Flat;
            buttonAnime.Location = new Point(795, 88);
            buttonAnime.Name = "buttonAnime";
            buttonAnime.Size = new Size(98, 25);
            buttonAnime.TabIndex = 12;
            buttonAnime.Text = "Anime";
            buttonAnime.UseVisualStyleBackColor = false;
            buttonAnime.Click += buttonAnime_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(931, 522);
            Controls.Add(buttonAnime);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(btnWatchlist);
            Controls.Add(lblUser);
            Controls.Add(button1);
            Controls.Add(txtSearchBar);
            Controls.Add(label1);
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchBar;
        private Button button1;
        private Label lblUser;
        private Button btnWatchlist;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button5;
        private Button buttonAnime;
    }
}