using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VitbuWebUIPartnerPanel.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VitbuWebUIKurumsalPanel.Controllers
{
    public class RezervationController : Controller
    {
        IRezervationService _rezervationService;
        IPriceService _priceService;
        ISehirlerService _sehirlerService;
        IIlcelerService _ilcelerService;
        ISemtMahService _semtMahService;
        ICompanyService _companyService;
        IVehicleCategoryService _vehicleCategoryService;
        IUserService _userService;
        IReferenceService _referenceServis;
        IAdditionalServicesService _additionalServicesService;
        IServiceTypeService _serviceTypeService;
        ICustomerService _customerService;
        IVehicleService _vehicleService;
        IAdditionalServicesRezervationService _additionalServicesRezervationService;

        public RezervationController(IRezervationService rezervationService, IPriceService priceService, ISehirlerService sehirlerService, IIlcelerService ilcelerService, ISemtMahService semtMahService, ICompanyService companyService, IVehicleCategoryService vehicleCategoryService, IUserService userService, IReferenceService referenceServis, IAdditionalServicesService additionalServicesService, IServiceTypeService serviceTypeService, ICustomerService customerService, IVehicleService vehicleService, IAdditionalServicesRezervationService additionalServicesRezervationService)
        {
            _rezervationService = rezervationService;
            _priceService = priceService;
            _sehirlerService = sehirlerService;
            _ilcelerService = ilcelerService;
            _semtMahService = semtMahService;
            _companyService = companyService;
            _vehicleCategoryService = vehicleCategoryService;
            _userService = userService;
            _referenceServis = referenceServis;
            _additionalServicesService = additionalServicesService;
            _serviceTypeService = serviceTypeService;
            _customerService = customerService;
            _vehicleService = vehicleService;
            _additionalServicesRezervationService = additionalServicesRezervationService;
        }
        public IActionResult Rezervation()
        {
            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            var userid = identity.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(c => c.Value).SingleOrDefault();
            var compUser = _userService.GetById(Guid.Parse(userid)).CompanyId;
            var typeComp = _companyService.GetById(compUser).CompanyType;
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetList(x => x.CompanyType == "Bussines");
            ViewBag.CarrierId = _companyService.GetList(x => x.CompanyType == "Partner");
            ViewBag.PriceId = _priceService.GetAll();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.CustomerId = _customerService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.ReferenceId = _referenceServis.GetAll();
            ViewBag.VehicleId = _vehicleService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.UserId = _userService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.ServiceTypeId = _serviceTypeService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.AdditionalServicesId = _additionalServicesService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = typeComp == "Admin" ? _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList() : _rezervationService.GetList(x => x.CompanyId == compUser),
                Prices = _priceService.GetList(x => x.CompanyId == compUser) == null ? _priceService.GetAll() : _priceService.GetList(x => x.CompanyId == compUser),
                Sehirlers = _sehirlerService.GetAll().ToList(),
                Companies = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                Ilcelers = _ilcelerService.GetAll().ToList(),
                VehicleCategories = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                SemtMahs = _semtMahService.GetAll().ToList(),
                Users = _userService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                References = _referenceServis.GetAll(),
                AdditionalServices = _additionalServicesService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                ServiceTypes = _serviceTypeService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult RezervationAdd(Rezervation rezervation)
        {
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.PriceId = _priceService.GetAll();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.CustomerId = _customerService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.ReferenceId = _referenceServis.GetAll();
            ViewBag.VehicleId = _vehicleService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.UserId = _userService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.ServiceTypeId = _serviceTypeService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.AdditionalServicesId = _additionalServicesService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _rezervationService.Create(rezervation);

            return View(rezervation);
        }
        public IActionResult Price()
        {
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Prices = _priceService.GetAll(),
                Ilcelers = _ilcelerService.GetAll().ToList(),
                Sehirlers = _sehirlerService.GetAll().ToList(),
                SemtMahs = _semtMahService.GetAll().ToList(),
                VehicleCategories = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                Companies = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);
        }
        [HttpPost, Route("Rezervation/Priceadd")]
        public IActionResult PriceAdd(Price price)
        {
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _priceService.Create(price);

            return Ok("Başarılı!");
        }
        [HttpPost, Route("rezervation/priceedit")]
        public IActionResult PriceEdit(Price price)
        {
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _priceService.Update(price);

            return Ok("Başarılı!");
        }
        public IActionResult DeletePrice(Guid id)
        {
            var entity = _priceService.GetById(id);

            if (entity != null)
            {
                _priceService.Delete(entity);
            }

            return RedirectToAction("Price");
        }

        public IActionResult Reference()
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList(),
                References = _referenceServis.GetAll()
            };
            return View(model);
        }
        [HttpPost, Route("Rezervation/ReferenceAdd")]
        public IActionResult ReferenceAdd(Reference reference)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _referenceServis.Create(reference);

            return Ok(reference);
        }
        [HttpPost, Route("rezervation/referenceedit")]
        public IActionResult ReferenceEdit(Reference reference)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _referenceServis.Update(reference);

            return Ok("Başarılı!");
        }
        public IActionResult DeleteReference(Guid id)
        {
            var entity = _referenceServis.GetById(id);

            if (entity != null)
            {
                _referenceServis.Delete(entity);
            }

            return RedirectToAction("Price");
        }

        public IActionResult AdditionalServices()
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);
        }

        [HttpPost, Route("Rezervation/AdditionalServicesAdd")]
        public IActionResult AdditionalServicesAdd(AdditionalServices additionalServices)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _additionalServicesService.Create(additionalServices);

            return Ok("Başarılı!");
        }

        [HttpPost, Route("Rezervation/AdditionalServicesRezervationAdd")]
        public IActionResult AdditionalServicesRezervationAdd(Guid additionalServicesId, Guid rezervationId, string price)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();
            AdditionalServicesRezervation model = new AdditionalServicesRezervation()
            {
                AdditionalServicesId = additionalServicesId,
                RezervationId = rezervationId,
                ServicePrice = price
            };
            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _additionalServicesRezervationService.Create(model);

            return Ok("Başarılı!");
        }

        [HttpPost, Route("rezervation/AdditionalServicesedit")]
        public IActionResult AdditionalServicesEdit(AdditionalServices additionalServices)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _additionalServicesService.Update(additionalServices);

            return Ok("Başarılı!");
        }

        public IActionResult DeleteAdditionalServices(Guid id)
        {
            var entity = _additionalServicesService.GetById(id);

            if (entity != null)
            {
                _additionalServicesService.Delete(entity);
            }

            return RedirectToAction("Price");
        }

        public IActionResult ServiceType()
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList()
            };
            return View(model);
        }

        [HttpPost, Route("Rezervation/ServiceTypeAdd")]
        public IActionResult ServiceTypeAdd(ServiceType serviceType)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _serviceTypeService.Create(serviceType);

            return Ok("Başarılı!");
        }

        [HttpPost, Route("rezervation/ServiceTypeedit")]
        public IActionResult ServiceTypeEdit(ServiceType serviceType)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _serviceTypeService.Update(serviceType);

            return Ok("Başarılı!");
        }

        public IActionResult DeleteServiceType(Guid id)
        {
            var entity = _serviceTypeService.GetById(id);

            if (entity != null)
            {
                _serviceTypeService.Delete(entity);
            }

            return RedirectToAction("Price");
        }
        [HttpGet]
        public IActionResult GetLocationPrice(string valueStart, string valueEnd)
        {
            var model = _priceService.GetList(x => x.StartSemtMahId == valueStart);
            var price = new List<Price>();
            foreach (var item in model)
            {
                var data = _priceService.GetList(x => x.EndtSemtMahId == valueEnd);
                price.AddRange(data);
            }
            return Json(price);
        }
        [HttpGet]
        public IActionResult GetVehiclePrices(string value)
        {
            var model = _vehicleService.GetList(x => x.VehiclePlate == value);
            return Json(model);
        }

        [HttpGet]
        public IActionResult GetCompanyUser(Guid value)
        {
            var model = _userService.GetList(x => x.CompanyId == value);
            return Json(model);
        }
        [HttpGet]
        public IActionResult GetCompanyPlate(Guid value)
        {
            var model = _vehicleService.GetList(x => x.CompanyId == value);
            return Json(model);
        }

        #region Location Transactions
        [HttpGet]
        public IActionResult GetLocationCity(int value)
        {
            var model = _ilcelerService.GetList(x => x.SehirId == value);
            return Json(model);
        }
        [HttpGet]
        public IActionResult GetLocationRoute(int value)
        {
            var model = _semtMahService.GetList(x => x.ilceId == value);
            return Json(model);
        }
        #endregion 
    }
}

