namespace AniStream
{
    partial class RegisterForm
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
            labelRegisterAnAccount = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelConfirmPassword = new Label();
            textBoxConfirmPass = new TextBox();
            buttonRegister = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = SystemColors.ControlText;
            labelTitle.Font = new Font("Snap ITC", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Maroon;
            labelTitle.Location = new Point(287, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(227, 43);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "AniStream";
            // 
            // labelRegisterAnAccount
            // 
            labelRegisterAnAccount.AutoSize = true;
            labelRegisterAnAccount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegisterAnAccount.ForeColor = Color.White;
            labelRegisterAnAccount.Location = new Point(331, 87);
            labelRegisterAnAccount.Name = "labelRegisterAnAccount";
            labelRegisterAnAccount.Size = new Size(129, 17);
            labelRegisterAnAccount.TabIndex = 4;
            labelRegisterAnAccount.Text = "Register an account";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(168, 165);
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
            labelEmail.Location = new Point(170, 141);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(435, 143);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(69, 17);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(433, 165);
            textBoxUsername.MaximumSize = new Size(205, 30);
            textBoxUsername.MinimumSize = new Size(205, 30);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(205, 30);
            textBoxUsername.TabIndex = 8;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(170, 225);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(66, 17);
            labelPassword.TabIndex = 10;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(168, 249);
            textBoxPassword.MaximumSize = new Size(205, 30);
            textBoxPassword.MinimumSize = new Size(205, 30);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(205, 30);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConfirmPassword.ForeColor = Color.White;
            labelConfirmPassword.Location = new Point(435, 225);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(120, 17);
            labelConfirmPassword.TabIndex = 12;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.Location = new Point(433, 249);
            textBoxConfirmPass.MaximumSize = new Size(205, 30);
            textBoxConfirmPass.MinimumSize = new Size(205, 30);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.Size = new Size(205, 30);
            textBoxConfirmPass.TabIndex = 11;
            textBoxConfirmPass.TextChanged += textBoxConfirmPass_TextChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Maroon;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(299, 353);
            buttonRegister.MaximumSize = new Size(205, 30);
            buttonRegister.MinimumSize = new Size(205, 30);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(205, 30);
            buttonRegister.TabIndex = 13;
            buttonRegister.Text = "REGISTER";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Maroon;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 14;
            buttonBack.Text = "Go Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonRegister);
            Controls.Add(labelConfirmPassword);
            Controls.Add(textBoxConfirmPass);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelRegisterAnAccount);
            Controls.Add(labelTitle);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelRegisterAnAccount;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelConfirmPassword;
        private TextBox textBoxConfirmPass;
        private Button buttonRegister;
        private Button buttonBack;
    }
}