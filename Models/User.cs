using System.ComponentModel.DataAnnotations;

namespace PPServer.Models
{
    public class User
    {
        [Key]
        public uint Id { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public int TypeOfUser { get; set; }
    }
}
