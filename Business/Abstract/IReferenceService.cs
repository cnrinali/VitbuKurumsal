using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IReferenceService
    {
        Reference GetById(Guid id);
        Reference Get(Expression<Func<Reference, bool>> filter);
        List<Reference> GetAll(Expression<Func<Reference, bool>> filter = null);
        List<Reference> GetList(Expression<Func<Reference, bool>> filter);
        void Create(Reference entity);
        void Update(Reference entity);
        void Delete(Reference entity);
    }
}
