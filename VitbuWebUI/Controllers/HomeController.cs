using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using VitbuWebUIPartnerPanel.Models;

namespace VitbuWebUIKurumsalPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IUserService _userService;
        ICompanyService _companyService;
        IMenuService _menuService;
        IRoleService _roleService;
        IUserRoleService _userRoleService;
        IRoleAuthorizationService _roleAuthorizationService;
        IMenuCategoryService _menuCategoriesService;
        public HomeController(ILogger<HomeController> logger, IUserService userService, ICompanyService companyService, IMenuService menuService, IRoleService roleService, IUserRoleService userRoleService, IRoleAuthorizationService roleAuthorizationService, IMenuCategoryService menuCategoriesService)
        {
            _logger = logger;
            _userService = userService;
            _companyService = companyService;
            _menuService = menuService;
            _roleService = roleService;
            _userRoleService = userRoleService;
            _roleAuthorizationService = roleAuthorizationService;
            _menuCategoriesService = menuCategoriesService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet, Route("profile")]
        public IActionResult Profile()
        {
            var user = _userService.GetById(Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value));
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            return View(user);
        }

        [HttpPost, Route("profile")]
        public IActionResult Profile(User user)
        {
            ViewBag.CompanyId = new SelectList(_companyService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "Name");
            if (!ModelState.IsValid)
                return View(user);
            else
            {
                _userService.Update(user);
            }


            return RedirectToAction("profile");
        }
    }
}
