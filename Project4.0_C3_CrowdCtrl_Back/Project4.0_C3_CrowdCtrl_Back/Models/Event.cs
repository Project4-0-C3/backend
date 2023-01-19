using System.Text.Json.Serialization;

namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int EventTypeId { get; set; }
        public string Description { get; set; }
        
        public EventType? EventType { get; set; }
        public List<EventUser>? EventUsers { get; set; } = new List<EventUser>();
        
        public List<Group>? Groups { get; set; } = new List<Group>();
        
        public List<EventRecordingDevice>? EventRecordingDevices { get; set; } = new List<EventRecordingDevice>();   
    }
}
