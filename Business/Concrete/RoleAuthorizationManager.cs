using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class RoleAuthorizationManager : IRoleAuthorizationService
    {
        IRoleAuthorizationDal _roleAuthorizationDal;
        public RoleAuthorizationManager(IRoleAuthorizationDal roleAuthorizationDal)
        {
            _roleAuthorizationDal = roleAuthorizationDal;
        }
        public void Create(RoleAuthorization entity)
        {
            _roleAuthorizationDal.Create(entity);
        }

        public void Delete(RoleAuthorization entity)
        {
            _roleAuthorizationDal.Delete(entity);
        }

        public RoleAuthorization Get(Expression<Func<RoleAuthorization, bool>> filter)
        {
            return _roleAuthorizationDal.Get(filter);
        }

        public List<RoleAuthorization> GetAll(Expression<Func<RoleAuthorization, bool>> filter = null)
        {
            return _roleAuthorizationDal.GetAll();
        }
        

        public List<RoleAuthorization> GetList(Expression<Func<RoleAuthorization, bool>> filter)
        {
            return _roleAuthorizationDal.GetList(filter);
        }

        public RoleAuthorization GetById(Guid id)
        {
            return _roleAuthorizationDal.GetById(id);
        }

        public void Update(RoleAuthorization entity)
        {
            _roleAuthorizationDal.Update(entity);
        }
    }
}
