using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class VehicleCategoryManager : IVehicleCategoryService
    {
        IVehicleCategoryDal _vehicleCategoryDal;
        public VehicleCategoryManager(IVehicleCategoryDal vehicleCategoryDal)
        {
            _vehicleCategoryDal = vehicleCategoryDal;
        }
        public void Create(VehicleCategory entity)
        {
            _vehicleCategoryDal.Create(entity);
        }

        public void Delete(VehicleCategory entity)
        {
            _vehicleCategoryDal.Delete(entity);
        }

        public VehicleCategory Get(Expression<Func<VehicleCategory, bool>> filter)
        {
            return _vehicleCategoryDal.Get(filter);
        }

        public List<VehicleCategory> GetAll(Expression<Func<VehicleCategory, bool>> filter = null)
        {
            return _vehicleCategoryDal.GetAll();
        }
        
        public List<VehicleCategory> GetList(Expression<Func<VehicleCategory, bool>> filter)
        {
            return _vehicleCategoryDal.GetList(filter);
        }

        public VehicleCategory GetById(Guid id)
        {
            return _vehicleCategoryDal.GetById(id);
        }

        public void Update(VehicleCategory entity)
        {
            _vehicleCategoryDal.Update(entity);
        }
    }
}
