namespace battelShip
{
    partial class Play
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
            creatroombutton = new Button();
            joinroombutton = new Button();
            joinroomTextBox = new TextBox();
            joinroomlabel = new Label();
            roomidlabel = new Label();
            SuspendLayout();
            // 
            // creatroombutton
            // 
            creatroombutton.Location = new Point(211, 12);
            creatroombutton.Name = "creatroombutton";
            creatroombutton.Size = new Size(117, 43);
            creatroombutton.TabIndex = 0;
            creatroombutton.Text = "create room";
            creatroombutton.UseVisualStyleBackColor = true;
            creatroombutton.Click += creatroombutton_Click;
            // 
            // joinroombutton
            // 
            joinroombutton.Location = new Point(212, 151);
            joinroombutton.Name = "joinroombutton";
            joinroombutton.Size = new Size(116, 39);
            joinroombutton.TabIndex = 1;
            joinroombutton.Text = "join room";
            joinroombutton.UseVisualStyleBackColor = true;
            joinroombutton.Click += joinroombutton_Click;
            // 
            // joinroomTextBox
            // 
            joinroomTextBox.Location = new Point(122, 122);
            joinroomTextBox.Name = "joinroomTextBox";
            joinroomTextBox.Size = new Size(323, 23);
            joinroomTextBox.TabIndex = 2;
            // 
            // joinroomlabel
            // 
            joinroomlabel.AutoSize = true;
            joinroomlabel.Location = new Point(201, 104);
            joinroomlabel.Name = "joinroomlabel";
            joinroomlabel.Size = new Size(148, 15);
            joinroomlabel.TabIndex = 3;
            joinroomlabel.Text = "enter room id to join room";
            // 
            // roomidlabel
            // 
            roomidlabel.AutoSize = true;
            roomidlabel.Location = new Point(247, 62);
            roomidlabel.Name = "roomidlabel";
            roomidlabel.Size = new Size(0, 15);
            roomidlabel.TabIndex = 4;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 202);
            Controls.Add(roomidlabel);
            Controls.Add(joinroomlabel);
            Controls.Add(joinroomTextBox);
            Controls.Add(joinroombutton);
            Controls.Add(creatroombutton);
            Name = "Play";
            Text = "Play";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button creatroombutton;
        private Button joinroombutton;
        private TextBox joinroomTextBox;
        private Label joinroomlabel;
        private Label roomidlabel;
    }
}