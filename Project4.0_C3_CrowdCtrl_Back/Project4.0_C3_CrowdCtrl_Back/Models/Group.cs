namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int ZoneId { get; set; }
        public int EventId { get; set; }
        public Zone? Zone { get; set; }
        public Event? Event { get; set; }
        public List<GroupGuard>? GroupGuards { get; set; } = new List<GroupGuard>();
    }
}
