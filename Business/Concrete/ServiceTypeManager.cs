using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ServiceTypeManager : IServiceTypeService
    {
        IServiceTypeDal _serviceTypeDal;
        public ServiceTypeManager(IServiceTypeDal serviceTypeDal)
        {
            _serviceTypeDal = serviceTypeDal;
        }
        public void Create(ServiceType entity)
        {
            _serviceTypeDal.Create(entity);
        }

        public void Delete(ServiceType entity)
        {
            _serviceTypeDal.Delete(entity);
        }

        public ServiceType Get(Expression<Func<ServiceType, bool>> filter)
        {
            return _serviceTypeDal.Get(filter);
        }

        public List<ServiceType> GetAll(Expression<Func<ServiceType, bool>> filter = null)
        {
            return _serviceTypeDal.GetAll();
        }
        public List<ServiceType> GetList(Expression<Func<ServiceType, bool>> filter)
        {
            return _serviceTypeDal.GetList(filter);
        }

        public ServiceType GetById(Guid id)
        {
            return _serviceTypeDal.GetById(id);
        }

        public void Update(ServiceType entity)
        {
            _serviceTypeDal.Update(entity);
        }
    }
}
