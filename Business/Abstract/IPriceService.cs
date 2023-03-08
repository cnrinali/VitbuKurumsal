using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IPriceService
    {
        Price GetById(Guid id);
        Price Get(Expression<Func<Price, bool>> filter);
        List<Price> GetAll(Expression<Func<Price, bool>> filter = null);
        List<Price> GetList(Expression<Func<Price, bool>> filter);
        void Create(Price entity);
        void Update(Price entity);
        void Delete(Price entity);
    }
}
