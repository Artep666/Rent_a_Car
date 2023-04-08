using System.ComponentModel.DataAnnotations;

namespace Rent_a_Car.Models
{
    public class Customer
    {
        //The [Required] attribute indicate that a property must have a value. 
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        //The [StringLength] attribute can set a maximum length of a string property, and optionally its minimum length.
        [StringLength(10, MinimumLength = 10)]
        [Required]

        public string EGN { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [Required]
        public string PhoneNum { get; set; }

        [StringLength(100, MinimumLength = 10)]
        [Required]
        public string email { get; set; }

        
    }
}
