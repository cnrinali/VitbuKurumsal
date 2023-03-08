using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class MenuCategory : EntityBase
    {
        public string CategoryName { get; set; }
        public string StyleIcon { get; set; }

        public virtual List<Menu> Menus { get; set; }

        public MenuCategory()
        {
            Menus = new List<Menu>();
        }
    }
}
