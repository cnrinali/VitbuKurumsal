using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfUserRoleDal : EfCoreGenericDal<UserRole, DataContext>, IUserRoleDal
    {
    }
}
