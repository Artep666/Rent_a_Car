using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.Data;
using Rent_a_Car.Models;

namespace Rent_a_Car.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly Rent_a_Car.Data.Rent_a_CarContext _context;

        public IndexModel(Rent_a_Car.Data.Rent_a_CarContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Brands { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? CarBrand { get; set; }

        public async Task OnGetAsync()
        {// Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from c in _context.Car
                                            orderby c.Brand
                                            select c.Brand;

            var cars = from c in _context.Car
                       select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                cars = cars.Where(s => s.Brand.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CarBrand))
            {
                cars = cars.Where(x => x.Brand == CarBrand);
            }
            Brands = new SelectList(await genreQuery.Distinct().ToListAsync());
            Car = await cars.ToListAsync();

        }
    }
}