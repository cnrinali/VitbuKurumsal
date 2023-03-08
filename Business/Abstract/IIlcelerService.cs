using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IIlcelerService
    {
        Ilceler GetById(Guid id);
        Ilceler Get(Expression<Func<Ilceler, bool>> filter);
        List<Ilceler> GetAll(Expression<Func<Ilceler, bool>> filter = null);
        List<Ilceler> GetList(Expression<Func<Ilceler, bool>> filter);
        void Create(Ilceler entity);
        void Update(Ilceler entity);
        void Delete(Ilceler entity);
    }
}
