namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class IncidentType
    {
        public int IncidentTypeId { get; set; }
        public string Name { get; set; }

        public List<Incident>? Incidents { get; set; } = new List<Incident>();
    }
}
