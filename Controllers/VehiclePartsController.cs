using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OtroEF.Models;

namespace OtroEF.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehiclePartsController : ControllerBase
    {
        private OtroEFContext _context;
        
        public VehiclePartsController(OtroEFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VehiclePart>> GetVehicleParts()
        {
            return _context.VehicleParts;
        }

        [HttpGet("{id}")]
        public ActionResult<VehiclePart> GetVehiclePart(int id)
        {
            var vehiclePart = _context.VehicleParts.Find(id);

            if ( vehiclePart == null ) {
                return NotFound();
            }

            return vehiclePart;
        }
    }
}