using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IPriceCarrierService
    {
        PriceCarrier GetById(Guid id);
        PriceCarrier Get(Expression<Func<PriceCarrier, bool>> filter);
        List<PriceCarrier> GetAll(Expression<Func<PriceCarrier, bool>> filter = null);
        List<PriceCarrier> GetList(Expression<Func<PriceCarrier, bool>> filter);
        void Create(PriceCarrier entity);
        void Update(PriceCarrier entity);
        void Delete(PriceCarrier entity);
    }
}
