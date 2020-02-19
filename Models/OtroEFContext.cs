using Microsoft.EntityFrameworkCore;

namespace OtroEF.Models
{
    public class OtroEFContext : DbContext
    {
        public OtroEFContext(DbContextOptions<OtroEFContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<VehiclePart> VehicleParts { get; set; }
        public DbSet<VehicleReview> VehicleReviews { get; set; }
        public DbSet<PartReview> PartReviews { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle
            {
                // Id = 1,
                LicensePlate = "AAA111",
                Brand = "Opel",
                Line = "Corsa",
                Model = 2008
            }, new Vehicle
            {
                // Id = 2,
                LicensePlate = "AAA112",
                Brand = "Renault",
                Line = "Logal",
                Model = 2020
            });
        }
    }

}