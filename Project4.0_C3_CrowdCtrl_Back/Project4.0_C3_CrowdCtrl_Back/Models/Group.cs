using System.Text.Json.Serialization;

namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int ZoneId { get; set; }
        public int EventId { get; set; }
        public Zone? Zone { get; set; }
        [JsonIgnore]
        public Event? Event { get; set; }
        public List<EventUser>? EventUsers { get; set; } = new List<EventUser>();
    }
}
