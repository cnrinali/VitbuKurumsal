using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IVehicleBrandService
    {
        VehicleBrand GetById(Guid id);
        VehicleBrand Get(Expression<Func<VehicleBrand, bool>> filter);
        List<VehicleBrand> GetAll(Expression<Func<VehicleBrand, bool>> filter = null);
        List<VehicleBrand> GetList(Expression<Func<VehicleBrand, bool>> filter);
        void Create(VehicleBrand entity);
        void Update(VehicleBrand entity);
        void Delete(VehicleBrand entity);
    }
}
