using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class VehicleManager : IVehicleService
    {
        IVehicleDal _vehicleDal;
        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }
        public void Create(Vehicle entity)
        {
            _vehicleDal.Create(entity);
        }

        public void Delete(Vehicle entity)
        {
            _vehicleDal.Delete(entity);
        }

        public Vehicle Get(Expression<Func<Vehicle, bool>> filter)
        {
            return _vehicleDal.Get(filter);
        }

        public List<Vehicle> GetAll(Expression<Func<Vehicle, bool>> filter = null)
        {
            return _vehicleDal.GetAll();
        }
        
        public List<Vehicle> GetList(Expression<Func<Vehicle, bool>> filter)
        {
            return _vehicleDal.GetList(filter);
        }

        public Vehicle GetById(Guid id)
        {
            return _vehicleDal.GetById(id);
        }

        public void Update(Vehicle entity)
        {
            _vehicleDal.Update(entity);
        }
    }
}
