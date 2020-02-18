using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using OtroEF.Models;

namespace OtroEF.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly OtroEFContext _context;
        public VehiclesController(OtroEFContext context)
        {
            _context = context;
        }

        [HttpGet("/vehicles")]
        public ActionResult<IEnumerable<Vehicle>> GetVehicles()
        {
            return _context.Vehicles;
        }
        
        [HttpGet("/vehicles/{id}")]
        public ActionResult<Vehicle> GetVehicle(int id)
        {
            var vehicle = _context.Vehicles.Find(id);

            if (vehicle == null) {
              return NotFound();  
            } 
            
            return vehicle;
        }
    }
}