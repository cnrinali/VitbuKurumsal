using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class LogManager : ILogService
    {
        ILogDal _logDal;
        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }
        public void Create(Log entity)
        {
            _logDal.Create(entity);
        }

        public void Delete(Log entity)
        {
            _logDal.Delete(entity);
        }

        public Log Get(Expression<Func<Log, bool>> filter)
        {
            return _logDal.Get(filter);
        }

        public List<Log> GetAll(Expression<Func<Log, bool>> filter = null)
        {
            return _logDal.GetAll();
        }

        public List<Log> GetList(Expression<Func<Log, bool>> filter)
        {
            return _logDal.GetList(filter);
        }

        public Log GetById(Guid id)
        {
            return _logDal.GetById(id);
        }

        public void Update(Log entity)
        {
            _logDal.Update(entity);
        }
    }
}