using System.Collections.Generic;

namespace OtroEF.Models
{
    public class VehiclePart
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<PartReview> PartReviews { get; set; }
    }
}