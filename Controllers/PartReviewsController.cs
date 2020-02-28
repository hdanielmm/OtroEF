using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using OtroEF.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore;

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

        // [HttpPut("{id}")]
        // public ActionResult PutCommandItem(int id, Command command)
        // {
        //     if(id != command.Id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(command).State = EntityState.Modified;
        //     _context.SaveChanges();

        //     return NoContent();
        // }
    }
}