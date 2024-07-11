using Postgrest.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battelShip
{
    public interface IDatabase
    {
        public Supabase.Client supabase { get; set; }
        public bool initilazed { get; set; }

        public Task Initilize();

        public Task<Supabase.Gotrue.Session?> SignUp(string email , string password);
        public Task<Supabase.Gotrue.Session?> SignIn(string email, string password);

        public Supabase.Gotrue.User GetSession();

        public Task UpsertData<T>(T model);
        public Task UpdateData<T>(T model);

        public Task<Profiles> GetProfileById(string userid);

        public Task<Room>? CreateRoom(Room model);
        public Task<Room>? GetRoomById(string roomid);
    }
}
