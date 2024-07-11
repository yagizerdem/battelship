
using static Supabase.Realtime.PostgresChanges.PostgresChangesOptions;

namespace battelShip
{
    public partial class Home : Form
    {
        IDatabase database;
        public Home(IDatabase database)
        {
            InitializeComponent();
            this.database = database;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Text = "Toast Notification Example";
        }
        private void Home_Closeing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose(); // Clean up NotifyIcon
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp(database);
            signUpForm.ShowDialog();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignIn singinform = new SignIn(database);
            singinform.ShowDialog();
        }

        private async void PlayButton_Click(object sender, EventArgs e)
        {
            Supabase.Gotrue.User? session = database.GetSession();
            if(session == null) //  user is not logged in 
            {
                notifyIcon1.ShowBalloonTip(3000, "Error", "user is not logged in", ToolTipIcon.Error);
                return;
            }
            Play playForm = new Play(database);
            playForm.ShowDialog();  

        }
    }
}
