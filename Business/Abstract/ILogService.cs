using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ILogService
    {
        Log GetById(Guid id);
        Log Get(Expression<Func<Log, bool>> filter);
        List<Log> GetAll(Expression<Func<Log, bool>> filter = null);
        List<Log> GetList(Expression<Func<Log, bool>> filter);
        void Create(Log entity);
        void Update(Log entity);
        void Delete(Log entity);
    }
}
