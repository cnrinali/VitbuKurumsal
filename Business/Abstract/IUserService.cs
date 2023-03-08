using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        User GetById(Guid id);
        User Get(Expression<Func<User, bool>> filter);
        List<User> GetAll(Expression<Func<User, bool>> filter = null);
        List<User> GetList(Expression<Func<User, bool>> filter);
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
        User Login(string mail, string password);
    }
}
