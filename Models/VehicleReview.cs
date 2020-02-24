using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtroEF.Models
{
    public class VehicleReview
    {
        public int Id { get; set; }
        public DateTime DateReview { get; set; }
        public int VehicleId { get; set; }
        public int EmployeeId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }
    }
}