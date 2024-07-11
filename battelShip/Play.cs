using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Play : Form
    {
        private readonly IDatabase database;
        public Play(IDatabase database)
        {
            InitializeComponent();
            this.database = database;
        }

        private async void creatroombutton_Click(object sender, EventArgs e)
        {
            Supabase.Gotrue.User session = database.GetSession();
            string? userid = session.Id;
            if (userid == null) return;

            Room model = new Room();
            model.roomstatus = false;
            model.player1id = userid!; // player 1 is room creator 


            Room roomFromDb = await this.database.CreateRoom(model);
            this.roomidlabel.Text = $"created room id is {roomFromDb.Id} - send room id to other player to join ... ";


        }

        private  async void joinroombutton_Click(object sender, EventArgs e)
        {
            string roomid = this.joinroomTextBox.Text;
            if (roomid == null) return;
            Room? roomFromDb = await database.GetRoomById(roomid);

            Supabase.Gotrue.User session = database.GetSession();
            string? userid = session.Id;
            if (userid == null) return;

            if (roomFromDb.player1id == userid) return; // already in room
            if (roomFromDb.player2id != null) return; // room has already match

            roomFromDb.roomstatus = true; // set room match mode
            roomFromDb.player2id = userid!; // set opponent 
            

            await database.UpdateData<Room>(roomFromDb);


            // is success  go to game room
            Game game = new Game();
            game.ShowDialog();
        }
    }
}
