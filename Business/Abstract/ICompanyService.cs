using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        Company GetById(Guid id);
        Company Get(Expression<Func<Company, bool>> filter);
        List<Company> GetAll(Expression<Func<Company, bool>> filter = null);
        List<Company> GetList(Expression<Func<Company, bool>> filter);
        void Create(Company entity);
        void Update(Company entity);
        void Delete(Company entity);
    }
}
