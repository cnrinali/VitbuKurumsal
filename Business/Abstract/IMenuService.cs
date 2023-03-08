using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMenuService
    {
        Menu GetById(Guid id);
        Menu Get(Expression<Func<Menu, bool>> filter);
        List<Menu> GetAll(Expression<Func<Menu, bool>> filter = null);
        List<Menu> GetList(Expression<Func<Menu, bool>> filter);
        void Create(Menu entity);
        void Update(Menu entity);
        void Delete(Menu entity);
    }
}
