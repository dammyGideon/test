using Herbzhub.Data.Models;
using Herbzhub.Data.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Herbzhub.Data
{
    public class DbApplicationContext : DbContext
    {
        public DbApplicationContext(DbContextOptions<DbApplicationContext> options) : base(options){ }


            public DbSet<Counties> Counties { get; set; }
            public DbSet<Country> Countries { get; set; }
            public DbSet<City> cities { get; set; }
            public DbSet<State> States { get; set; }


            public DbSet<Dispensary> Dispensaries { get; set; }
            public DbSet<ContactInformation> ContactInformations { get; set; }
            public DbSet<InventoryManagement> InventoryManagements { get; set; }
            public DbSet<FinancialInformation> FinancialInformation { get; set; }
            public DbSet<AuditFeedback> AuditFeedbacks { get; set; }


            public DbSet<Customer> Customers { get; set; }
            public DbSet<CustomerMedicalInformation> CustomerMedicalInformation { get; set; }
            public DbSet<CustomerLegalDocument> CustomerLegalDocuments { get; set; }
            public DbSet<CustomerPreferencesNotes> CustomerPreferencesNotes { get; set; }
            public DbSet<CustomerAudit> CustomerAudits { get; set; }


            public DbSet<Driver> Drivers { get; set; }
            public DbSet<DriverEmploymentDetail> DriverEmploymentDetails { get; set; }
            public DbSet<DriverVehicleInformation> DriverVehicleInformation { get; set; }


            public DbSet<User> Users { get; set; }
            public DbSet<Address> Addresses { get; set; }
            public DbSet<Role> Roles { get; set; }
            public DbSet<UserRole> UserRoles { get; set; }




            public DbSet<SMSVerificationCode> SMSVerificationCodes { get; set; }
            public DbSet<PersonalIdentification> PersonalIdentifications { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Dispensary>()
                .HasOne(c => c.ContactInformation)// navigation property
                .WithOne(ci => ci.Dispensary)
                .HasForeignKey<ContactInformation>(ci => ci.DispensaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Dispensary>()
                .HasOne(c => c.InventoryManagement)
                .WithOne(i => i.Dispensary)
                .HasForeignKey<InventoryManagement>(i => i.DispensaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Dispensary>()
                .HasOne(c => c.AuditFeedback)
                .WithOne(c => c.Dispensary)
                .HasForeignKey<AuditFeedback>(c => c.DispensaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Dispensary>()
                .HasOne(c => c.FinancialInformation)
                .WithOne(c => c.Dispensary)
                .HasForeignKey<FinancialInformation>(c => c.DispensaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Dispensary>()
                .HasOne(c => c.SecurityMeasures)
                .WithOne(d => d.Dispensary)
                .HasForeignKey<SecurityMeasures>(d => d.DispensaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserRole) // User has many UserRoles
                .WithOne(ur => ur.User) // UserRole belongs to one User
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<Role>()
                .HasMany(u => u.UserRole)
                .WithOne(s => s.Role)
                .HasForeignKey(s => s.RoleId);


            modelBuilder.ApplyConfiguration(new CountryTableSeeder());
            modelBuilder.ApplyConfiguration(new StateTableSeeder());
            modelBuilder.ApplyConfiguration(new CityTableSeeder());
            modelBuilder.ApplyConfiguration(new RoleTableSeeder());
            modelBuilder.ApplyConfiguration(new CountiesTableSeeder());
            UserSeedData.Seed(modelBuilder);
        }
    
    }
}
