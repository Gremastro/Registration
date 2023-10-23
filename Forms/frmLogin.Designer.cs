namespace Registration
{
    partial class FrmLogin
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
            CreateAccountLabel = new Label();
            DontHaveAnAccountLabel = new Label();
            ClearButton = new Button();
            LogInButton = new Button();
            CheckBxShowPass = new CheckBox();
            txtPassword = new TextBox();
            PasswordLabel = new Label();
            txtUsername = new TextBox();
            UsernameLabel = new Label();
            GetStartedLabel = new Label();
            SuspendLayout();
            // 
            // CreateAccountLabel
            // 
            CreateAccountLabel.AutoSize = true;
            CreateAccountLabel.Cursor = Cursors.Hand;
            CreateAccountLabel.ForeColor = Color.FromArgb(116, 86, 174);
            CreateAccountLabel.Location = new Point(118, 430);
            CreateAccountLabel.Name = "CreateAccountLabel";
            CreateAccountLabel.Size = new Size(132, 23);
            CreateAccountLabel.TabIndex = 23;
            CreateAccountLabel.Text = "Create Account";
            CreateAccountLabel.Click += CreateAccountLabel_Click;
            // 
            // DontHaveAnAccountLabel
            // 
            DontHaveAnAccountLabel.AutoSize = true;
            DontHaveAnAccountLabel.Location = new Point(89, 407);
            DontHaveAnAccountLabel.Name = "DontHaveAnAccountLabel";
            DontHaveAnAccountLabel.Size = new Size(196, 23);
            DontHaveAnAccountLabel.TabIndex = 22;
            DontHaveAnAccountLabel.Text = "Don't Have An Account";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.White;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.ForeColor = Color.FromArgb(116, 86, 174);
            ClearButton.Location = new Point(78, 354);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(216, 35);
            ClearButton.TabIndex = 21;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(116, 86, 174);
            LogInButton.Cursor = Cursors.Hand;
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(79, 303);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(216, 35);
            LogInButton.TabIndex = 20;
            LogInButton.Text = "LOG IN";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // CheckBxShowPass
            // 
            CheckBxShowPass.AutoSize = true;
            CheckBxShowPass.Cursor = Cursors.Hand;
            CheckBxShowPass.FlatStyle = FlatStyle.Flat;
            CheckBxShowPass.Location = new Point(143, 260);
            CheckBxShowPass.Name = "CheckBxShowPass";
            CheckBxShowPass.Size = new Size(151, 27);
            CheckBxShowPass.TabIndex = 19;
            CheckBxShowPass.Text = "Show Password";
            CheckBxShowPass.UseVisualStyleBackColor = true;
            CheckBxShowPass.CheckedChanged += CheckBxShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(79, 226);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 16;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(79, 200);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(84, 23);
            PasswordLabel.TabIndex = 15;
            PasswordLabel.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(79, 162);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 14;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(79, 136);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(89, 23);
            UsernameLabel.TabIndex = 13;
            UsernameLabel.Text = "Username";
            // 
            // GetStartedLabel
            // 
            GetStartedLabel.AutoSize = true;
            GetStartedLabel.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            GetStartedLabel.ForeColor = Color.FromArgb(116, 86, 174);
            GetStartedLabel.Location = new Point(67, 68);
            GetStartedLabel.Name = "GetStartedLabel";
            GetStartedLabel.Size = new Size(194, 34);
            GetStartedLabel.TabIndex = 12;
            GetStartedLabel.Text = "Get Started";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(361, 562);
            Controls.Add(CreateAccountLabel);
            Controls.Add(DontHaveAnAccountLabel);
            Controls.Add(ClearButton);
            Controls.Add(LogInButton);
            Controls.Add(CheckBxShowPass);
            Controls.Add(txtPassword);
            Controls.Add(PasswordLabel);
            Controls.Add(txtUsername);
            Controls.Add(UsernameLabel);
            Controls.Add(GetStartedLabel);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateAccountLabel;
        private Label DontHaveAnAccountLabel;
        private Button ClearButton;
        private Button LogInButton;
        private CheckBox CheckBxShowPass;
        private TextBox txtPassword;
        private Label PasswordLabel;
        private TextBox txtUsername;
        private Label UsernameLabel;
        private Label GetStartedLabel;
    }
}