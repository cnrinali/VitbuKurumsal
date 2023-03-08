using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class VehicleCategory : EntityBase
    {
        public string CategoryName { get; set; }

        public virtual List<Vehicle> Vehicles { get; set; }
        public List<Price> Prices { get; set; }

        public VehicleCategory()
        {
            Vehicles = new List<Vehicle>();
            Prices = new List<Price>();
        }
    }
}
