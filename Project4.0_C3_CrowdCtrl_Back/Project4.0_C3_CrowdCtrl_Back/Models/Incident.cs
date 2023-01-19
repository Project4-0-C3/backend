namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Accuracy { get; set; }
        public int EventRecordingDeviceId { get; set; }
        public int MoodTypeId { get; set; }
        public int IncidentTypeId { get; set; }
        public IncidentType IncidentType { get; set; }
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public RecordingDevice EventRecordingDevice { get; set; }
        public MoodType MoodType { get; set; }
    }
}
