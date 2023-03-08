using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class PriceCarrier
    {
        [Key]
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }
        public Guid? PriceId { get; set; }
        public Guid VehicleCategoryId { get; set; }
        public string TotalPrice { get; set; }

        [ForeignKey("PriceId")]
        public virtual Price Price { get; set; }
        public virtual VehicleCategory VehicleCategory { get; set; }
        public virtual Company Company { get; set; }
    }
}
