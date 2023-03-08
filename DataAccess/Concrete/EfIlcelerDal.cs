using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfIlcelerDal : EfCoreGenericDal<Ilceler, DataContext>, IIlcelerDal
    {
    }
}
