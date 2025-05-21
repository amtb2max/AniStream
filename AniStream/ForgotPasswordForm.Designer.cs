namespace AniStream
{
    partial class ForgotPasswordForm
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
            labelTitle = new Label();
            labelInstruction = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            buttonLogin = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = SystemColors.ControlText;
            labelTitle.Font = new Font("Snap ITC", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Maroon;
            labelTitle.Location = new Point(287, 43);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(227, 43);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "AniStream";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelInstruction
            // 
            labelInstruction.AutoSize = true;
            labelInstruction.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInstruction.ForeColor = Color.White;
            labelInstruction.Location = new Point(209, 95);
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size(358, 17);
            labelInstruction.TabIndex = 4;
            labelInstruction.Text = "Please enter you email address to change your password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(298, 185);
            textBoxEmail.MaximumSize = new Size(205, 30);
            textBoxEmail.MinimumSize = new Size(205, 30);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(205, 30);
            textBoxEmail.TabIndex = 5;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(298, 161);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Maroon;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(298, 264);
            buttonLogin.MaximumSize = new Size(205, 30);
            buttonLogin.MinimumSize = new Size(205, 30);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(205, 30);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "PROCEED";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Maroon;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(23, 22);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 13;
            buttonBack.Text = "Go Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonLogin);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelInstruction);
            Controls.Add(labelTitle);
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelInstruction;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Button buttonLogin;
        private Button buttonBack;
    }
}