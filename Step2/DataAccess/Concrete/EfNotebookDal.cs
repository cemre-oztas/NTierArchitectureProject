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
    public class EfNotebookDal : INotebookDal
    {
        public void Add(Notebook entity)
        {
            using (DbContext context = new DbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Notebook entity)
        {
            using (DbContext context = new DbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Notebook> GetAll(Expression<Func<Notebook, bool>> filter = null)
        {
            using (DbContext context = new DbContext())
            {
                return filter == null
                  ? context.Set<Notebook>().ToList()
                  : context.Set<Notebook>().Where(filter).ToList();
            }
        }

        public Notebook GetById(Expression<Func<Notebook, bool>> filter)
        {
            using (DbContext context = new DbContext())
            {
                return context.Set<Notebook>().SingleOrDefault(filter);

            }
        }

        public void Update(Notebook entity)
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