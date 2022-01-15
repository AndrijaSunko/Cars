using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using CarsApp.Data;
using System;
using System.Linq;
namespace CarsApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarsAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CarsAppContext>>()))
            {
                // Look for any movies.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Name = "BMW", 
                        Abrv = "BMW"                      
                    },

                     new Car
                     {
                        Name = "Ford",
                        Abrv = "Ford"
                     },

                     new Car
                     {
                        Name = "VolksWagen",
                        Abrv = "WV"
                     },

                     new Car
                     {
                        Name = "Mercedes - Benz",
                        Abrv = "MB"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
