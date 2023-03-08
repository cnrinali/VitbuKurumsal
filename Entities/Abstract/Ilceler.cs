using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract
{
    public class Ilceler
    {
        [Required]
        [Key]
        public int ilceId { get; set; }
        [Required]
        public int SehirId { get; set; }
        [Required]
        public string IlceAdi { get; set; }
        [Required]
        public string SehirAdi { get; set; }
    }
}
