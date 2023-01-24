namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public Boolean IsAccurate { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public int IncidentID { get; set; }
        public User User { get; set; }
        public Incident Incident { get; set; }
    }
}
