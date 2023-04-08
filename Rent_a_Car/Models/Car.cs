using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rent_a_Car.Models
{
    public class Car
    {
        //Information for the database for the cars with get and set
        public int Id { get; set; }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Engine { get; set; }

        public int passengerSeats { get; set; 
        }
        public double RentaDay { get; set; }
    }
}
