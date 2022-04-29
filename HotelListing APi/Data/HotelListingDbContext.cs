using Microsoft.EntityFrameworkCore;

namespace HotelListing_APi.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public  DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id=1,
                Name="Jamaica",
                ShortName="JM"
            },
            new Country
            {
                Id=2,
                Name = "Kuwait",
                ShortName="KW"
            }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id=1,
                    Name="Sandals Resort and Spa",
                    Address = "Somewhere",
                    CountryId = 1,
                    Rating = 1.5
                },
                new Hotel
                {
                    Id=2,
                    Name = "Comfort Suites",
                    Address ="Rumaitheya",
                    CountryId = 2,
                    Rating = 5
                }
            );
        }
    }
}
