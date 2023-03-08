using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IVehicleService
    {
        Vehicle GetById(Guid id);
        Vehicle Get(Expression<Func<Vehicle, bool>> filter);
        List<Vehicle> GetAll(Expression<Func<Vehicle, bool>> filter = null);
        List<Vehicle> GetList(Expression<Func<Vehicle, bool>> filter);
        void Create(Vehicle entity);
        void Update(Vehicle entity);
        void Delete(Vehicle entity);
    }
}
