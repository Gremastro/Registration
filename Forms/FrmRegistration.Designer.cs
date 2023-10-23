namespace Registration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GetStartedLabel = new Label();
            UsernameLabel = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            PasswordLabel = new Label();
            txtComPassword = new TextBox();
            ConfirmPasswordLabel = new Label();
            CheckBxShowPass = new CheckBox();
            RegisterButton = new Button();
            ClearButton = new Button();
            AlreadyHaveAnAccountLabel = new Label();
            BackToLogInLabel = new Label();
            SuspendLayout();
            // 
            // GetStartedLabel
            // 
            GetStartedLabel.AutoSize = true;
            GetStartedLabel.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            GetStartedLabel.ForeColor = Color.FromArgb(116, 86, 174);
            GetStartedLabel.Location = new Point(28, 68);
            GetStartedLabel.Name = "GetStartedLabel";
            GetStartedLabel.Size = new Size(194, 34);
            GetStartedLabel.TabIndex = 0;
            GetStartedLabel.Text = "Get Started";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(40, 125);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(89, 23);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(40, 151);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(40, 215);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(40, 189);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(84, 23);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(40, 278);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '•';
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 6;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(40, 252);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(155, 23);
            ConfirmPasswordLabel.TabIndex = 5;
            ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // CheckBxShowPass
            // 
            CheckBxShowPass.AutoSize = true;
            CheckBxShowPass.Cursor = Cursors.Hand;
            CheckBxShowPass.FlatStyle = FlatStyle.Flat;
            CheckBxShowPass.Location = new Point(105, 321);
            CheckBxShowPass.Name = "CheckBxShowPass";
            CheckBxShowPass.Size = new Size(151, 27);
            CheckBxShowPass.TabIndex = 7;
            CheckBxShowPass.Text = "Show Password";
            CheckBxShowPass.UseVisualStyleBackColor = true;
            CheckBxShowPass.CheckedChanged += CheckBxShowPass_CheckedChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(116, 86, 174);
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(40, 363);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(216, 35);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "REGISTER";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.White;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.ForeColor = Color.FromArgb(116, 86, 174);
            ClearButton.Location = new Point(40, 413);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(216, 35);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // AlreadyHaveAnAccountLabel
            // 
            AlreadyHaveAnAccountLabel.AutoSize = true;
            AlreadyHaveAnAccountLabel.Location = new Point(40, 467);
            AlreadyHaveAnAccountLabel.Name = "AlreadyHaveAnAccountLabel";
            AlreadyHaveAnAccountLabel.Size = new Size(214, 23);
            AlreadyHaveAnAccountLabel.TabIndex = 10;
            AlreadyHaveAnAccountLabel.Text = "Already Have An Account";
            // 
            // BackToLogInLabel
            // 
            BackToLogInLabel.AutoSize = true;
            BackToLogInLabel.Cursor = Cursors.Hand;
            BackToLogInLabel.ForeColor = Color.FromArgb(116, 86, 174);
            BackToLogInLabel.Location = new Point(72, 490);
            BackToLogInLabel.Name = "BackToLogInLabel";
            BackToLogInLabel.Size = new Size(131, 23);
            BackToLogInLabel.TabIndex = 11;
            BackToLogInLabel.Text = "Back to LOG IN";
            BackToLogInLabel.Click += BackToLogInLabel_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(BackToLogInLabel);
            Controls.Add(AlreadyHaveAnAccountLabel);
            Controls.Add(ClearButton);
            Controls.Add(RegisterButton);
            Controls.Add(CheckBxShowPass);
            Controls.Add(txtComPassword);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(txtPassword);
            Controls.Add(PasswordLabel);
            Controls.Add(txtUsername);
            Controls.Add(UsernameLabel);
            Controls.Add(GetStartedLabel);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GetStartedLabel;
        private Label UsernameLabel;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label PasswordLabel;
        private TextBox txtComPassword;
        private Label ConfirmPasswordLabel;
        private CheckBox CheckBxShowPass;
        private Button RegisterButton;
        private Button ClearButton;
        private Label AlreadyHaveAnAccountLabel;
        private Label BackToLogInLabel;
    }
}