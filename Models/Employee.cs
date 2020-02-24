using System.Collections.Generic;

namespace OtroEF.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<VehicleReview> VehicleReviews { get; set; }
        public List<PartReview> PartReviews { get; set; }
    }
}