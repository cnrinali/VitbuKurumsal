using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IVehicleCategoryService
    {
        VehicleCategory GetById(Guid id);
        VehicleCategory Get(Expression<Func<VehicleCategory, bool>> filter);
        List<VehicleCategory> GetAll(Expression<Func<VehicleCategory, bool>> filter = null);
        List<VehicleCategory> GetList(Expression<Func<VehicleCategory, bool>> filter);
        void Create(VehicleCategory entity);
        void Update(VehicleCategory entity);
        void Delete(VehicleCategory entity);
    }
}
