using System.ComponentModel.DataAnnotations;

namespace Rent_a_Car.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char EGN { get; set; }
        public char PhoneNum { get; set; }

        [DataType(DataType.EmailAddress)]
        public char email { get; set; }

        public string Status { get; set; }
    }
}
