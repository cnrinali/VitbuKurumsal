using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMenuCategoryService
    {
        MenuCategory GetById(Guid id);
        MenuCategory Get(Expression<Func<MenuCategory, bool>> filter);
        List<MenuCategory> GetAll(Expression<Func<MenuCategory, bool>> filter = null);
        List<MenuCategory> GetList(Expression<Func<MenuCategory, bool>> filter);
        void Create(MenuCategory entity);
        void Update(MenuCategory entity);
        void Delete(MenuCategory entity);
    }
}
