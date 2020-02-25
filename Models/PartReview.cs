using System;

namespace OtroEF.Models
{
    public class PartReview
    {
        public int Id { get; set; }
        public DateTime DateReview { get; set; }
        public string Diagnosis { get; set; }
        
        public int VehicleReviewId { get; set; }
        public int VehiclePartId { get; set; }
        public int EmployeeId { get; set; }

        public VehicleReview VehicleReview { get; set; }
        public VehiclePart VehiclePart {get; set; }
        public Employee Employee { get; set; }
    }
}