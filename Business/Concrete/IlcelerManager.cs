using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class IlcelerManager : IIlcelerService
    {
        IIlcelerDal _ilcelerDal;
        public IlcelerManager(IIlcelerDal ilcelerDal)
        {
            _ilcelerDal = ilcelerDal;
        }
        public void Create(Ilceler entity)
        {
            _ilcelerDal.Create(entity);
        }

        public void Delete(Ilceler entity)
        {
            _ilcelerDal.Delete(entity);
        }

        public Ilceler Get(Expression<Func<Ilceler, bool>> filter)
        {
            return _ilcelerDal.Get(filter);
        }

        public List<Ilceler> GetAll(Expression<Func<Ilceler, bool>> filter = null)
        {
            return _ilcelerDal.GetAll();
        }
        
        public List<Ilceler> GetList(Expression<Func<Ilceler, bool>> filter)
        {
            return _ilcelerDal.GetList(filter);
        }

        public Ilceler GetById(Guid id)
        {
            return _ilcelerDal.GetById(id);
        }

        public void Update(Ilceler entity)
        {
            _ilcelerDal.Update(entity);
        }
    }
}
