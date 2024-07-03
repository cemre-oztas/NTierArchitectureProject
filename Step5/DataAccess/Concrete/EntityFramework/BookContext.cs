using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"sql");

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<User> Users { get; set; }
         
    }
}