using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Threading.Tasks;

namespace OtroEF.Models
{
    public class Vehicle
    {
        // public int Id { get; set; }
        [Key]
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Line { get; set; }
        public int Model { get; set; }
    }

}