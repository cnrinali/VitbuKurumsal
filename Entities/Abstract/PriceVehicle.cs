using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class PriceVehicle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? PriceId { get; set; }
        public Guid VehicleCategoryId { get; set; }
        public List<Rezervation> Rezervations { get; set; }

        [ForeignKey("PriceId")]
        public virtual Price Price { get; set; }
        public virtual VehicleCategory VehicleCategory { get; set; }

        public PriceVehicle()
        {
            Rezervations = new List<Rezervation>();
        }
    }
}
