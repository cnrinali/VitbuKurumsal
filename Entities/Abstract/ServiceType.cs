using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class ServiceType : EntityBase
    {
        public string ServiceName { get; set; }

        public virtual List<Rezervation> Rezervations { get; set; }

        public ServiceType()
        {
            Rezervations = new List<Rezervation>();
        }
    }
}
