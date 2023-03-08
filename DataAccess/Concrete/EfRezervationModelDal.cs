using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfRezervationDal : EfCoreGenericDal<Rezervation, DataContext>, IRezervationDal
    {
    }
}
