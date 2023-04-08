using System.ComponentModel.DataAnnotations;

namespace Rent_a_Car.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public string PhoneNum { get; set; }

        public string email { get; set; }

        public string Status { get; set; }
    }
}
