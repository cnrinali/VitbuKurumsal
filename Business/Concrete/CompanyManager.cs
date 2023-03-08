using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public void Create(Company entity)
        {
            _companyDal.Create(entity);
        }

        public void Delete(Company entity)
        {
            _companyDal.Delete(entity);
        }

        public Company Get(Expression<Func<Company, bool>> filter)
        {
            return _companyDal.Get(filter);
        }

        public List<Company> GetAll(Expression<Func<Company, bool>> filter = null)
        {
            return _companyDal.GetAll();
        }
        public List<Company> GetList(Expression<Func<Company, bool>> filter)
        {
            return _companyDal.GetList(filter);
        }

        public Company GetById(Guid id)
        {
            return _companyDal.GetById(id);
        }

        public void Update(Company entity)
        {
            _companyDal.Update(entity);
        }
    }
}
