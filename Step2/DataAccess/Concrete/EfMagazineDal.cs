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
    public class EfMagazineDal : IMagazineDal
    {
        public void Add(Magazine entity)
        {
            using (DbContext context = new DbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Magazine entity)
        {
            using (DbContext context = new DbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

         

        public List<Magazine> GetAll(Expression<Func<Magazine, bool>> filter = null)
        {
            using (DbContext context = new DbContext())
            {
                return filter == null
                  ? context.Set<Magazine>().ToList()
                  : context.Set<Magazine>().Where(filter).ToList();
            }
        }

        public Magazine GetById(Expression<Func<Magazine, bool>> filter)
        {
            using (DbContext context = new DbContext())
            {
                return context.Set<Magazine>().SingleOrDefault(filter);

            }
        }

        public void Update(Magazine entity)
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