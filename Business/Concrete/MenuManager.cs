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
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;
        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }
        public void Create(Menu entity)
        {
            _menuDal.Create(entity);
        }

        public void Delete(Menu entity)
        {
            _menuDal.Delete(entity);
        }

        public Menu Get(Expression<Func<Menu, bool>> filter)
        {
            return _menuDal.Get(filter);
        }

        public List<Menu> GetAll(Expression<Func<Menu, bool>> filter = null)
        {
            return _menuDal.GetAll();
        }
        

        public List<Menu> GetList(Expression<Func<Menu, bool>> filter)
        {
            return _menuDal.GetList(filter);
        }

        public Menu GetById(Guid id)
        {
            return _menuDal.GetById(id);
        }

        public void Update(Menu entity)
        {
            _menuDal.Update(entity);
        }
    }
}
