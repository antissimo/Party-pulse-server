using System.ComponentModel.DataAnnotations;

namespace PPServer.Models
{
    public class Event
    {
        public uint id { get; set; }
        public string? name { get; set; }
        public uint clubId {  get; set; }
        public string? image { get; set; }
        public DateTime? dateTime { get; set; }
        public string? dressCode { get; set; }
        public string? description { get; set; }

    }
}
