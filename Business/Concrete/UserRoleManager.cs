using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        IUserRoleDal _userRoleDal;
        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }
        public void Create(UserRole entity)
        {
            _userRoleDal.Create(entity);
        }

        public void Delete(UserRole entity)
        {
            _userRoleDal.Delete(entity);
        }

        public UserRole Get(Expression<Func<UserRole, bool>> filter)
        {
            return _userRoleDal.Get(filter);
        }

        public List<UserRole> GetAll(Expression<Func<UserRole, bool>> filter = null)
        {
            return _userRoleDal.GetAll();
        }
        
        public List<UserRole> GetList(Expression<Func<UserRole, bool>> filter)
        {
            return _userRoleDal.GetList(filter);
        }

        public UserRole GetById(Guid id)
        {
            return _userRoleDal.GetById(id);
        }

        public void Update(UserRole entity)
        {
            _userRoleDal.Update(entity);
        }
    }
}
