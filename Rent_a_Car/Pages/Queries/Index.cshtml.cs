using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.Data;
using Rent_a_Car.Models;

namespace Rent_a_Car.Pages.Queries
{
    public class IndexModel : PageModel
    {
        private readonly Rent_a_Car.Data.Rent_a_CarContext _context;

        public IndexModel(Rent_a_Car.Data.Rent_a_CarContext context)
        {
            _context = context;
        }

        public IList<Query> Query { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Query != null)
            {
                Query = await _context.Query.ToListAsync();
            }
        }
    }
}
