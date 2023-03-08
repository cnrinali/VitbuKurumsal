using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IAdditionalServicesService
    {
        AdditionalServices GetById(Guid id);
        AdditionalServices Get(Expression<Func<AdditionalServices, bool>> filter);
        List<AdditionalServices> GetAll(Expression<Func<AdditionalServices, bool>> filter = null);
        List<AdditionalServices> GetList(Expression<Func<AdditionalServices, bool>> filter);
        void Create(AdditionalServices entity);
        void Update(AdditionalServices entity);
        void Delete(AdditionalServices entity);
    }
}
