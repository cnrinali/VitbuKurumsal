using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IRezervationService
    {
        Rezervation GetById(Guid id);
        Rezervation Get(Expression<Func<Rezervation, bool>> filter);
        List<Rezervation> GetAll(Expression<Func<Rezervation, bool>> filter = null);
        List<Rezervation> GetList(Expression<Func<Rezervation, bool>> filter);
        void Create(Rezervation entity);
        void Update(Rezervation entity);
        void Delete(Rezervation entity);
    }
}
