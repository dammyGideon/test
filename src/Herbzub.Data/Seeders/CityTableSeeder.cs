using Herbzhub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Herbzhub.Data.Seeders
{
    public class CityTableSeeder : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(GetCities());
        }

        private static IEnumerable<City> GetCities()
        {
            return new List<City>()
            {
                 new City { Id = 1, Name = "New York City", State = "New York" },
                new City { Id = 2, Name = "Los Angeles", State = "California" },
                new City { Id = 3, Name = "Chicago", State = "Illinois" },
                new City { Id = 4, Name = "Houston", State = "Texas" },
                new City { Id = 5, Name = "Phoenix", State = "Arizona" },
                new City { Id = 6, Name = "Philadelphia", State = "Pennsylvania" },
                new City { Id = 7, Name = "San Antonio", State = "Texas" },
                new City { Id = 8, Name = "San Diego", State = "California" },
                new City { Id = 9, Name = "Dallas", State = "Texas" },
                new City { Id = 10, Name = "San Jose", State = "California" },
                new City { Id = 11, Name = "Austin", State = "Texas" },
                new City { Id = 12, Name = "Jacksonville", State = "Florida" },
                new City { Id = 13, Name = "Fort Worth", State = "Texas" },
                new City { Id = 14, Name = "Columbus", State = "Ohio" },
                new City { Id = 15, Name = "San Francisco", State = "California" },
                new City { Id = 16, Name = "Charlotte", State = "North Carolina" },
                new City { Id = 17, Name = "Indianapolis", State = "Indiana" },
                new City { Id = 18, Name = "Seattle", State = "Washington" },
                new City { Id = 19, Name = "Denver", State = "Colorado" },
                new City { Id = 20, Name = "Washington", State = "District of Columbia" },
                new City { Id = 21, Name = "Boston", State = "Massachusetts" },
                new City { Id = 22, Name = "El Paso", State = "Texas" },
                new City { Id = 23, Name = "Nashville", State = "Tennessee" },
                new City { Id = 24, Name = "Detroit", State = "Michigan" },
                new City { Id = 25, Name = "Oklahoma City", State = "Oklahoma" },
                new City { Id = 26, Name = "Portland", State = "Oregon" },
                new City { Id = 27, Name = "Las Vegas", State = "Nevada" },
                new City { Id = 28, Name = "Memphis", State = "Tennessee" },
                new City { Id = 29, Name = "Louisville", State = "Kentucky" },
                new City { Id = 30, Name = "Baltimore", State = "Maryland" },
                new City { Id = 31, Name = "Milwaukee", State = "Wisconsin" },
                new City { Id = 32, Name = "Albuquerque", State = "New Mexico" },
                new City { Id = 33, Name = "Tucson", State = "Arizona" },
                new City { Id = 34, Name = "Fresno", State = "California" },
                new City { Id = 35, Name = "Sacramento", State = "California" },
                new City { Id = 36, Name = "Kansas City", State = "Missouri" },
                new City { Id = 37, Name = "Long Beach", State = "California" },
                new City { Id = 38, Name = "Mesa", State = "Arizona" },
                new City { Id = 39, Name = "Atlanta", State = "Georgia" },
                new City { Id = 40, Name = "Colorado Springs", State = "Colorado" },
                new City { Id = 41, Name = "Virginia Beach", State = "Virginia" },
                new City { Id = 42, Name = "Raleigh", State = "North Carolina" },
                new City { Id = 43, Name = "Omaha", State = "Nebraska" },
                new City { Id = 44, Name = "Miami", State = "Florida" },
                new City { Id = 45, Name = "Oakland", State = "California" },
                new City { Id = 46, Name = "Minneapolis", State = "Minnesota" },
                new City { Id = 47, Name = "Tulsa", State = "Oklahoma" },
                new City { Id = 48, Name = "Wichita", State = "Kansas" },
                new City { Id = 49, Name = "New Orleans", State = "Louisiana" },
                new City { Id = 50, Name = "Arlington", State = "Texas" },
            };
        }
    }
}
