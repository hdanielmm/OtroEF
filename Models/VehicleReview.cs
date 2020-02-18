using System;

namespace OtroEF.Models
{
    public class VehicleReview
    {
        public int Id { get; set; }
        public DateTime DateReview { get; set; }
        public string LicensePlate { get; set; }
        public int EmployeeId { get; set; }

        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }
    }
}