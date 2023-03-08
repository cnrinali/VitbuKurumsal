using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Route : EntityBase
    {
        public string RoleName { get; set; }
        public string Description { get; set; }

        public virtual List<RoleAuthorization> RoleAuthorizations { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }

        public Route()
        {
            RoleAuthorizations = new List<RoleAuthorization>();
            UserRoles = new List<UserRole>();
        }
    }
}
