using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ReferenceManager : IReferenceService
    {
        IReferenceDal _referenceDal;
        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }
        public void Create(Reference entity)
        {
            _referenceDal.Create(entity);
        }

        public void Delete(Reference entity)
        {
            _referenceDal.Delete(entity);
        }

        public Reference Get(Expression<Func<Reference, bool>> filter)
        {
            return _referenceDal.Get(filter);
        }

        public List<Reference> GetAll(Expression<Func<Reference, bool>> filter = null)
        {
            return _referenceDal.GetAll();
        }
        public List<Reference> GetList(Expression<Func<Reference, bool>> filter)
        {
            return _referenceDal.GetList(filter);
        }

        public Reference GetById(Guid id)
        {
            return _referenceDal.GetById(id);
        }

        public void Update(Reference entity)
        {
            _referenceDal.Update(entity);
        }
    }
}
