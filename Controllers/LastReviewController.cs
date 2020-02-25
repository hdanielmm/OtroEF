using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // Vehicle - VehicleReview - PartReview
        [HttpGet("/lastreview/vpr")]
        public ActionResult<IEnumerable<Vehicle>> GetResult()
        {
            var vehicles = _context.Vehicles
                .Include(vehicle => vehicle.VehicleReviews)
                    .ThenInclude(vr => vr.PartReviews)
                .ToList();
            return vehicles;
        }

        // VehiclePart - PartReview - VehicleReview - Vehicle
        [HttpGet("/lastreview/vp")]
        public ActionResult<List<VehiclePart>> GetVP()
        {
            var vehicleParts = _context.VehicleParts
                .Include(vp => vp.PartReviews)
                    .ThenInclude(pr => pr.VehicleReview)
                        .ThenInclude(vr => vr.Vehicle)
                .ToList();
            return vehicleParts;
        }

        // Employee - PartReview - VehiclePart
        [HttpGet("/lastreview/evpr")]
        public ActionResult<IEnumerable<Employee>> GetEVPR()
        {
            var employees = _context.Employees
                .Include(e => e.PartReviews)
                    .ThenInclude(pr => pr.VehiclePart)
                .ToList();
            return employees;
        }
    }
}