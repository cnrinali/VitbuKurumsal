using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IRoleService
    {
        Role GetById(Guid id);
        Role Get(Expression<Func<Role, bool>> filter);
        List<Role> GetAll(Expression<Func<Role, bool>> filter = null);
        List<Role> GetList(Expression<Func<Role, bool>> filter);
        void Create(Role entity);
        void Update(Role entity);
        void Delete(Role entity);
    }
}
