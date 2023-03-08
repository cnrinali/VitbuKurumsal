using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;

namespace DataAccess.Concrete
{
    public class EfLogDal : EfCoreGenericDal<Log, DataContext>, ILogDal
    {
    }
}
