using System.ComponentModel.DataAnnotations;

namespace Rent_a_Car.Models
{
    public class Query
    {
        //Information for creating the table for the queries with get and set
        [Key]

        //The [Required] attribute indicate that a property must have a value. 
        public int Id { get; set; }
        [Required]
        public string WantedCar { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime FromDate { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime ToDate { get; set; }
        [Required]
        public string UserWantingTheCar { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
