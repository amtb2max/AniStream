namespace AniStream
{
    partial class AddReviewForm
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
            label5 = new Label();
            label1 = new Label();
            comboBoxRating = new ComboBox();
            textBoxComment = new TextBox();
            label2 = new Label();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(232, 34);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 14;
            label5.Text = "Add Review";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 96);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 15;
            label1.Text = "Rating";
            label1.Click += label1_Click;
            // 
            // comboBoxRating
            // 
            comboBoxRating.FormattingEnabled = true;
            comboBoxRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxRating.Location = new Point(204, 90);
            comboBoxRating.Name = "comboBoxRating";
            comboBoxRating.Size = new Size(180, 23);
            comboBoxRating.TabIndex = 16;
            comboBoxRating.SelectedIndexChanged += comboBoxRating_SelectedIndexChanged;
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(204, 164);
            textBoxComment.Multiline = true;
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(180, 76);
            textBoxComment.TabIndex = 17;
            textBoxComment.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 170);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 18;
            label2.Text = "Comment";
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Maroon;
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(213, 279);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(98, 25);
            buttonSubmit.TabIndex = 19;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // AddReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(555, 316);
            Controls.Add(buttonSubmit);
            Controls.Add(label2);
            Controls.Add(textBoxComment);
            Controls.Add(comboBoxRating);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "AddReviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddReviewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private ComboBox comboBoxRating;
        private TextBox textBoxComment;
        private Label label2;
        private Button buttonSubmit;
    }
}