using System.ComponentModel.DataAnnotations;

namespace Rent_a_Car.Models
{
    public class Query
    {
        //Information for the database for the queries with get and set
        [Key]
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
