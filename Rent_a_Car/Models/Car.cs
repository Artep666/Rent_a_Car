using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rent_a_Car.Models
{
    public class Car
    {
        //Information for creating the table for the cars with get and set
        //The [Required] attribute indicate that a property must have a value. 

        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Engine { get; set; }
        [Required]
        public int passengerSeats { get; set; }
        [Required]
        public double RentaDay { get; set; }
    }
}
