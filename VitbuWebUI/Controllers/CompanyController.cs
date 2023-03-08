using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VitbuWebUIPartnerPanel.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VitbuWebUIKurumsalPanel.Controllers
{
    public class CompanyController : Controller
    {
        ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet, Route("company/companyadd")]
        public IActionResult CompanyAdd()
        {
            return View();
        }
        [HttpPost, Route("company/companyadd")]
        public IActionResult CompanyAdd(Company company)
        {
            if (!ModelState.IsValid)
                return View(company);
            else
                _companyService.Create(company);

            return View();
        }
        [HttpGet, Route("company/companylist")]
        public IActionResult CompanyList()
        {
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Companies = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);
        }
        [HttpPost, Route("company/companyedit")]
        public IActionResult UserRoleEdit(Company company)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _companyService.Update(company);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("company/companymodaladd")]
        public IActionResult CompanyModalAdd(Company company)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _companyService.Create(company);

            return Ok("Başarılı!");
        }
        public IActionResult DeleteCompany(Guid id)
        {
            var entity = _companyService.GetById(id);

            if (entity != null)
            {
                _companyService.Delete(entity);
            }

            return RedirectToAction("CompanyList");
        }
    }
}

