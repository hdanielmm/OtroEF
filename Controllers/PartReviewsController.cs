using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
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

        // [HttpGet]
        // public ActionResult<IEnumerable<PartReview>> GetTest()
        // {
        //     var query = _context.PartReviews
        //         .Join(
        //             _context.VehicleReviews,
        //             pr => pr.VehicleReviewId,
        //             vr => vr.PartReviewId
        //         ).ToList();
        //     return _context.PartReviews;
        // }

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