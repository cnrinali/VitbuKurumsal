using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Menu : EntityBase
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Descreption { get; set; }
        public Guid MenuCategoryId { get; set; }

        public virtual MenuCategory MenuCategory { get; set; }
        public virtual List<RoleAuthorization> RoleAuthorizations { get; set; }

        public Menu()
        {
            RoleAuthorizations = new List<RoleAuthorization>();
        }
    }
}
