using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IStatuService
    {
        Statu GetById(Guid id);
        Statu Get(Expression<Func<Statu, bool>> filter);
        List<Statu> GetAll(Expression<Func<Statu, bool>> filter = null);
        List<Statu> GetList(Expression<Func<Statu, bool>> filter);
        void Create(Statu entity);
        void Update(Statu entity);
        void Delete(Statu entity);
    }
}
