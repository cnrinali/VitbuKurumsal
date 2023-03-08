using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IAdditionalServicesRezervationService
    {
        AdditionalServicesRezervation GetById(Guid id);
        AdditionalServicesRezervation Get(Expression<Func<AdditionalServicesRezervation, bool>> filter);
        List<AdditionalServicesRezervation> GetAll(Expression<Func<AdditionalServicesRezervation, bool>> filter = null);
        List<AdditionalServicesRezervation> GetList(Expression<Func<AdditionalServicesRezervation, bool>> filter);
        void Create(AdditionalServicesRezervation entity);
        void Update(AdditionalServicesRezervation entity);
        void Delete(AdditionalServicesRezervation entity);
    }
}
