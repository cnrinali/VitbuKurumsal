using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IPriceVehicleService
    {
        PriceVehicle GetById(Guid id);
        PriceVehicle Get(Expression<Func<PriceVehicle, bool>> filter);
        List<PriceVehicle> GetAll(Expression<Func<PriceVehicle, bool>> filter = null);
        List<PriceVehicle> GetList(Expression<Func<PriceVehicle, bool>> filter);
        void Create(PriceVehicle entity);
        void Update(PriceVehicle entity);
        void Delete(PriceVehicle entity);
    }
}
