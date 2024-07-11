namespace battelShip
{
    partial class Game
    {

        private Label dynamicLabel;
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Game";


            // Create and configure the label
            this.dynamicLabel = new Label();
            this.dynamicLabel.AutoSize = true;
            this.dynamicLabel.Location = new System.Drawing.Point(20, 20);
            this.dynamicLabel.Text = "Dynamic Label Text";
            this.Controls.Add(this.dynamicLabel); // Add label to the form's controls collection
        }

        #endregion
    }
}