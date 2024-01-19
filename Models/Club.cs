using System.ComponentModel.DataAnnotations;

namespace PPServer.Models
{
    public class Club
    {
        public uint id { get; set; }
        public string name { get; set; }

        public string? lat { get; set; }

        public string? lon { get; set; }

        public string? image { get; set; }

        public string? adress { get; set; }
    }
}
