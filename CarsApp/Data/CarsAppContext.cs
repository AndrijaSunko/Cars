#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarsApp.Models;

namespace CarsApp.Data
{
    public class CarsAppContext : DbContext
    {
        public CarsAppContext (DbContextOptions<CarsAppContext> options)
            : base(options)
        {
        }

        public DbSet<CarsApp.Models.Car> Car { get; set; }
    }
}
