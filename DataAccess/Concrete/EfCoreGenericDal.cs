using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfCoreGenericDal<T, TContext> : IGenericRepository<T>
       where T : class
       where TContext : DbContext, new()
    {
        public virtual void Create(T entity)
        {
            using (var context = new TContext())
            {
                if (entity is EntityBase)
                {
                    EntityBase o = entity as EntityBase;

                    o.CreateDate = DateTime.Now.ToString();
                    o.ModifiedName = "system";
                }
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public virtual void Delete(T entity)
        {
            using (var context = new TContext())
            {
                if (entity is EntityBase)
                {
                    EntityBase o = entity as EntityBase;

                    o.isDeleted = "false";
                }
                context.Set<T>().Update(entity);
                context.SaveChanges();
            }
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();
            }
        }

        public virtual List<T> GetList(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return filter == null
                ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();
            }
        }

        public virtual T Get(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public virtual T GetById(Guid id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public virtual void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
