using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NameSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
        public virtual List<Rezervation> Rezervations { get; set; }

        public User()
        {
            Rezervations = new List<Rezervation>();
            UserRoles = new List<UserRole>();
        }

    }
}
