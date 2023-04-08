using System.ComponentModel.DataAnnotations;

namespace Rent_a_Car.Models
{
    public class Query
    {
        //Information for the database for the queries with get and set
        [Key]
        public int Id { get; set; }
        public string WantedCar { get; set; }
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }
        public string UserWantingTheCar { get; set; }
    }
}
