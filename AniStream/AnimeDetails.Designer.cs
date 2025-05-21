namespace AniStream
{
    partial class AnimeDetails
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
            labelTitle = new Label();
            labelDescription = new Label();
            label1 = new Label();
            labelReleaseDate = new Label();
            label2 = new Label();
            labelStudio = new Label();
            label3 = new Label();
            labelGenre = new Label();
            buttonAddWatchlist = new Button();
            buttonAddReview = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(69, 34);
            labelTitle.MaximumSize = new Size(500, 30);
            labelTitle.MinimumSize = new Size(250, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(250, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "labelTitle";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelDescription
            // 
            labelDescription.BackColor = Color.Transparent;
            labelDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.ForeColor = Color.White;
            labelDescription.Location = new Point(69, 87);
            labelDescription.MaximumSize = new Size(704, 200);
            labelDescription.MinimumSize = new Size(500, 100);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(704, 100);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "labelDescription";
            labelDescription.Click += labelDescription_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 212);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 2;
            label1.Text = "Release Date:";
            // 
            // labelReleaseDate
            // 
            labelReleaseDate.AutoSize = true;
            labelReleaseDate.BackColor = Color.Transparent;
            labelReleaseDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReleaseDate.ForeColor = Color.White;
            labelReleaseDate.Location = new Point(168, 212);
            labelReleaseDate.Name = "labelReleaseDate";
            labelReleaseDate.Size = new Size(85, 17);
            labelReleaseDate.TabIndex = 3;
            labelReleaseDate.Text = "Release Date";
            labelReleaseDate.Click += labelReleaseDate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 245);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 4;
            label2.Text = "Studio:";
            label2.Click += label2_Click_1;
            // 
            // labelStudio
            // 
            labelStudio.AutoSize = true;
            labelStudio.BackColor = Color.Transparent;
            labelStudio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudio.ForeColor = Color.White;
            labelStudio.Location = new Point(168, 245);
            labelStudio.Name = "labelStudio";
            labelStudio.Size = new Size(47, 17);
            labelStudio.TabIndex = 5;
            labelStudio.Text = "Studio";
            labelStudio.Click += labelStudio_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 282);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 6;
            label3.Text = "Genre:";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.BackColor = Color.Transparent;
            labelGenre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGenre.ForeColor = Color.White;
            labelGenre.Location = new Point(168, 282);
            labelGenre.MaximumSize = new Size(500, 0);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(44, 17);
            labelGenre.TabIndex = 7;
            labelGenre.Text = "Genre";
            labelGenre.Click += labelGenre_Click;
            // 
            // buttonAddWatchlist
            // 
            buttonAddWatchlist.BackColor = Color.Goldenrod;
            buttonAddWatchlist.FlatAppearance.BorderSize = 0;
            buttonAddWatchlist.FlatStyle = FlatStyle.Flat;
            buttonAddWatchlist.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddWatchlist.ForeColor = Color.Black;
            buttonAddWatchlist.Location = new Point(675, 376);
            buttonAddWatchlist.Name = "buttonAddWatchlist";
            buttonAddWatchlist.Size = new Size(98, 44);
            buttonAddWatchlist.TabIndex = 10;
            buttonAddWatchlist.Text = "Add to My Watchlist";
            buttonAddWatchlist.UseVisualStyleBackColor = false;
            buttonAddWatchlist.Click += buttonAddWatchlist_Click;
            // 
            // buttonAddReview
            // 
            buttonAddReview.BackColor = Color.Goldenrod;
            buttonAddReview.FlatAppearance.BorderSize = 0;
            buttonAddReview.FlatStyle = FlatStyle.Flat;
            buttonAddReview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddReview.ForeColor = Color.Black;
            buttonAddReview.Location = new Point(675, 444);
            buttonAddReview.Name = "buttonAddReview";
            buttonAddReview.Size = new Size(98, 25);
            buttonAddReview.TabIndex = 11;
            buttonAddReview.Text = "ADD REVIEW";
            buttonAddReview.UseVisualStyleBackColor = false;
            buttonAddReview.Click += buttonAddReview_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(68, 343);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(573, 150);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 322);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 13;
            label5.Text = "Reviews:";
            // 
            // AnimeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 502);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAddReview);
            Controls.Add(buttonAddWatchlist);
            Controls.Add(labelGenre);
            Controls.Add(label3);
            Controls.Add(labelStudio);
            Controls.Add(label2);
            Controls.Add(labelReleaseDate);
            Controls.Add(label1);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            Name = "AnimeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnimeDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelDescription;
        private Label label1;
        private Label labelReleaseDate;
        private Label label2;
        private Label labelStudio;
        private Label label3;
        private Label labelGenre;
        private Button buttonAddWatchlist;
        private Button buttonAddReview;
        private DataGridView dataGridView1;
        private Label label5;
    }
}