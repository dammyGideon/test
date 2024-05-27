using Herbzhub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Herbzhub.Data.Seeders
{
    public class RoleTableSeeder : IEntityTypeConfiguration<Role>
    {
         
        public void Configure(EntityTypeBuilder<Role> builder)
        {

            builder.HasData(RoleSeeder());
        }
        private static List<Role> RoleSeeder()
        {
            return new List<Role>()
            {
                new Role { Id = 1, RoleName="Manufacturer"},
                new Role { Id = 2, RoleName="Manufacturer Driver"},
                new Role { Id = 3, RoleName="Dispensary"},
                new Role { Id = 4, RoleName="Customer Driver"},
                new Role { Id = 5, RoleName="Customer"},
            }; 
        }
    }
}
