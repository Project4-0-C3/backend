namespace Project4._0_C3_CrowdCtrl_Back.Models
{
    public class RoleType
    {
        public int RoleTypeId { get; set; }
        public string Name { get; set; }

        public List<User>? User { get; set; } = new List<User>();
    }
}
