namespace AniStream
{
    partial class InputNewPasswordForm
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
            labelPassword = new Label();
            textBoxNewPass = new TextBox();
            label1ReEnterPass = new Label();
            textBox1 = new TextBox();
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
            labelTitle.TabIndex = 3;
            labelTitle.Text = "AniStream";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelInstruction
            // 
            labelInstruction.AutoSize = true;
            labelInstruction.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInstruction.ForeColor = Color.White;
            labelInstruction.Location = new Point(294, 95);
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size(206, 17);
            labelInstruction.TabIndex = 5;
            labelInstruction.Text = "Please enter your new password";
            labelInstruction.Click += labelInstruction_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(298, 144);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(97, 17);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "New Password";
            labelPassword.Click += labelEmail_Click;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(298, 168);
            textBoxNewPass.MaximumSize = new Size(205, 30);
            textBoxNewPass.MinimumSize = new Size(205, 30);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(205, 30);
            textBoxNewPass.TabIndex = 8;
            textBoxNewPass.TextChanged += textBoxNewPass_TextChanged;
            // 
            // label1ReEnterPass
            // 
            label1ReEnterPass.AutoSize = true;
            label1ReEnterPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1ReEnterPass.ForeColor = Color.White;
            label1ReEnterPass.Location = new Point(298, 220);
            label1ReEnterPass.Name = "label1ReEnterPass";
            label1ReEnterPass.Size = new Size(122, 17);
            label1ReEnterPass.TabIndex = 9;
            label1ReEnterPass.Text = "Re-enter Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 245);
            textBox1.MaximumSize = new Size(205, 30);
            textBox1.MinimumSize = new Size(205, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 30);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Maroon;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(298, 313);
            buttonLogin.MaximumSize = new Size(205, 30);
            buttonLogin.MinimumSize = new Size(205, 30);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(205, 30);
            buttonLogin.TabIndex = 11;
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
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Go Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // InputNewPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonLogin);
            Controls.Add(textBox1);
            Controls.Add(label1ReEnterPass);
            Controls.Add(textBoxNewPass);
            Controls.Add(labelPassword);
            Controls.Add(labelInstruction);
            Controls.Add(labelTitle);
            Name = "InputNewPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputNewPasswordForm";
            Load += InputNewPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelInstruction;
        private Label labelPassword;
        private TextBox textBoxNewPass;
        private Label label1ReEnterPass;
        private TextBox textBox1;
        private Button buttonLogin;
        private Button buttonBack;
    }
}