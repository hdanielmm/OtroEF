using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OtroEF.Models;

namespace OtroEF.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PartReviewsController : ControllerBase
    {
        private readonly OtroEFContext _context;

        public PartReviewsController(OtroEFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PartReview>> GetPartReviews()
        {
            return _context.PartReviews;
        }

        [HttpGet("{id}")]
        public ActionResult<PartReview> GetPartReview(int id)
        {
            var partReview = _context.PartReviews.Find(id);

            if (partReview == null)
            {
                return NotFound();
            }

            return partReview;
        }

        [HttpPost]
        public ActionResult<PartReview> PostPartReview(PartReview partReview)
        {
            _context.PartReviews.Add(partReview);
            _context.SaveChanges();

            return CreatedAtAction("GetPartReviews", new PartReview { Id = partReview.Id }, partReview);
        }
    }
}