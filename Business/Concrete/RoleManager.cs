using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public void Create(Role entity)
        {
            _roleDal.Create(entity);
        }

        public void Delete(Role entity)
        {
            _roleDal.Delete(entity);
        }

        public Role Get(Expression<Func<Role, bool>> filter)
        {
            return _roleDal.Get(filter);
        }

        public List<Role> GetAll(Expression<Func<Role, bool>> filter = null)
        {
            return _roleDal.GetAll();
        }
        

        public List<Role> GetList(Expression<Func<Role, bool>> filter)
        {
            return _roleDal.GetList(filter);
        }

        public Role GetById(Guid id)
        {
            return _roleDal.GetById(id);
        }

        public void Update(Role entity)
        {
            _roleDal.Update(entity);
        }
    }
}
