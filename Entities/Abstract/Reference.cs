using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Reference : EntityBase
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual List<Rezervation> Rezervations { get; set; }

        public Reference()
        {
            Rezervations = new List<Rezervation>();
        }
    }
}
