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
    public class RezervationManager : IRezervationService
    {
        IRezervationDal _rezervationDal;
        public RezervationManager(IRezervationDal rezervationDal)
        {
            _rezervationDal = rezervationDal;
        }
        public void Create(Rezervation entity)
        {
            _rezervationDal.Create(entity);
        }

        public void Delete(Rezervation entity)
        {
            _rezervationDal.Delete(entity);
        }

        public Rezervation Get(Expression<Func<Rezervation, bool>> filter)
        {
            return _rezervationDal.Get(filter);
        }

        public List<Rezervation> GetAll(Expression<Func<Rezervation, bool>> filter = null)
        {
            return _rezervationDal.GetAll();
        }
        
        public List<Rezervation> GetList(Expression<Func<Rezervation, bool>> filter)
        {
            return _rezervationDal.GetList(filter);
        }

        public Rezervation GetById(Guid id)
        {
            return _rezervationDal.GetById(id);
        }

        public void Update(Rezervation entity)
        {
            _rezervationDal.Update(entity);
        }
    }
}
