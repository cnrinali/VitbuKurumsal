using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Price
    {
        [Key]
        public Guid Id { get; set; }

        public string StartIlId { get; set; }
        public string StartIlceId { get; set; }
        public string StartSemtMahId { get; set; }

        public string EndIlId { get; set; }
        public string EndIlceId { get; set; }
        public string EndtSemtMahId { get; set; }
        public string TotalPrice { get; set; }

        public Guid? CompanyId { get; set; }
        public Guid? VehicleCategoryId { get; set; }

        public virtual VehicleCategory VehicleCategory { get; set; }
        public virtual Company Company { get; set; }

        public List<Rezervation> Rezervations { get; set; }

        public Price()
        {
            Rezervations = new List<Rezervation>();
        }
    }
}
