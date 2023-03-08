using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class RoleAuthorization : EntityBase
    {
        public Guid RoleId { get; set; }
        public Guid MenuId { get; set; }


        public virtual Role Role { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
