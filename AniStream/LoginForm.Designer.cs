namespace AniStream
{
    partial class LoginForm
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
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            linkLabelForgotPassword = new LinkLabel();
            buttonLogin = new Button();
            linkLabelRegister = new LinkLabel();
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
            labelTitle.TabIndex = 1;
            labelTitle.Text = "AniStream";
            labelTitle.Click += label1_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(296, 140);
            textBoxEmail.MaximumSize = new Size(205, 30);
            textBoxEmail.MinimumSize = new Size(205, 30);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(205, 30);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.TextChanged += textBox1_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(294, 116);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(294, 197);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(66, 17);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(296, 217);
            textBoxPassword.MaximumSize = new Size(205, 30);
            textBoxPassword.MinimumSize = new Size(205, 30);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(205, 30);
            textBoxPassword.TabIndex = 5;
            // 
            // linkLabelForgotPassword
            // 
            linkLabelForgotPassword.AutoSize = true;
            linkLabelForgotPassword.Location = new Point(401, 259);
            linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            linkLabelForgotPassword.Size = new Size(100, 15);
            linkLabelForgotPassword.TabIndex = 6;
            linkLabelForgotPassword.TabStop = true;
            linkLabelForgotPassword.Text = "Forgot Password?";
            linkLabelForgotPassword.LinkClicked += linkLabelForgotPassword_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Maroon;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(296, 291);
            buttonLogin.MaximumSize = new Size(205, 30);
            buttonLogin.MinimumSize = new Size(205, 30);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(205, 30);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkLabelRegister
            // 
            linkLabelRegister.AutoSize = true;
            linkLabelRegister.Location = new Point(297, 369);
            linkLabelRegister.Name = "linkLabelRegister";
            linkLabelRegister.Size = new Size(202, 15);
            linkLabelRegister.TabIndex = 8;
            linkLabelRegister.TabStop = true;
            linkLabelRegister.Text = "Don't have an account? Register now";
            linkLabelRegister.LinkClicked += linkLabelRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabelRegister);
            Controls.Add(buttonLogin);
            Controls.Add(linkLabelForgotPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelTitle);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private LinkLabel linkLabelForgotPassword;
        private Button buttonLogin;
        private LinkLabel linkLabelRegister;
    }
}