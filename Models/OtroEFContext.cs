using System;
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
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle{Id=1, LicensePlate="AAA111",Brand="Opel",Line="Corsa", Model=2008},
                new Vehicle{Id=2, LicensePlate="AAA112",Brand="Renault",Line="Sandero", Model=2009},
                new Vehicle{Id=3, LicensePlate="AAA113",Brand="Chevrolet",Line="Sail", Model=2010},
                new Vehicle{Id=4, LicensePlate="AAA114",Brand="Opel",Line="Corsa", Model=2011},
                new Vehicle{Id=5, LicensePlate="AAA115",Brand="Renault",Line="Logan", Model=2012},
                new Vehicle{Id=6, LicensePlate="AAA116",Brand="Chevrolet",Line="Corsa", Model=2013},
                new Vehicle{Id=7, LicensePlate="AAA117",Brand="Opel",Line="Corsa", Model=2014},
                new Vehicle{Id=8, LicensePlate="AAA118",Brand="Renault",Line="symbol", Model=2015}
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Employee01" },
                new Employee { Id = 2, Name = "Employee02" },
                new Employee { Id = 3, Name = "Employee03" },
                new Employee { Id = 4, Name = "Employee04" },
                new Employee { Id = 5, Name = "Employee05" },
                new Employee { Id = 6, Name = "Employee06" },
                new Employee { Id = 7, Name = "Employee07" }
            );

            modelBuilder.Entity<VehiclePart>().HasData(
                new VehiclePart{Id=1,Name="Vehicle part 01"},
                new VehiclePart{Id=2,Name="Vehicle part 02"},
                new VehiclePart{Id=3,Name="Vehicle part 03"},
                new VehiclePart{Id=4,Name="Vehicle part 04"},
                new VehiclePart{Id=5,Name="Vehicle part 05"},
                new VehiclePart{Id=6,Name="Vehicle part 06"},
                new VehiclePart{Id=7,Name="Vehicle part 07"},
                new VehiclePart{Id=8,Name="Vehicle part 08"},
                new VehiclePart{Id=9,Name="Vehicle part 09"},
                new VehiclePart{Id=10,Name="Vehicle part 10"},
                new VehiclePart{Id=11,Name="Vehicle part 11"},
                new VehiclePart{Id=12,Name="Vehicle part 12",}
            );

            modelBuilder.Entity<VehicleReview>().HasData(
                new VehicleReview{Id=1,DateReview=DateTime.Parse("2020-03-04T10:00:00"),VehicleId=1,EmployeeId=1},
                new VehicleReview{Id=2,DateReview=DateTime.Parse("2020-03-04T12:00:00"),VehicleId=2,EmployeeId=1},
                new VehicleReview{Id=3,DateReview=DateTime.Parse("2020-03-04T14:00:00"),VehicleId=3,EmployeeId=1},
                new VehicleReview{Id=4,DateReview=DateTime.Parse("2020-03-04T16:00:00"),VehicleId=4,EmployeeId=1},
                new VehicleReview{Id=5,DateReview=DateTime.Parse("2020-03-04T18:00:00"),VehicleId=5,EmployeeId=1},
                new VehicleReview{Id=6,DateReview=DateTime.Parse("2020-03-04T20:00:00"),VehicleId=6,EmployeeId=1},
                new VehicleReview{Id=7,DateReview=DateTime.Parse("2020-03-04T22:00:00"),VehicleId=8,EmployeeId=1}
            );

            modelBuilder.Entity<PartReview>().HasData(
                new PartReview{Id=1,DateReview=DateTime.Parse("2020-03-04T10:00:00"), Diagnosis="Diagnosis 1", VehicleReviewId=1, VehiclePartId=1, EmployeeId=5},
                new PartReview{Id=2,DateReview=DateTime.Parse("2020-03-04T12:00:00"), Diagnosis="Diagnosis 2", VehicleReviewId=2, VehiclePartId=1, EmployeeId=5},
                new PartReview{Id=3,DateReview=DateTime.Parse("2020-03-04T14:00:00"), Diagnosis="Diagnosis 3", VehicleReviewId=3, VehiclePartId=1, EmployeeId=5},
                new PartReview{Id=4,DateReview=DateTime.Parse("2020-03-04T16:00:00"), Diagnosis="Diagnosis 4", VehicleReviewId=4, VehiclePartId=1, EmployeeId=5},
                new PartReview{Id=5,DateReview=DateTime.Parse("2020-03-04T18:00:00"), Diagnosis="Diagnosis 5", VehicleReviewId=5, VehiclePartId=1, EmployeeId=5},
                new PartReview{Id=6,DateReview=DateTime.Parse("2020-03-04T20:00:00"), Diagnosis="Diagnosis 6", VehicleReviewId=6, VehiclePartId=1, EmployeeId=5},
                new PartReview{Id=7,DateReview=DateTime.Parse("2020-03-04T22:00:00"), Diagnosis="Diagnosis 7", VehicleReviewId=7, VehiclePartId=1, EmployeeId=5}
            );
        }
    }

}