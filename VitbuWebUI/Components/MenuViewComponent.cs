using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using VitbuWebUIPartnerPanel.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace VitbuWebUIPartnerPanel.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuCategoryService _menuCategoryService;
        private readonly IMenuService _menuService;
        private readonly IUserRoleService _userRoleService;
        private readonly IRoleAuthorizationService _roleAuthorizationService;


        public MenuViewComponent(IMenuCategoryService menuCategoryService, IMenuService menuService, IUserRoleService userRoleService, IRoleAuthorizationService roleAuthorizationService)
        {
            _menuCategoryService = menuCategoryService;
            _menuService = menuService;
            _userRoleService = userRoleService;
            _roleAuthorizationService = roleAuthorizationService;
        }

        public IViewComponentResult Invoke(Guid userId)
        {
            var filterMenu = new List<Menu>();
            var userRoleId = _userRoleService.GetList(x => x.UserId == userId);
            var roleAuthorizationMenu = new List<RoleAuthorization>();
            foreach (var item in userRoleId)
            {
                var data = _roleAuthorizationService.GetList(x => x.RoleId == item.RoleId);
                roleAuthorizationMenu.AddRange(data);
            }
            foreach (var item in roleAuthorizationMenu)
            {
                filterMenu.AddRange(_menuService.GetList(x => x.Id == item.MenuId));
            }

            var homelist = new HomeViewModel()
            {
                Menus = filterMenu,
                MenuCategories = _menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };

            return View("_PartialMenu", homelist);
        }
    }
}
