using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class SemtMahManager : ISemtMahService
    {
        ISemtMahDal _semMahDal;
        public SemtMahManager(ISemtMahDal semtMahDal)
        {
            _semMahDal = semtMahDal;
        }
        public void Create(SemtMah entity)
        {
            _semMahDal.Create(entity);
        }

        public void Delete(SemtMah entity)
        {
            _semMahDal.Delete(entity);
        }

        public SemtMah Get(Expression<Func<SemtMah, bool>> filter)
        {
            return _semMahDal.Get(filter);
        }

        public List<SemtMah> GetAll(Expression<Func<SemtMah, bool>> filter = null)
        {
            return _semMahDal.GetAll();
        }
        
        public List<SemtMah> GetList(Expression<Func<SemtMah, bool>> filter)
        {
            return _semMahDal.GetList(filter);
        }

        public SemtMah GetById(Guid id)
        {
            return _semMahDal.GetById(id);
        }

        public void Update(SemtMah entity)
        {
            _semMahDal.Update(entity);
        }
    }
}
