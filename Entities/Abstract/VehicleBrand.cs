using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class VehicleBrand : EntityBase
    {
        public string BrandName { get; set; }
        public string Description { get; set; }

        public virtual List<Vehicle> Vehicles { get; set; }

        public VehicleBrand()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}
