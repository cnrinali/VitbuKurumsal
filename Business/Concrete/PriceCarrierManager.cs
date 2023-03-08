using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class PriceCarrierManager : IPriceCarrierService
    {
        IPriceCarrierDal _priceCarrierDal;
        public PriceCarrierManager(IPriceCarrierDal priceCarrierDal)
        {
            _priceCarrierDal = priceCarrierDal;
        }
        public void Create(PriceCarrier entity)
        {
            _priceCarrierDal.Create(entity);
        }

        public void Delete(PriceCarrier entity)
        {
            _priceCarrierDal.Delete(entity);
        }

        public PriceCarrier Get(Expression<Func<PriceCarrier, bool>> filter)
        {
            return _priceCarrierDal.Get(filter);
        }

        public List<PriceCarrier> GetAll(Expression<Func<PriceCarrier, bool>> filter = null)
        {
            return _priceCarrierDal.GetAll();
        }
        public List<PriceCarrier> GetList(Expression<Func<PriceCarrier, bool>> filter)
        {
            return _priceCarrierDal.GetList(filter);
        }

        public PriceCarrier GetById(Guid id)
        {
            return _priceCarrierDal.GetById(id);
        }

        public void Update(PriceCarrier entity)
        {
            _priceCarrierDal.Update(entity);
        }
    }
}
