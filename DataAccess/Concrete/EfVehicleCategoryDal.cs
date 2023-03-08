using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfVehicleCategoryDal : EfCoreGenericDal<VehicleCategory, DataContext>, IVehicleCategoryDal
    {
    }
}
