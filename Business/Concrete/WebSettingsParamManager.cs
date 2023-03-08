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
    public class WebSettingsParamManager : IWebSettingsParamService
    {
        IWebSettingsParamDal _webSettingsParamDal;
        public WebSettingsParamManager(IWebSettingsParamDal webSettingsParamDal)
        {
            _webSettingsParamDal = webSettingsParamDal;
        }
        public void Create(WebSettingsParam entity)
        {
            _webSettingsParamDal.Create(entity);
        }

        public void Delete(WebSettingsParam entity)
        {
            _webSettingsParamDal.Delete(entity);
        }

        public WebSettingsParam Get(Expression<Func<WebSettingsParam, bool>> filter)
        {
            return _webSettingsParamDal.Get(filter);
        }

        public List<WebSettingsParam> GetAll(Expression<Func<WebSettingsParam, bool>> filter = null)
        {
            return _webSettingsParamDal.GetAll();
        }
        
        public List<WebSettingsParam> GetList(Expression<Func<WebSettingsParam, bool>> filter)
        {
            return _webSettingsParamDal.GetList(filter);
        }

        public WebSettingsParam GetById(Guid id)
        {
            return _webSettingsParamDal.GetById(id);
        }

        public void Update(WebSettingsParam entity)
        {
            _webSettingsParamDal.Update(entity);
        }
    }
}
