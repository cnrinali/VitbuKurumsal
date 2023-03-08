using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IServiceTypeService
    {
        ServiceType GetById(Guid id);
        ServiceType Get(Expression<Func<ServiceType, bool>> filter);
        List<ServiceType> GetAll(Expression<Func<ServiceType, bool>> filter = null);
        List<ServiceType> GetList(Expression<Func<ServiceType, bool>> filter);
        void Create(ServiceType entity);
        void Update(ServiceType entity);
        void Delete(ServiceType entity);
    }
}
