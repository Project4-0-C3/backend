using System.Text.Json.Serialization;

namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class GroupGuard
    {
        public int GroupGuardId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        
        public Group Group { get; set; }
        
        public User User { get; set; }
    }
}
