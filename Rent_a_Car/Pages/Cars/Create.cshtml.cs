using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rent_a_Car.Data;
using Rent_a_Car.Models;

namespace Rent_a_Car.Pages.Cars
{
    public class CreateModel : PageModel
    {
        private readonly Rent_a_Car.Data.Rent_a_CarContext _context;

        public CreateModel(Rent_a_Car.Data.Rent_a_CarContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Car Car { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        //The OnPostAsync method is run when the page posts form data:
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Car == null || Car == null)
            {
                return Page();
            }

            _context.Car.Add(Car);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
