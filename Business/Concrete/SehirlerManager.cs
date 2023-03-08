using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class SehirlerManager : ISehirlerService
    {
        ISehirlerDal _sehirlerDal;
        public SehirlerManager(ISehirlerDal sehirlerDal)
        {
            _sehirlerDal = sehirlerDal;
        }
        public void Create(Sehirler entity)
        {
            _sehirlerDal.Create(entity);
        }

        public void Delete(Sehirler entity)
        {
            _sehirlerDal.Delete(entity);
        }

        public Sehirler Get(Expression<Func<Sehirler, bool>> filter)
        {
            return _sehirlerDal.Get(filter);
        }

        public List<Sehirler> GetAll(Expression<Func<Sehirler, bool>> filter = null)
        {
            return _sehirlerDal.GetAll();
        }
        
        public List<Sehirler> GetList(Expression<Func<Sehirler, bool>> filter)
        {
            return _sehirlerDal.GetList(filter);
        }

        public Sehirler GetById(Guid id)
        {
            return _sehirlerDal.GetById(id);
        }

        public void Update(Sehirler entity)
        {
            _sehirlerDal.Update(entity);
        }
    }
}
