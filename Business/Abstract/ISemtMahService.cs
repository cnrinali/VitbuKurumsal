using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ISemtMahService
    {
        SemtMah GetById(Guid id);
        SemtMah Get(Expression<Func<SemtMah, bool>> filter);
        List<SemtMah> GetAll(Expression<Func<SemtMah, bool>> filter = null);
        List<SemtMah> GetList(Expression<Func<SemtMah, bool>> filter);
        void Create(SemtMah entity);
        void Update(SemtMah entity);
        void Delete(SemtMah entity);
    }
}
