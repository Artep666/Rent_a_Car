using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.Models;

namespace Rent_a_Car.Data
{
    public class Rent_a_CarContext : IdentityDbContext
    {
        public Rent_a_CarContext (DbContextOptions<Rent_a_CarContext> options)
            : base(options)
        {
        }

        public DbSet<Rent_a_Car.Models.Car> Car { get; set; } = default!;

        public DbSet<Rent_a_Car.Models.Customer>? Customer { get; set; }

        public DbSet<Rent_a_Car.Models.Query>? Query { get; set; }
    }
}
