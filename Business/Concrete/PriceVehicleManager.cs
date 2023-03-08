using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class PriceVehicleManager : IPriceVehicleService
    {
        IPriceVehicleDal _priceVehicleDal;
        public PriceVehicleManager(IPriceVehicleDal priceVehicleDal)
        {
            _priceVehicleDal = priceVehicleDal;
        }
        public void Create(PriceVehicle entity)
        {
            _priceVehicleDal.Create(entity);
        }

        public void Delete(PriceVehicle entity)
        {
            _priceVehicleDal.Delete(entity);
        }

        public PriceVehicle Get(Expression<Func<PriceVehicle, bool>> filter)
        {
            return _priceVehicleDal.Get(filter);
        }

        public List<PriceVehicle> GetAll(Expression<Func<PriceVehicle, bool>> filter = null)
        {
            return _priceVehicleDal.GetAll();
        }
        public List<PriceVehicle> GetList(Expression<Func<PriceVehicle, bool>> filter)
        {
            return _priceVehicleDal.GetList(filter);
        }

        public PriceVehicle GetById(Guid id)
        {
            return _priceVehicleDal.GetById(id);
        }

        public void Update(PriceVehicle entity)
        {
            _priceVehicleDal.Update(entity);
        }
    }
}
