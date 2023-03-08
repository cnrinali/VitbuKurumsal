using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class AdditionalServicesManager : IAdditionalServicesService
    {
        IAdditionalServicesDal _additionalServicesDal;
        public AdditionalServicesManager(IAdditionalServicesDal additionalServicesDal)
        {
            _additionalServicesDal = additionalServicesDal;
        }
        public void Create(AdditionalServices entity)
        {
            _additionalServicesDal.Create(entity);
        }

        public void Delete(AdditionalServices entity)
        {
            _additionalServicesDal.Delete(entity);
        }

        public AdditionalServices Get(Expression<Func<AdditionalServices, bool>> filter)
        {
            return _additionalServicesDal.Get(filter);
        }

        public List<AdditionalServices> GetAll(Expression<Func<AdditionalServices, bool>> filter = null)
        {
            return _additionalServicesDal.GetAll();
        }
        public List<AdditionalServices> GetList(Expression<Func<AdditionalServices, bool>> filter)
        {
            return _additionalServicesDal.GetList(filter);
        }

        public AdditionalServices GetById(Guid id)
        {
            return _additionalServicesDal.GetById(id);
        }

        public void Update(AdditionalServices entity)
        {
            _additionalServicesDal.Update(entity);
        }
    }
}
