using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class AdditionalServicesRezervationManager : IAdditionalServicesRezervationService
    {
        IAdditionalServicesRezervationDal _additionalServicesRezervationDal;
        public AdditionalServicesRezervationManager(IAdditionalServicesRezervationDal additionalServicesRezervationDal)
        {
            _additionalServicesRezervationDal = additionalServicesRezervationDal;
        }
        public void Create(AdditionalServicesRezervation entity)
        {
            _additionalServicesRezervationDal.Create(entity);
        }

        public void Delete(AdditionalServicesRezervation entity)
        {
            _additionalServicesRezervationDal.Delete(entity);
        }

        public AdditionalServicesRezervation Get(Expression<Func<AdditionalServicesRezervation, bool>> filter)
        {
            return _additionalServicesRezervationDal.Get(filter);
        }

        public List<AdditionalServicesRezervation> GetAll(Expression<Func<AdditionalServicesRezervation, bool>> filter = null)
        {
            return _additionalServicesRezervationDal.GetAll();
        }
        public List<AdditionalServicesRezervation> GetList(Expression<Func<AdditionalServicesRezervation, bool>> filter)
        {
            return _additionalServicesRezervationDal.GetList(filter);
        }

        public AdditionalServicesRezervation GetById(Guid id)
        {
            return _additionalServicesRezervationDal.GetById(id);
        }

        public void Update(AdditionalServicesRezervation entity)
        {
            _additionalServicesRezervationDal.Update(entity);
        }
    }
}
