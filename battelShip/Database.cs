using Postgrest;
using Postgrest.Responses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Postgrest.Constants;
using static Postgrest.QueryOptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace battelShip
{
    public class Database : IDatabase
    {
        public Supabase.Client supabase { get; set; } = null!;
        public bool initilazed { get; set; } = false;
        public async Task Initilize()
        {
            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };
            this.supabase = new Supabase.Client(ConfigurationManager.AppSettings["SUPABASE_URL"], ConfigurationManager.AppSettings["SUPABASE_KEY"], options);
            await this.supabase.InitializeAsync();
            this.initilazed = true;
        }


        public async Task<Supabase.Gotrue.Session?> SignUp(string email, string password)
        {
            try
            {
                var session = await this.supabase.Auth.SignUp(email, password);
                return session;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Supabase.Gotrue.Session?> SignIn(string email, string password)
        {
            try
            {
                var session = await this.supabase.Auth.SignIn(email, password);
                return session;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Supabase.Gotrue.User? GetSession()
        {
            return this.supabase.Auth.CurrentUser;
        }

        public async Task UpsertData<T>(T model)
        {
            if (model == null) return;
            if (model is Profiles)
            {
                Profiles p = (model as Profiles)!;
                await supabase.From<Profiles>().Upsert(p);
            }
        }

        public async Task UpdateData<T>(T model)
        {
            if (model is Profiles)
            {
                Profiles p = (model as Profiles)!;

                var update = await supabase
      .From<Profiles>()
      .Where(x => x.Id == p.Id)
      .Set(x => x.UserName, p.UserName)
      .Update();
            }
            
            if(model is Room)
            {
                Room r = (model as Room)!;

                var update = await supabase
      .From<Room>()
      .Where(x => x.Id == r.Id)
      .Set(x => x.player1id, r.player1id)
      .Set(x => x.player2id, r.player2id)
      .Set(x => x.roomstatus, r.roomstatus)
      .Update();
            }
        
        }

        public async Task<Profiles> GetProfileById(string userid)
        {
            var result = await supabase.From<Profiles>().Where(x => x.Id == userid).Single();

            return result;
        }
        
        public async Task<Room>? CreateRoom(Room model)
        {
            try
            {
                var result = await supabase.From<Room>().Insert(model, new QueryOptions { Returning = ReturnType.Representation }) ?? throw new Exception("error while creating room");
                Room room = result.Model!;
                return room;
            }
            catch (Exception)
            {
                return null!;
            }

        }
    
        public async Task<Room>? GetRoomById(string roomid)
        {
            try
            {
                var result = await supabase.From<Room>().Where(x => x.Id == roomid).Single() ?? throw new Exception("room is not available");
                return result;
            }catch (Exception) { return null!; }
       
        }
    
    }
}
