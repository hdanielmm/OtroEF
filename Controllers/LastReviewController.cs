using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OtroEF.Models;

namespace OtroEF.Controllers
{
    // [Route("[controller]")]
    // [ApiController]
    public class LastReviewController : ControllerBase
    {
        private readonly OtroEFContext _context;
        public LastReviewController(OtroEFContext context)
        {
            _context = context;
        }

        [HttpGet("/lastreview/rel")]
        public ActionResult<List<Vehicle>> GetResult()
        {
            var vehicles = _context.Vehicles
                .Include(vehicle => vehicle.VehicleReviews)
                    .ThenInclude(vr => vr.PartReviews)
                .Include(vehicle => vehicle.VehicleReviews)
                    .ThenInclude(vr => vr.Employee)
                .ToList();
            return vehicles;
        }

        [HttpGet("/lastreview/pr")]
        public ActionResult<List<PartReview>> GetPR()
        {
            var partReviews = _context.PartReviews
                .Include(pr => pr.VehicleReview)
                    .ThenInclude(vr => vr.Vehicle)
                .Include(pr => pr.Employee)
                .Include(pr => pr.VehiclePart)
                .ToList();
            return partReviews;
        }
    }
}