using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System;
using System.Security.Claims;
using System.Collections.Generic;
using VitbuWebUIPartnerPanel.Models;

namespace VitbuWebUIPartnerPanel.Controllers
{
    public class AppRoleController : Controller
    {
        IMenuCategoryService _menuCategoryService;
        IMenuService _menuService;
        IRoleService _roleService;
        IUserRoleService _userRoleService;
        IRoleAuthorizationService _roleAuthorizationService;
        IUserService _userService;
        public AppRoleController(IMenuCategoryService menuCategoryService, IMenuService menuService, IRoleService roleService, IUserRoleService userRoleService, IRoleAuthorizationService roleAuthorizationService, IUserService userService)
        {
            _menuCategoryService = menuCategoryService;
            _menuService = menuService;
            _roleService = roleService;
            _userRoleService = userRoleService;
            _roleAuthorizationService = roleAuthorizationService;
            _userService = userService;
        }

        [HttpGet, Route("superadmin/rolelist")]
        public IActionResult RoleList()
        {
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Roles = _roleService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);
        }
        [HttpGet, Route("superadmin/testrolelist")]
        public IActionResult TestRoleList()
        {
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Roles = _roleService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);

        }
        [HttpPost, Route("superadmin/testroleedit")]
        public IActionResult TestRoleEdit(Role role)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _roleService.Update(role);

            return Ok("Başarılı!");
        }

        [HttpGet, Route("superadmin/roleadd")]
        public IActionResult RoleAdd()
        {
            return View();
        }
        [HttpPost, Route("superadmin/roleadd")]
        public IActionResult RoleAdd(Role role)
        {
            if (!ModelState.IsValid)
                return View(role);
            else
                _roleService.Create(role);

            return View();
        }
        [HttpPost, Route("superadmin/rolemodaladd")]
        public IActionResult RoleModalAdd(Role role)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _roleService.Create(role);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("superadmin/roleedit")]
        public IActionResult RoleEdit(Role role)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _roleService.Update(role);

            return Ok("Başarılı!");
        }
        [HttpGet, Route("superadmin/userrolelist")]
        public IActionResult UserRoleList()
        {
            ViewBag.RoleId = _roleService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.UserId = _userService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                UserRoles = _userRoleService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                Users = _userService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                Roles = _roleService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };

            return View(model);
        }
        [HttpGet, Route("superadmin/userroleadd")]
        public IActionResult UserRoleAdd()
        {
            ViewBag.RoleId = new SelectList(_roleService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "RoleName");
            ViewBag.UserId = new SelectList(_userService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "UserName");

            return View();
        }
        [HttpPost, Route("superadmin/userroleadd")]
        public IActionResult UserRoleAdd(UserRole userRole)
        {
            ViewBag.RoleId = new SelectList(_roleService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "RoleName");
            ViewBag.UserId = new SelectList(_userService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "UserName");

            if (!ModelState.IsValid)
                return View(userRole);
            else
                _userRoleService.Create(userRole);

            return View();
        }
        [HttpPost, Route("superadmin/userrolemodaladd")]
        public IActionResult UserRoleModalAdd(UserRole userRole)
        {
            ViewBag.RoleId = new SelectList(_roleService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "RoleName");
            ViewBag.UserId = new SelectList(_userService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "UserName");

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _userRoleService.Create(userRole);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("superadmin/userroleedit")]
        public IActionResult UserRoleEdit(UserRole userRole)
        {
            ViewBag.RoleId = _roleService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.UserId = _userService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _userRoleService.Update(userRole);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("superadmin/roleauthorizationsedit")]
        public IActionResult RoleAuthorizationsEdit(RoleAuthorization roleAuthorization)
        {
            ViewBag.RoleId = _roleService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.MenuId = _menuService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _roleAuthorizationService.Update(roleAuthorization);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("superadmin/roleauthorizationsmodaladd")]
        public IActionResult RoleAuthorizationsModalAdd(RoleAuthorization roleAuthorization)
        {
            var roledata = _roleAuthorizationService.GetList(x => x.RoleId == roleAuthorization.RoleId);
            var menudata = roledata.Where(x => x.MenuId == roleAuthorization.MenuId)?.ToList();

            ViewBag.RoleId = new SelectList(_roleService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "RoleName");
            ViewBag.MenuId = new SelectList(_menuService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "Url");

            if (!ModelState.IsValid || (menudata.Count > 0 && roledata.Count > 0))
                return Ok("Başarısız!");
            else
                _roleAuthorizationService.Create(roleAuthorization);

            return Ok("Başarılı!");
        }
        [HttpGet, Route("superadmin/roleauthorizationslist")]
        public IActionResult RoleAuthorizationsList()
        {
            ViewBag.RoleId = _roleService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.MenuId = _menuService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                RoleAuthorizations = _roleAuthorizationService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                Roles = _roleService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                Menus = _menuService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);
        }
        [HttpGet, Route("superadmin/roleauthorizationsadd")]
        public IActionResult RoleAuthorizationsAdd()
        {
            ViewBag.RoleId = new SelectList(_roleService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "RoleName");
            ViewBag.MenuId = new SelectList(_menuService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "Url");
            return View();
        }
        [HttpPost, Route("superadmin/roleauthorizationsadd")]
        public IActionResult RoleAuthorizationsAdd(RoleAuthorization roleAuthorization)
        {
            var roledata = _roleAuthorizationService.GetList(x => x.RoleId == roleAuthorization.RoleId);
            var menudata = roledata.Where(x => x.MenuId == roleAuthorization.MenuId)?.ToList();

            ViewBag.RoleId = new SelectList(_roleService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "RoleName");
            ViewBag.MenuId = new SelectList(_menuService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "Url");

            if (!ModelState.IsValid || (menudata.Count > 0 && roledata.Count > 0))
                return View(roleAuthorization);
            else
                _roleAuthorizationService.Create(roleAuthorization);

            return View();
        }
        [HttpPost, Route("superadmin/menuedit")]
        public IActionResult MenuEdit(Menu menu)
        {
            ViewBag.MenuCategoryId = _menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _menuService.Update(menu);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("superadmin/menumodaladd")]
        public IActionResult MenuModalAdd (Menu menu)
        {
            ViewBag.MenuCategoryId = _menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _menuService.Create(menu);

            return Ok("Başarılı!");
        }
        [HttpGet, Route("superadmin/menulist")]
        public IActionResult MenuList()
        {
            ViewBag.MenuCategoryId = _menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                MenuCategories = _menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                Menus = _menuService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);
        }
        [HttpGet, Route("superadmin/menuadd")]
        public IActionResult MenuAdd()
        {
            ViewBag.MenuCategoryId = new SelectList(_menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "CategoryName");

            //ViewBag.MenuCategoryId = _menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            return View();
        }
        [HttpPost, Route("superadmin/menuadd")]
        public IActionResult MenuAdd(Menu menu)
        {

            ViewBag.MenuCategoryId = new SelectList(_menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "CategoryName");
            if (!ModelState.IsValid)
                return View(menu);
            else
            {
                _menuService.Create(menu);
                var menus = _menuService.GetList(x => x.MenuCategoryId == menu.MenuCategoryId);
                var data = _menuCategoryService.Get(x => x.Id == menu.MenuCategoryId);
                MenuCategory menuCategory = new MenuCategory()
                {
                    Id = data.Id,
                    CategoryName = data.CategoryName,
                    Menus = menus,
                    StatusId = data.StatusId,
                    StyleIcon = data.StyleIcon,
                };
                _menuCategoryService.Update(menuCategory);
            }

            return View();
        }
        [HttpPost, Route("superadmin/menucategoryedit")]
        public IActionResult MenuCategoryEdit(MenuCategory menuCategory)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _menuCategoryService.Update(menuCategory);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("superadmin/menucategorymodaladd")]
        public IActionResult MenuCategoryModalAdd(MenuCategory menuCategory)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _menuCategoryService.Create(menuCategory);

            return Ok("Başarılı!");
        }
        [HttpGet, Route("superadmin/menucategorylist")]
        public IActionResult MenuCategoryList()
        {
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                MenuCategories = _menuCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);
        }
        [HttpGet, Route("superadmin/menucategoryadd")]
        public IActionResult MenuCategoryAdd()
        {
            return View();
        }
        [HttpPost, Route("superadmin/menucategoryadd")]
        public IActionResult MenuCategoryAdd(MenuCategory menuCategory)
        {
            if (!ModelState.IsValid)
                return View(menuCategory);
            else
                _menuCategoryService.Create(menuCategory);

            return View();
        }
        public IActionResult DeleteMenu(Guid id)
        {
            var entity = _menuService.GetById(id);

            if (entity != null)
            {
                _menuService.Delete(entity);
            }

            return RedirectToAction("MenuList");
        }
        public IActionResult DeleteMenuCategory(Guid id)
        {
            var entity = _menuCategoryService.GetById(id);

            if (entity != null)
            {
                _menuCategoryService.Delete(entity);
            }

            return RedirectToAction("MenuCategoryList");
        }
        public IActionResult DeleteRoleAuthorizations(Guid id)
        {
            var entity = _roleAuthorizationService.GetById(id);

            if (entity != null)
            {
                _roleAuthorizationService.Delete(entity);
            }

            return RedirectToAction("RoleAuthorizationsList");
        }
        public IActionResult DeleteUserRole(Guid id)
        {
            var entity = _userRoleService.GetById(id);

            if (entity != null)
            {
                _userRoleService.Delete(entity);
            }

            return RedirectToAction("UserRoleList");
        }
        public IActionResult DeleteRole(Guid id)
        {
            var entity = _roleService.GetById(id);

            if (entity != null)
            {
                _roleService.Delete(entity);
            }

            return RedirectToAction("RoleList");
        }
    }
}
