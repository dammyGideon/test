namespace Herbzhub.Data.Models
{
    public class Role : BaseEntity
    {
     
        public string RoleName { get; set; }

        public ICollection<UserRole> UserRole { get; set; }
    }
}
