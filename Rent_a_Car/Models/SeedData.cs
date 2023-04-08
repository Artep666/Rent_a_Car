using Microsoft.EntityFrameworkCore;
using Rent_a_Car.Data;

namespace Rent_a_Car.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Rent_a_CarContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Rent_a_CarContext>>()))
            {
                if (context == null || context.Car == null)
                {
                    throw new ArgumentNullException("Null Rent_a_CarContext");
                }

                // Look for any cars.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Brand = "Citroen",
                        Model = "Citroen C4",
                        Year = 2004,
                        Engine = "Petrol",
                        passengerSeats = 5,
                        RentaDay = 88
                    },

                    new Car
                    {
                        Brand = "Renault",
                        Model = "Renault Clio",
                        Year = 1990,
                        Engine = "Hybrid",
                        passengerSeats = 5,
                        RentaDay = 31
                    },

                    new Car
                    {
                        Brand = "Toyota",
                        Model = "Toyota Aygo",
                        Year = 2005,
                        Engine = "Hybrid",
                        passengerSeats = 4,
                        RentaDay = 76
                    },

                    new Car
                    {
                        Brand = "Toyota",
                        Model = "Toyota Corolla",
                        Year = 2000,
                        Engine = "Diesel",
                        passengerSeats = 5,
                        RentaDay = 110
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
