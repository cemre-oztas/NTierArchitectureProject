using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : IBookDal
    {
        public void Add(Book entity)
        {
            using (DbContext context = new DbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Book entity)
        {
            using (DbContext context = new DbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            using (DbContext context = new DbContext())
            {
                return filter == null
                  ? context.Set<Book>().ToList()
                  : context.Set<Book>().Where(filter).ToList();
            }
        }

        public Book GetById(Expression<Func<Book, bool>> filter)
        {
            using (DbContext context = new DbContext())
            {
                return context.Set<Book>().SingleOrDefault(filter);

            }
        }

        public void Update(Book entity)
        {
            using (DbContext context = new DbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}