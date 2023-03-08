using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IRoleAuthorizationService
    {
        RoleAuthorization GetById(Guid id);
        RoleAuthorization Get(Expression<Func<RoleAuthorization, bool>> filter);
        List<RoleAuthorization> GetAll(Expression<Func<RoleAuthorization, bool>> filter = null);
        List<RoleAuthorization> GetList(Expression<Func<RoleAuthorization, bool>> filter);
        void Create(RoleAuthorization entity);
        void Update(RoleAuthorization entity);
        void Delete(RoleAuthorization entity);
    }
}
