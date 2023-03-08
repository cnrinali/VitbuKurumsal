using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Customer GetById(Guid id);
        Customer Get(Expression<Func<Customer, bool>> filter);
        List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null);
        List<Customer> GetList(Expression<Func<Customer, bool>> filter);
        void Create(Customer entity);
        void Update(Customer entity);
        void Delete(Customer entity);
    }
}
