using System.Collections;
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
    }
}