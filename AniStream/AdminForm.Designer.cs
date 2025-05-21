namespace AniStream
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            txtSearchBar = new TextBox();
            button1 = new Button();
            lblUser = new Label();
            dataGridView1 = new DataGridView();
            buttonAnime = new Button();
            buttonUsers = new Button();
            buttonReviews = new Button();
            buttonAddAnime = new Button();
            buttonREmoveAnime = new Button();
            buttonUpdate = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            labelTable = new Label();
            buttonLogs = new Button();
            buttonExportToExcel = new Button();
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
            label1.TabIndex = 2;
            label1.Text = "AniStream";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlText;
            label2.Font = new Font("Snap ITC", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(232, 9);
            label2.Name = "label2";
            label2.Size = new Size(163, 43);
            label2.TabIndex = 3;
            label2.Text = "ADMIN";
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(412, 21);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.PlaceholderText = "Search here";
            txtSearchBar.Size = new Size(289, 23);
            txtSearchBar.TabIndex = 4;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(707, 19);
            button1.Name = "button1";
            button1.Size = new Size(54, 25);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(801, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(88, 19);
            lblUser.TabIndex = 6;
            lblUser.Text = "Hi, ADMIN!";
            lblUser.Click += lblUser_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Maroon;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Black;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.Maroon;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(752, 422);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonAnime
            // 
            buttonAnime.BackColor = Color.Goldenrod;
            buttonAnime.FlatAppearance.BorderSize = 0;
            buttonAnime.FlatStyle = FlatStyle.Flat;
            buttonAnime.Location = new Point(795, 88);
            buttonAnime.Name = "buttonAnime";
            buttonAnime.Size = new Size(98, 25);
            buttonAnime.TabIndex = 9;
            buttonAnime.Text = "Anime";
            buttonAnime.UseVisualStyleBackColor = false;
            buttonAnime.Click += buttonAnime_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.Goldenrod;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Location = new Point(795, 129);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(98, 25);
            buttonUsers.TabIndex = 10;
            buttonUsers.Text = "Users";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonReviews
            // 
            buttonReviews.BackColor = Color.Goldenrod;
            buttonReviews.FlatAppearance.BorderSize = 0;
            buttonReviews.FlatStyle = FlatStyle.Flat;
            buttonReviews.Location = new Point(795, 172);
            buttonReviews.Name = "buttonReviews";
            buttonReviews.Size = new Size(98, 25);
            buttonReviews.TabIndex = 11;
            buttonReviews.Text = "Reviews";
            buttonReviews.UseVisualStyleBackColor = false;
            buttonReviews.Click += buttonReviews_Click;
            // 
            // buttonAddAnime
            // 
            buttonAddAnime.BackColor = Color.Goldenrod;
            buttonAddAnime.FlatAppearance.BorderSize = 0;
            buttonAddAnime.FlatStyle = FlatStyle.Flat;
            buttonAddAnime.Location = new Point(795, 314);
            buttonAddAnime.Name = "buttonAddAnime";
            buttonAddAnime.Size = new Size(98, 25);
            buttonAddAnime.TabIndex = 12;
            buttonAddAnime.Text = "Add Anime";
            buttonAddAnime.UseVisualStyleBackColor = false;
            buttonAddAnime.Click += buttonAddAnime_Click;
            // 
            // buttonREmoveAnime
            // 
            buttonREmoveAnime.BackColor = Color.Goldenrod;
            buttonREmoveAnime.FlatAppearance.BorderSize = 0;
            buttonREmoveAnime.FlatStyle = FlatStyle.Flat;
            buttonREmoveAnime.Location = new Point(795, 354);
            buttonREmoveAnime.Name = "buttonREmoveAnime";
            buttonREmoveAnime.Size = new Size(98, 25);
            buttonREmoveAnime.TabIndex = 13;
            buttonREmoveAnime.Text = "Remove Anime";
            buttonREmoveAnime.UseVisualStyleBackColor = false;
            buttonREmoveAnime.Click += buttonREmoveAnime_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Goldenrod;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Location = new Point(795, 393);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(98, 25);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Update Anime";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(795, 214);
            button2.Name = "button2";
            button2.Size = new Size(98, 25);
            button2.TabIndex = 15;
            button2.Text = "Anime Ratings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(795, 255);
            button3.Name = "button3";
            button3.Size = new Size(98, 42);
            button3.TabIndex = 16;
            button3.Text = "Anime Popularity";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(795, 485);
            button4.Name = "button4";
            button4.Size = new Size(98, 25);
            button4.TabIndex = 17;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // labelTable
            // 
            labelTable.AutoSize = true;
            labelTable.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTable.ForeColor = Color.White;
            labelTable.Location = new Point(12, 66);
            labelTable.Name = "labelTable";
            labelTable.Size = new Size(117, 19);
            labelTable.TabIndex = 18;
            labelTable.Text = "ANIME TABLE";
            labelTable.Click += labelTable_Click;
            // 
            // buttonLogs
            // 
            buttonLogs.BackColor = Color.Goldenrod;
            buttonLogs.FlatAppearance.BorderSize = 0;
            buttonLogs.FlatStyle = FlatStyle.Flat;
            buttonLogs.Location = new Point(795, 432);
            buttonLogs.Name = "buttonLogs";
            buttonLogs.Size = new Size(98, 25);
            buttonLogs.TabIndex = 19;
            buttonLogs.Text = "Logs";
            buttonLogs.UseVisualStyleBackColor = false;
            buttonLogs.Click += buttonLogs_Click;
            // 
            // buttonExportToExcel
            // 
            buttonExportToExcel.BackColor = Color.LimeGreen;
            buttonExportToExcel.FlatAppearance.BorderSize = 0;
            buttonExportToExcel.FlatStyle = FlatStyle.Flat;
            buttonExportToExcel.ForeColor = Color.Black;
            buttonExportToExcel.Location = new Point(673, 63);
            buttonExportToExcel.Name = "buttonExportToExcel";
            buttonExportToExcel.Size = new Size(93, 23);
            buttonExportToExcel.TabIndex = 20;
            buttonExportToExcel.Text = "Export to Excel";
            buttonExportToExcel.UseVisualStyleBackColor = false;
            buttonExportToExcel.Click += buttonExportToExcel_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(931, 522);
            Controls.Add(buttonExportToExcel);
            Controls.Add(buttonLogs);
            Controls.Add(labelTable);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonREmoveAnime);
            Controls.Add(buttonAddAnime);
            Controls.Add(buttonReviews);
            Controls.Add(buttonUsers);
            Controls.Add(buttonAnime);
            Controls.Add(dataGridView1);
            Controls.Add(lblUser);
            Controls.Add(button1);
            Controls.Add(txtSearchBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchBar;
        private Button button1;
        private Label lblUser;
        private DataGridView dataGridView1;
        private Button buttonAnime;
        private Button buttonUsers;
        private Button buttonReviews;
        private Button buttonAddAnime;
        private Button buttonREmoveAnime;
        private Button buttonUpdate;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label labelTable;
        private Button buttonLogs;
        private Button buttonExportToExcel;
    }
}