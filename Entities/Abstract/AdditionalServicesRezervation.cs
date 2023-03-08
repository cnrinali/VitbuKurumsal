using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class AdditionalServicesRezervation : EntityBase
    {
        public Guid? AdditionalServicesId { get; set; }
        public Guid? RezervationId { get; set; }
        public string ServicePrice { get; set; }

        public virtual Rezervation Rezervations { get; set; }
    }
}
