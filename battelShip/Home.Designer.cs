namespace battelShip
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            SignUpButton = new Button();
            SignInButton = new Button();
            PlayButton = new Button();
            ProfileButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(67, 34);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(98, 32);
            SignUpButton.TabIndex = 0;
            SignUpButton.Text = "SignUp";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(67, 86);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(98, 32);
            SignInButton.TabIndex = 1;
            SignInButton.Text = "SignIn";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // PlayButton
            // 
            PlayButton.Location = new Point(67, 136);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(98, 32);
            PlayButton.TabIndex = 2;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // ProfileButton
            // 
            ProfileButton.Location = new Point(67, 194);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(98, 32);
            ProfileButton.TabIndex = 3;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(228, 283);
            Controls.Add(ProfileButton);
            Controls.Add(PlayButton);
            Controls.Add(SignInButton);
            Controls.Add(SignUpButton);
            Name = "Home";
            Text = "Form1";
            FormClosing += Home_Closeing;
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button SignUpButton;
        private Button SignInButton;
        private Button PlayButton;
        private Button ProfileButton;
        private NotifyIcon notifyIcon1;
    }
}
