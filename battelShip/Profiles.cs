using Postgrest.Attributes;
using Postgrest.Models;

namespace battelShip
{
    [Table("profiles")]
    public class Profiles : BaseModel
    {
        [PrimaryKey("id")]
        public string? Id { get; set; } = null;

        [Column("user_name")]
        public string? UserName { get; set; } = null;
    }
}
