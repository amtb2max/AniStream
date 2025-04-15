namespace AniStream
{
    partial class HomeScreen
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
            label1 = new Label();
            lblUser = new Label();
            txtSearchBar = new TextBox();
            button1 = new Button();
            dataGridShowAnime = new DataGridView();
            lblAnimeTitle = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridShowAnime).BeginInit();
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
            label1.TabIndex = 0;
            label1.Text = "AniStream";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(670, 23);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(82, 19);
            lblUser.TabIndex = 1;
            lblUser.Text = "Hi, Guest!";
            lblUser.Click += lblUser_Click;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(255, 22);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.PlaceholderText = "Search anime here";
            txtSearchBar.Size = new Size(277, 23);
            txtSearchBar.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(538, 21);
            button1.Name = "button1";
            button1.Size = new Size(54, 25);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridShowAnime
            // 
            dataGridShowAnime.BackgroundColor = Color.Black;
            dataGridShowAnime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuText;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Orange;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridShowAnime.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridShowAnime.Location = new Point(21, 66);
            dataGridShowAnime.MultiSelect = false;
            dataGridShowAnime.Name = "dataGridShowAnime";
            dataGridShowAnime.ReadOnly = true;
            dataGridShowAnime.RowHeadersVisible = false;
            dataGridShowAnime.Size = new Size(305, 473);
            dataGridShowAnime.TabIndex = 4;
            dataGridShowAnime.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblAnimeTitle
            // 
            lblAnimeTitle.BackColor = Color.Black;
            lblAnimeTitle.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnimeTitle.ForeColor = Color.White;
            lblAnimeTitle.Location = new Point(358, 66);
            lblAnimeTitle.Name = "lblAnimeTitle";
            lblAnimeTitle.Size = new Size(395, 70);
            lblAnimeTitle.TabIndex = 5;
            lblAnimeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Black;
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(358, 136);
            lblDescription.MaximumSize = new Size(395, 300);
            lblDescription.MinimumSize = new Size(395, 182);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(395, 182);
            lblDescription.TabIndex = 6;
            lblDescription.Click += lblDescription_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 561);
            Controls.Add(lblDescription);
            Controls.Add(lblAnimeTitle);
            Controls.Add(dataGridShowAnime);
            Controls.Add(button1);
            Controls.Add(txtSearchBar);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Name = "HomeScreen";
            Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)dataGridShowAnime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUser;
        private TextBox txtSearchBar;
        private Button button1;
        private DataGridView dataGridShowAnime;
        private Label lblAnimeTitle;
        private Label lblDescription;
    }
}