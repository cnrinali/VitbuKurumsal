using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class StatuManager : IStatuService
    {
        IStatuDal _statuDal;
        public StatuManager(IStatuDal statuDal)
        {
            _statuDal = statuDal;
        }
        public void Create(Statu entity)
        {
            _statuDal.Create(entity);
        }

        public void Delete(Statu entity)
        {
            _statuDal.Delete(entity);
        }

        public Statu Get(Expression<Func<Statu, bool>> filter)
        {
            return _statuDal.Get(filter);
        }

        public List<Statu> GetAll(Expression<Func<Statu, bool>> filter = null)
        {
            return _statuDal.GetAll();
        }
        public List<Statu> GetList(Expression<Func<Statu, bool>> filter)
        {
            return _statuDal.GetList(filter);
        }

        public Statu GetById(Guid id)
        {
            return _statuDal.GetById(id);
        }

        public void Update(Statu entity)
        {
            _statuDal.Update(entity);
        }
    }
}
