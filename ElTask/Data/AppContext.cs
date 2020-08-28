using ElTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElTask.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<LaptopRegistration> Lreg { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
