using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DataAccess.Concrete.EntityFramework
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CARS;Integrated Security=True");

        }
        public Microsoft.EntityFrameworkCore.DbSet<Book> BookTable { get; set; }
        public System.Data.Entity.DbSet<Notebook> NotebookTable { get; set; }   
        public Microsoft.EntityFrameworkCore.DbSet<Magazine> MagazineTable { get; set; }
    }
}