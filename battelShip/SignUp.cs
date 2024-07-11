using Postgrest.Responses;
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
    public partial class SignUp : Form
    {
        private IDatabase database;
        public SignUp(IDatabase database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Information;
        }
        private void SignUp_Closeing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose(); // Clean up NotifyIcon
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string userName = this.userNameTextBox.Text;
            string email = this.emailTextBox.Text;  
            string password = this.passwordTextBox.Text;

            try
            {
                Supabase.Gotrue.Session? session = await database.SignUp(email, password);
                string? userid = session?.User?.Id;
                if (userid == null) return;

                // set user_name on profiles table
                Profiles userProfile = await database.GetProfileById(userid);
                if(userProfile == null) return;

                userProfile.UserName  = userName;   
                await database.UpdateData(userProfile);

                // successfull register 
                notifyIcon1.ShowBalloonTip(3000, "Suceess", "user register successfull ...", ToolTipIcon.Info);
                this.Dispose();
            }catch(Exception ex)
            {

                this.notifyIcon1.Text = ex.Message;
                notifyIcon1.ShowBalloonTip(3000, "Error", ex.Message, ToolTipIcon.Error);
            }


        }
    }
}
