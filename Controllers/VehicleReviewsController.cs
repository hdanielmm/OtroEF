using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OtroEF.Models;

namespace OtroEF.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleReviewsController : ControllerBase
    {
        private readonly OtroEFContext _context;
        public VehicleReviewsController(OtroEFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VehicleReview>> GetVehicleReviews()
        {
            return _context.VehicleReviews;
        }

        [HttpGet("{id}")]
        public ActionResult<VehicleReview> GetVehicleReview(int id)
        {
            var vehicleReview = _context.VehicleReviews.Find(id);

            if (vehicleReview == null)
            {
                return NotFound();
            }

            return vehicleReview;
        }

        [HttpPost]
        public ActionResult<VehicleReview> PostVehicleReview(VehicleReview review)
        {
            _context.VehicleReviews.Add(review);
            _context.SaveChanges();

            return CreatedAtAction("GetVehicleReview", new VehicleReview {Id = review.Id}, review);
        }
    }
}