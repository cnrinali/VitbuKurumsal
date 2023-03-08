using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ISehirlerService
    {
        Sehirler GetById(Guid id);
        Sehirler Get(Expression<Func<Sehirler, bool>> filter);
        List<Sehirler> GetAll(Expression<Func<Sehirler, bool>> filter = null);
        List<Sehirler> GetList(Expression<Func<Sehirler, bool>> filter);
        void Create(Sehirler entity);
        void Update(Sehirler entity);
        void Delete(Sehirler entity);
    }
}
