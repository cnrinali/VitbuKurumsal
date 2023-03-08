using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IVehicleModelService
    {
        VehicleModel GetById(Guid id);
        VehicleModel Get(Expression<Func<VehicleModel, bool>> filter);
        List<VehicleModel> GetAll(Expression<Func<VehicleModel, bool>> filter = null);
        List<VehicleModel> GetList(Expression<Func<VehicleModel, bool>> filter);
        void Create(VehicleModel entity);
        void Update(VehicleModel entity);
        void Delete(VehicleModel entity);
    }
}
