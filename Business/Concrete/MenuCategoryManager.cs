using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class MenuCategoryManager : IMenuCategoryService
    {
        IMenuCategoryDal _menuCategoryDal;
        public MenuCategoryManager(IMenuCategoryDal menuCategoryDal)
        {
            _menuCategoryDal = menuCategoryDal;
        }
        public void Create(MenuCategory entity)
        {
            _menuCategoryDal.Create(entity);
        }

        public void Delete(MenuCategory entity)
        {
            _menuCategoryDal.Delete(entity);
        }

        public MenuCategory Get(Expression<Func<MenuCategory, bool>> filter)
        {
            return _menuCategoryDal.Get(filter);
        }

        public List<MenuCategory> GetAll(Expression<Func<MenuCategory, bool>> filter = null)
        {
            return _menuCategoryDal.GetAll();
        }
        

        public List<MenuCategory> GetList(Expression<Func<MenuCategory, bool>> filter)
        {
            return _menuCategoryDal.GetList(filter);
        }

        public MenuCategory GetById(Guid id)
        {
            return _menuCategoryDal.GetById(id);
        }

        public void Update(MenuCategory entity)
        {
            _menuCategoryDal.Update(entity);
        }
    }
}
