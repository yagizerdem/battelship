using Newtonsoft.Json;
using Postgrest.Attributes;
using Postgrest.Models;


namespace battelShip
{
    [Table("room")]
    public class Room : BaseModel
    {
        [PrimaryKey("id")]
        public string? Id { get; set; } = null;

        [Column("player1id")]
        public string player1id { get; set; } = null!;
        [Column("player2id")]
        public string player2id { get; set; } = null!;
        [Column("roomstatus")]
        public bool roomstatus { get; set; } = false;

        [Column("p1ready")]
        public bool p1ready { get; set; } = false;

        [Column("p2ready")]
        public bool p2ready { get; set; } = false;

        [Column("counter")]
        public int counter { get; set; } = 0;



        [Column("board")]
        public string BoardJson { get; set; } = JsonConvert.SerializeObject(new GameBoard().board);



    }
}
