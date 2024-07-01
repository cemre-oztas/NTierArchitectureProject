using Entities.Concrete;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@burasibostur");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Categories { get; set; }
        public DbSet<Notebook> Customers { get; set; }
        public DbSet<Magazine> Orders { get; set; }


    }
}