using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VitbuWebUIKurumsalPanel.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VitbuWebUIKurumsalPanel.Controllers
{
    public class VehicleController : Controller
    {
        IVehicleService _vehicleService;
        IVehicleCategoryService _vehicleCategoryService;
        IVehicleBrandService _vehicleBrandService;
        IVehicleModelService _vehicleModelService;
        ICompanyService _companyService;

        public VehicleController(IVehicleService vehicleService,IVehicleCategoryService vehicleCategoryService,IVehicleBrandService vehicleBrandService,IVehicleModelService vehicleModelService,ICompanyService companyService)
        {
            _vehicleService = vehicleService;
            _vehicleCategoryService = vehicleCategoryService;
            _vehicleBrandService = vehicleBrandService;
            _vehicleModelService = vehicleModelService;
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult VehicleAdd()
        {
            ViewBag.VehicleBrandId = new SelectList(_vehicleBrandService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "BrandName");
            ViewBag.CompanyId = new SelectList(_companyService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "CompanyName");
            ViewBag.VehicleCategoryId = new SelectList(_vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "CategoryName");
            ViewBag.VehicleModelId = new SelectList(_vehicleModelService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "ModelName");
            return View();
        }
        [HttpPost]
        public IActionResult VehicleAdd(Vehicle vehicle)
        {
            
            ViewBag.VehicleBrandId = new SelectList(_vehicleBrandService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "BrandName");
            ViewBag.CompanyId = new SelectList(_companyService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "CompanyName");
            ViewBag.VehicleCategoryId = new SelectList(_vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "CategoryName");
            ViewBag.VehicleModelId = new SelectList(_vehicleModelService.GetAll().Where(x=>x.isDeleted != "false").ToList(), "Id", "ModelName");

            if (!ModelState.IsValid)
                return View(vehicle);
            else
                _vehicleService.Create(vehicle);

            return View("vehiclelist");
        }
        [HttpGet, Route("vehicle/vehiclelist")]
        public IActionResult VehicleList()
        {
            ViewBag.VehicleBrandId = _vehicleBrandService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.VehicleModelId = _vehicleModelService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Vehicles = _vehicleService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                VehicleBrands = _vehicleBrandService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                VehicleModels = _vehicleModelService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                VehicleCategories = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);

        }
        [HttpPost, Route("superadmin/vehicleedit")]
        public IActionResult VehicleEdit(Vehicle vehicle)
        {
            ViewBag.VehicleBrandId = _vehicleBrandService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.VehicleModelId = _vehicleModelService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _vehicleService.Update(vehicle);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("vehicle/vehiclecategorymodaladd")]
        public IActionResult VehicleCategoryModalAdd(VehicleCategory vehicleCategory)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _vehicleCategoryService.Create(vehicleCategory);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("vehicle/vehiclebrandedit")]
        public IActionResult VehicleBrandEdit(VehicleBrand vehicleBrand)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _vehicleBrandService.Update(vehicleBrand);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("vehicle/vehiclebrandmodaladd")]
        public IActionResult VehicleBrandModalAdd(VehicleBrand vehicleBrand)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _vehicleBrandService.Create(vehicleBrand);

            return Ok("Başarılı!");
        }
        [HttpGet, Route("vehicle/vehiclebrandlist")]
        public IActionResult VehicleBrandList()
        {
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                VehicleBrands = _vehicleBrandService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
            };
            return View(model);

        }
        [HttpGet, Route("vehicle/vehiclemodellist")]
        public IActionResult VehicleModelList()
        {
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                VehicleModels = _vehicleModelService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);

        }
        [HttpPost, Route("vehicle/vehiclemodelmodaladd")]
        public IActionResult VehicleModelModalAdd(VehicleModel vehicleModel)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _vehicleModelService.Create(vehicleModel);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("vehicle/vehiclemodeledit")]
        public IActionResult VehicleModelEdit(VehicleModel vehicleModel)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _vehicleModelService.Update(vehicleModel);

            return Ok("Başarılı!");
        }
        [HttpGet]
        public IActionResult VehicleBrandAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VehicleBrandAdd(VehicleBrand vehicleBrand)
        {
            if (!ModelState.IsValid)
                return View(vehicleBrand);
            else
                _vehicleBrandService.Create(vehicleBrand);

            return View();
        }
        [HttpGet]
        public IActionResult VehicleModelAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VehicleModelAdd(VehicleModel vehicleModel)
        {
            if (!ModelState.IsValid)
                return View(vehicleModel);
            else
                _vehicleModelService.Create(vehicleModel);

            return View();
        }
        [HttpGet]
        public IActionResult VehicleCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VehicleCategoryAdd(VehicleCategory vehicleCategory)
        {
            if (!ModelState.IsValid)
                return View(vehicleCategory);
            else
                _vehicleCategoryService.Create(vehicleCategory);

            return View();
        }
        [HttpGet, Route("vehicle/vehiclecategorylist")]
        public IActionResult VehicleCategoryList()
        {
            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                VehicleCategories = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);

        }
        [HttpPost, Route("vehicle/vehiclecategoryedit")]
        public IActionResult VehicleCategoryEdit(VehicleCategory vehicleCategory)
        {
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _vehicleCategoryService.Update(vehicleCategory);

            return Ok("Başarılı!");
        }
        public IActionResult DeleteVehicle(Guid id)
        {
            var entity = _vehicleService.GetById(id);

            if (entity != null)
            {
                _vehicleService.Delete(entity);
            }

            return RedirectToAction("VehicleList");
        }
        public IActionResult DeleteVehicleCategory(Guid id)
        {
            var entity = _vehicleCategoryService.GetById(id);

            if (entity != null)
            {
                _vehicleCategoryService.Delete(entity);
            }

            return RedirectToAction("VehicleCategoryList");
        }
        public IActionResult DeleteVehicleBrand(Guid id)
        {
            var entity = _vehicleBrandService.GetById(id);

            if (entity != null)
            {
                _vehicleBrandService.Delete(entity);
            }

            return RedirectToAction("VehicleBrandList");
        }
        public IActionResult DeleteVehicleModel(Guid id)
        {
            var entity = _vehicleModelService.GetById(id);

            if (entity != null)
            {
                _vehicleModelService.Delete(entity);
            }

            return RedirectToAction("VehicleModelList");
        }
    }
}

