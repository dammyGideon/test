using Herbzhub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Herbzhub.Data.Seeders
{
    public class CountryTableSeeder : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(

                new Country { Id = 1, Name = "United States" },
                new Country { Id = 2, Name = "Canada" },
                new Country { Id = 3, Name = "United Kingdom" },
                new Country { Id = 4, Name = "Nigeria" },
                new Country { Id = 5, Name = "Togo" }

                );
        }

        //private static IEnumerable<Country> GetCountries()
        //{
        //    return new List<Country>()
        //    {
        //        new Country {Id =1, Name="United States"},
        //        new Country {Id=2,  Name="Canada"},
        //        new Country {Id=3,  Name="United Kingdom"},
        //        new Country {Id=4,  Name="Nigeria"},
        //        new Country {Id=4, Name="Togo"}


        //    };
        //}
    
    }
}
