using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Vehicle : EntityBase
    {
        public string VehiclePlate { get; set; }
        public string VehicleStartKm { get; set; }
        public string VehicleChassis { get; set; }
        public string VehiclePrice { get; set; }

        public Guid CompanyId { get; set; }
        public Guid VehicleBrandId { get; set; }
        public Guid VehicleModelId { get; set; }
        public Guid VehicleCategoryId { get; set; }

        public virtual VehicleBrand VehicleBrands { get; set; }
        public virtual VehicleModel VehicleModels { get; set; }
        public virtual Company Companies { get; set; }
        public virtual VehicleCategory VehicleCategory { get; set; }
    }
}
