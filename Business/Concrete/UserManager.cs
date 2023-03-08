using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Create(User entity)
        {
            _userDal.Create(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _userDal.Get(filter);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.GetAll();
        }
        
        public List<User> GetList(Expression<Func<User, bool>> filter)
        {
            return _userDal.GetList(filter);
        }

        public User GetById(Guid id)
        {
            return _userDal.GetById(id);
        }

        public void Update(User entity)
        {
            _userDal.Update(entity);
        }

        public User Login(string mail, string password)
        {
            return _userDal.Get(x => x.UserName == mail && x.Password == password);
        }
    }
}
