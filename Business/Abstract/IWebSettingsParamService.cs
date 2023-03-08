using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IWebSettingsParamService
    {
        WebSettingsParam GetById(Guid id);
        WebSettingsParam Get(Expression<Func<WebSettingsParam, bool>> filter);
        List<WebSettingsParam> GetAll(Expression<Func<WebSettingsParam, bool>> filter = null);
        List<WebSettingsParam> GetList(Expression<Func<WebSettingsParam, bool>> filter);
        void Create(WebSettingsParam entity);
        void Update(WebSettingsParam entity);
        void Delete(WebSettingsParam entity);
    }
}
