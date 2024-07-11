namespace battelShip
{
    partial class SignIn
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
            emailLabel = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            logInButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(39, 49);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(39, 67);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(166, 23);
            emailTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(39, 139);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(166, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(39, 121);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "password";
            // 
            // logInButton
            // 
            logInButton.Location = new Point(63, 188);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(118, 49);
            logInButton.TabIndex = 4;
            logInButton.Text = "log in";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 286);
            Controls.Add(logInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Name = "SignIn";
            Text = "SignIn";
            FormClosing += SignIn_Closeing;
            Load += SignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button logInButton;
        private NotifyIcon notifyIcon1;
    }
}