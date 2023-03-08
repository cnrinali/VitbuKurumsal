using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class VehicleModel : EntityBase
    {
        public string ModelName { get; set; }
        public string Description { get; set; }

        public virtual VehicleBrand VehicleBrands { get; set; }
        public virtual List<Vehicle> Vehicles { get; set; }

        public VehicleModel()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}
