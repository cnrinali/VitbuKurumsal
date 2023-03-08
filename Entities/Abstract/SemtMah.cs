using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract
{
    public class SemtMah
    {
        [Required]
        [Key]
        public int SemtMahId { get; set; }
        [Required]
        public string SemtAdi { get; set; }
        [Required]
        public string MahalleAdi { get; set; }
        [Required]
        public string PostaKodu { get; set; }
        [Required]
        public int ilceId { get; set; }

    }
}