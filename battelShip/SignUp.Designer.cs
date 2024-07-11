namespace battelShip
{
    partial class SignUp
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
            components = new System.ComponentModel.Container();
            ProfileNameLabel = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            EmailLabel = new Label();
            registerButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // ProfileNameLabel
            // 
            ProfileNameLabel.AutoSize = true;
            ProfileNameLabel.ForeColor = Color.FromArgb(0, 59, 70);
            ProfileNameLabel.Location = new Point(41, 49);
            ProfileNameLabel.Name = "ProfileNameLabel";
            ProfileNameLabel.Size = new Size(92, 15);
            ProfileNameLabel.TabIndex = 0;
            ProfileNameLabel.Text = "Enter user name";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(39, 67);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(154, 23);
            userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(41, 213);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(154, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.FromArgb(0, 59, 70);
            passwordLabel.Location = new Point(41, 195);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Enter password";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(41, 138);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(154, 23);
            emailTextBox.TabIndex = 5;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.ForeColor = Color.FromArgb(0, 59, 70);
            EmailLabel.Location = new Point(41, 120);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(66, 15);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Enter email";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(68, 258);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(90, 48);
            registerButton.TabIndex = 6;
            registerButton.Text = "register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(230, 333);
            Controls.Add(registerButton);
            Controls.Add(emailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(ProfileNameLabel);
            Name = "SignUp";
            Text = "Form1";
            FormClosing += SignUp_Closeing;
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProfileNameLabel;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox emailTextBox;
        private Label EmailLabel;
        private Button registerButton;
        private NotifyIcon notifyIcon1;
    }
}