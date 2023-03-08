using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VehicleModelManager : IVehicleModelService
    {
        IVehicleModelDal _vehicleModelDal;
        public VehicleModelManager(IVehicleModelDal vehicleModelDal)
        {
            _vehicleModelDal = vehicleModelDal;
        }
        public void Create(VehicleModel entity)
        {
            _vehicleModelDal.Create(entity);
        }

        public void Delete(VehicleModel entity)
        {
            _vehicleModelDal.Delete(entity);
        }

        public VehicleModel Get(Expression<Func<VehicleModel, bool>> filter)
        {
            return _vehicleModelDal.Get(filter);
        }

        public List<VehicleModel> GetAll(Expression<Func<VehicleModel, bool>> filter = null)
        {
            return _vehicleModelDal.GetAll();
        }
        
        public List<VehicleModel> GetList(Expression<Func<VehicleModel, bool>> filter)
        {
            return _vehicleModelDal.GetList(filter);
        }

        public VehicleModel GetById(Guid id)
        {
            return _vehicleModelDal.GetById(id);
        }

        public void Update(VehicleModel entity)
        {
            _vehicleModelDal.Update(entity);
        }
    }
}
