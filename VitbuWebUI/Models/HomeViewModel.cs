using Entities.Abstract;
using System.Collections.Generic;

namespace VitbuWebUIPartnerPanel.Models
{
    public class HomeViewModel
    {
        public List<Menu> Menus { get; set; }
        public List<MenuCategory> MenuCategories { get; set; }

    }
}
