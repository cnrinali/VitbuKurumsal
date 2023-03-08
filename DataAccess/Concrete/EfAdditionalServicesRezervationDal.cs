using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfAdditionalServicesRezervationDal : EfCoreGenericDal<AdditionalServicesRezervation, DataContext>, IAdditionalServicesRezervationDal
    {
    }
}
