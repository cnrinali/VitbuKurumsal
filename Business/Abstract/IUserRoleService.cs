using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserRoleService
    {
        UserRole GetById(Guid id);
        UserRole Get(Expression<Func<UserRole, bool>> filter);
        List<UserRole> GetAll(Expression<Func<UserRole, bool>> filter = null);
        List<UserRole> GetList(Expression<Func<UserRole, bool>> filter);
        void Create(UserRole entity);
        void Update(UserRole entity);
        void Delete(UserRole entity);
    }
}
