using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract
{
    public class Sehirler
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SehirId { get; set; }
        [Required]
        public string SehirAdi { get; set; }
        [Required]
        public byte PlakaNo { get; set; }
        [Required]
        public int TelefonKodu { get; set; }
        [Required]
        public int RowNumber { get; set; }
    }
}
