using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VitbuWebUIKurumsalPanel.Models;

namespace VitbuWebUIKurumsalPanel.Controllers
{
    public class UserController : Controller
    {
        IUserService _userService;
        ICompanyService _companyService;
        public UserController(IUserService userService, ICompanyService companyService)
        {
            _userService = userService;
            _companyService = companyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet, Route("useradd")]
        public IActionResult UserAdd()
        {
            ViewBag.CompanyId = new SelectList(_companyService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "CompanyName");

            return View();
        }
        [HttpPost, Route("useradd")]
        public IActionResult UserAdd(User user)
        {
            ViewBag.CompanyId = new SelectList(_companyService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "CompanyName");

            if (!ModelState.IsValid)
                return View(user);
            else
                _userService.Create(user);

            return View();
        }
        [HttpGet, Route("userlist")]
        public IActionResult UserList()
        {
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Users = _userService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                Companies = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };

            return View(model);
        }
        [HttpPost, Route("useredit")]
        public IActionResult UserRoleEdit(User user)
        {
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _userService.Update(user);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("usermodaladd")]
        public IActionResult UserModalAdd(User user)
        {
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _userService.Create(user);

            return Ok("Başarılı!");
        }
        public IActionResult DeleteUser(Guid id)
        {
            var entity = _userService.GetById(id);

            if (entity != null)
            {
                _userService.Delete(entity);
            }

            return RedirectToAction("UserList");
        }
    }
}

