using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battelShip
{
    public partial class SignIn : Form
    {
        private IDatabase database;
        public SignIn(IDatabase database)
        {
            InitializeComponent();
            this.database = database;
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Information;
        }
        private void SignIn_Closeing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose(); // Clean up NotifyIcon
        }

        private async void logInButton_Click(object sender, EventArgs e)
        {
            string email = this.emailTextBox.Text;
            string password = this.passwordTextBox.Text;

            try
            {
                Supabase.Gotrue.Session? session = await database.SignIn(email, password);
                // successfull log in
                notifyIcon1.ShowBalloonTip(3000, "Suceess", "user log in successfull ...", ToolTipIcon.Info);
                this.Dispose();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(3000, "Error", ex.Message, ToolTipIcon.Error);
            }


        }
    }
}
