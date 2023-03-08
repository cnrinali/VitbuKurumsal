using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class PriceManager : IPriceService
    {
        IPriceDal _priceDal;
        public PriceManager(IPriceDal priceDal)
        {
            _priceDal = priceDal;
        }
        public void Create(Price entity)
        {
            _priceDal.Create(entity);
        }

        public void Delete(Price entity)
        {
            _priceDal.Delete(entity);
        }

        public Price Get(Expression<Func<Price, bool>> filter)
        {
            return _priceDal.Get(filter);
        }

        public List<Price> GetAll(Expression<Func<Price, bool>> filter = null)
        {
            return _priceDal.GetAll();
        }
        public List<Price> GetList(Expression<Func<Price, bool>> filter)
        {
            return _priceDal.GetList(filter);
        }

        public Price GetById(Guid id)
        {
            return _priceDal.GetById(id);
        }

        public void Update(Price entity)
        {
            _priceDal.Update(entity);
        }
    }
}
