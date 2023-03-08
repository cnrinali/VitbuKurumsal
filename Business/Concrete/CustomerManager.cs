using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Create(Customer entity)
        {
            _customerDal.Create(entity);
        }

        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return _customerDal.Get(filter);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _customerDal.GetAll();
        }
        public List<Customer> GetList(Expression<Func<Customer, bool>> filter)
        {
            return _customerDal.GetList(filter);
        }

        public Customer GetById(Guid id)
        {
            return _customerDal.GetById(id);
        }

        public void Update(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
