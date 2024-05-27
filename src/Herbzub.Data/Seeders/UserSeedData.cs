using Herbzhub.Data.Models;
using Microsoft.EntityFrameworkCore;
using saltGenerator = BCrypt.Net.BCrypt;

namespace Herbzhub.Data.Seeders
{
    public static class UserSeedData
    { 
       
        public static void Seed(ModelBuilder modelBuilder)
        {
            string salt = saltGenerator.GenerateSalt();
            var response = saltGenerator.HashPassword("password", salt); ;
            //PasswordHandler.
            var users = new List<User>(){
                new User{
                    Id = 1,
                     Username = "admin",
                     Email = "admin@example.com",
                     HashPassword = response,
                     MobileNumber = "1234567890",
                     IsMFAEnabled = false
                }
            };
            modelBuilder.Entity<User>().HasData(users);


            var userRole = new List<UserRole>()
            {
                 new UserRole
                 {
                     Id= 1,
                     RoleId = 1,
                     UserId = 1,
                 }
            };
            modelBuilder.Entity<UserRole>().HasData(userRole);
        }
    
    }
}
