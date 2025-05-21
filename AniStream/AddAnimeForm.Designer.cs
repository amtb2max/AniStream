namespace AniStream
{
    partial class AddAnimeForm
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
            labelTable = new Label();
            textBoxTittle = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBoxStudio = new TextBox();
            label3 = new Label();
            textBoxDescription = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            label5 = new Label();
            buttonLogin = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelTable
            // 
            labelTable.AutoSize = true;
            labelTable.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTable.ForeColor = Color.White;
            labelTable.Location = new Point(243, 23);
            labelTable.Name = "labelTable";
            labelTable.Size = new Size(98, 19);
            labelTable.TabIndex = 19;
            labelTable.Text = "ADD ANIME";
            labelTable.Click += labelTable_Click;
            // 
            // textBoxTittle
            // 
            textBoxTittle.Location = new Point(253, 85);
            textBoxTittle.MaximumSize = new Size(205, 30);
            textBoxTittle.MinimumSize = new Size(205, 30);
            textBoxTittle.Name = "textBoxTittle";
            textBoxTittle.Size = new Size(205, 30);
            textBoxTittle.TabIndex = 20;
            textBoxTittle.TextChanged += textBoxTittle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 85);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 21;
            label1.Text = "TITLE";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(253, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(205, 23);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(93, 167);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 23;
            label2.Text = "Release Date";
            // 
            // textBoxStudio
            // 
            textBoxStudio.Location = new Point(253, 228);
            textBoxStudio.MaximumSize = new Size(205, 30);
            textBoxStudio.MinimumSize = new Size(205, 30);
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.Size = new Size(205, 30);
            textBoxStudio.TabIndex = 24;
            textBoxStudio.TextChanged += textBoxStudio_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 228);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 25;
            label3.Text = "Studio";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(253, 294);
            textBoxDescription.MaximumSize = new Size(205, 550);
            textBoxDescription.MinimumSize = new Size(205, 100);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(205, 100);
            textBoxDescription.TabIndex = 26;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(93, 294);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 27;
            label4.Text = "Description";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Black;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(37, 448);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Action";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Black;
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(147, 448);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(81, 19);
            checkBox2.TabIndex = 29;
            checkBox2.Text = "Adventure";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Black;
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(253, 448);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(71, 19);
            checkBox3.TabIndex = 30;
            checkBox3.Text = "Comedy";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Black;
            checkBox4.ForeColor = Color.White;
            checkBox4.Location = new Point(357, 448);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(61, 19);
            checkBox4.TabIndex = 31;
            checkBox4.Text = "Drama";
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Black;
            checkBox5.ForeColor = Color.White;
            checkBox5.Location = new Point(471, 448);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(66, 19);
            checkBox5.TabIndex = 32;
            checkBox5.Text = "Fantasy";
            checkBox5.UseVisualStyleBackColor = false;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.Black;
            checkBox6.ForeColor = Color.White;
            checkBox6.Location = new Point(471, 484);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(62, 19);
            checkBox6.TabIndex = 37;
            checkBox6.Text = "Thriller";
            checkBox6.UseVisualStyleBackColor = false;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = Color.Black;
            checkBox7.ForeColor = Color.White;
            checkBox7.Location = new Point(357, 484);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(55, 19);
            checkBox7.TabIndex = 36;
            checkBox7.Text = "Sci-Fi";
            checkBox7.UseVisualStyleBackColor = false;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.BackColor = Color.Black;
            checkBox8.ForeColor = Color.White;
            checkBox8.Location = new Point(253, 484);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(76, 19);
            checkBox8.TabIndex = 35;
            checkBox8.Text = "Romance";
            checkBox8.UseVisualStyleBackColor = false;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.BackColor = Color.Black;
            checkBox9.ForeColor = Color.White;
            checkBox9.Location = new Point(147, 484);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(68, 19);
            checkBox9.TabIndex = 34;
            checkBox9.Text = "Mystery";
            checkBox9.UseVisualStyleBackColor = false;
            checkBox9.CheckedChanged += checkBox9_CheckedChanged;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.BackColor = Color.Black;
            checkBox10.ForeColor = Color.White;
            checkBox10.Location = new Point(37, 484);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(61, 19);
            checkBox10.TabIndex = 33;
            checkBox10.Text = "Horror";
            checkBox10.UseVisualStyleBackColor = false;
            checkBox10.CheckedChanged += checkBox10_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 408);
            label5.Name = "label5";
            label5.Size = new Size(130, 19);
            label5.TabIndex = 38;
            label5.Text = "Choose a genre";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Maroon;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(193, 558);
            buttonLogin.MaximumSize = new Size(205, 30);
            buttonLogin.MinimumSize = new Size(205, 30);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(205, 30);
            buttonLogin.TabIndex = 39;
            buttonLogin.Text = "ADD ANIME";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Maroon;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(23, 19);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 40;
            buttonBack.Text = "Go Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // AddAnimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(595, 610);
            Controls.Add(buttonBack);
            Controls.Add(buttonLogin);
            Controls.Add(label5);
            Controls.Add(checkBox6);
            Controls.Add(checkBox7);
            Controls.Add(checkBox8);
            Controls.Add(checkBox9);
            Controls.Add(checkBox10);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(textBoxDescription);
            Controls.Add(label3);
            Controls.Add(textBoxStudio);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBoxTittle);
            Controls.Add(labelTable);
            Name = "AddAnimeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAnimeForm";
            Load += AddAnimeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTable;
        private TextBox textBoxTittle;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBoxStudio;
        private Label label3;
        private TextBox textBoxDescription;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private Label label5;
        private Button buttonLogin;
        private Button buttonBack;
    }
}