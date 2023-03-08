using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfMenuDal : EfCoreGenericDal<Menu, DataContext>, IMenuDal
    {
    }
}
