using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class VehicleBrandManager : IVehicleBrandService
    {
        IVehicleBrandDal _vehicleBrandDal;
        public VehicleBrandManager(IVehicleBrandDal vehicleBrandDal)
        {
            _vehicleBrandDal = vehicleBrandDal;
        }
        public void Create(VehicleBrand entity)
        {
            _vehicleBrandDal.Create(entity);
        }

        public void Delete(VehicleBrand entity)
        {
            _vehicleBrandDal.Delete(entity);
        }

        public VehicleBrand Get(Expression<Func<VehicleBrand, bool>> filter)
        {
            return _vehicleBrandDal.Get(filter);
        }

        public List<VehicleBrand> GetAll(Expression<Func<VehicleBrand, bool>> filter = null)
        {
            return _vehicleBrandDal.GetAll();
        }
        
        public List<VehicleBrand> GetList(Expression<Func<VehicleBrand, bool>> filter)
        {
            return _vehicleBrandDal.GetList(filter);
        }

        public VehicleBrand GetById(Guid id)
        {
            return _vehicleBrandDal.GetById(id);
        }

        public void Update(VehicleBrand entity)
        {
            _vehicleBrandDal.Update(entity);
        }
    }
}
