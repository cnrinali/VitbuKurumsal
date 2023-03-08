using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IGenericRepository<T>
    {
        T GetById(Guid id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
