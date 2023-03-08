using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract
{
    public class Ulkeler
    {
        [Key]
        public int UlkeId { get; set; }
        public string IkiliKod { get; set; }
        public string UcluKod { get; set; }
        public string UlkeAdi { get; set; }
        public string TelKodu { get; set; }
    }
}
