using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class AdditionalServices : EntityBase
    {
        public string AdditionalServiceName { get; set; }
        public string ServicePrice { get; set; }

        public virtual List<Rezervation> Rezervations { get; set; }

        public AdditionalServices()
        {
            Rezervations = new List<Rezervation>();
        }
    }
}
