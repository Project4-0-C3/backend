﻿using System.Text.Json.Serialization;

namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class EventRecordingDevice
    {
        public int EventRecordingDeviceId { get; set; }
        public string? PlacementName { get; set;}
        public int? ZoneId { get; set;}
        public int RecordingDeviceId { get; set; }
        public int EventId { get; set; }

        public Zone? Zone { get; set; }
        public RecordingDevice? RecordingDevice { get; set; }
        [JsonIgnore]
        public Event? Event { get; set; }
        //public List<Incident>? Incidents { get; set; } = new List<Incident>();
    }
}
