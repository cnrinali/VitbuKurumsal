using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VitbuWebUIKurumsalPanel.Models;

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
        IStatuService _statuService;

        public RezervationController(IRezervationService rezervationService, IPriceService priceService, ISehirlerService sehirlerService, IIlcelerService ilcelerService, ISemtMahService semtMahService, ICompanyService companyService, IVehicleCategoryService vehicleCategoryService, IUserService userService, IReferenceService referenceServis, IAdditionalServicesService additionalServicesService, IServiceTypeService serviceTypeService, ICustomerService customerService, IVehicleService vehicleService, IAdditionalServicesRezervationService additionalServicesRezervationService, IStatuService statuService)
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
            _statuService = statuService;
        }
        public IActionResult RezervationAtama()
        {
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetList(x => x.CompanyType == "Bussines" && x.isDeleted != "false");
            ViewBag.CarrierId = _companyService.GetList(x => x.CompanyType == "Partner" && x.isDeleted != "false");
            ViewBag.PriceId = _priceService.GetAll();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.CustomerId = _customerService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.ReferenceId = _referenceServis.GetAll();
            ViewBag.VehicleId = _vehicleService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.UserId = _userService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.ServiceTypeId = _serviceTypeService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.AdditionalServicesId = _additionalServicesService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.StatusId = _statuService.GetAll();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                Prices = _priceService.GetAll(),
                Sehirlers = _sehirlerService.GetAll().ToList(),
                Companies = _companyService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                Ilcelers = _ilcelerService.GetAll().ToList(),
                VehicleCategories = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                SemtMahs = _semtMahService.GetAll().ToList(),
                Users = _userService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                References = _referenceServis.GetAll(),
                AdditionalServices = _additionalServicesService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                ServiceTypes = _serviceTypeService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                Status = _statuService.GetAll()
            };
            return View(model);
        }
        public IActionResult Rezervation()
        {
            var listee = new List<AdditionalServicesRezervation>();
            var userid = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var compUser = _userService.GetById(Guid.Parse(userid)).CompanyId;
            var typeComp = _companyService.GetById(compUser).CompanyType;
            var isAdmin = _companyService.GetList(x => x.CompanyType == "Admin").First().Id;
            foreach (var adsr in _additionalServicesRezervationService.GetList(x => x.isDeleted != "false"))
            {
                var dattta = _additionalServicesService.GetList(x => x.Id == adsr.AdditionalServicesId).Where(x => x.isDeleted != "false").FirstOrDefault();
                if (dattta != null)
                {
                    listee.Add(adsr);
                }
            }
            ViewBag.AdditionalServicesRezervationId = listee;
            ViewBag.AdditionalServicesId = _additionalServicesService.GetList(x => x.isDeleted != "false").ToList();
            ViewBag.isAdmin = typeComp;
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetList(x => x.CompanyType == "Bussines" && x.isDeleted != "false").Where(x => x.isDeleted != "false").ToList();
            ViewBag.CarrierId = _companyService.GetList(x => x.CompanyType == "Partner" && x.isDeleted != "false");
            ViewBag.PriceId = _priceService.GetList(x => x.CompanyId == compUser) == null ? _priceService.GetList(x => x.CompanyId == isAdmin) : _priceService.GetList(x => x.CompanyId == compUser);
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.CustomerId = _customerService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.ReferenceId = _referenceServis.GetAll();
            ViewBag.VehicleId = _vehicleService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.UserId = _userService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.ServiceTypeId = _serviceTypeService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.AdditionalServicesId = _additionalServicesService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.StatusId = _statuService.GetAll();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = typeComp == "Admin" ? _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList() : _rezervationService.GetList(x => x.CompanyId == compUser),
                Prices = _priceService.GetList(x => x.CompanyId == compUser) == null ? _priceService.GetList(x => x.CompanyId == isAdmin) : _priceService.GetList(x => x.CompanyId == compUser),
                Sehirlers = _sehirlerService.GetAll(),
                Companies = _companyService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                Ilcelers = _ilcelerService.GetAll(),
                VehicleCategories = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                SemtMahs = _semtMahService.GetAll(),
                Users = _userService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                References = _referenceServis.GetAll(),
                AdditionalServices = _additionalServicesService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                ServiceTypes = _serviceTypeService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                Status = _statuService.GetAll()
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult RezervationAdd(Rezervation rezervation)
        {
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.PriceId = _priceService.GetAll();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.CustomerId = _customerService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.ReferenceId = _referenceServis.GetAll();
            ViewBag.VehicleId = _vehicleService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.UserId = _userService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.ServiceTypeId = _serviceTypeService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.AdditionalServicesId = _additionalServicesService.GetAll().Where(x => x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _rezervationService.Create(rezervation);

            return Ok(rezervation);
        }
        [HttpPost, Route("rezervation/rezervationedit")]
        public IActionResult RezervationEdit(Rezervation rezervation)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _rezervationService.Update(rezervation);

            return Ok("Başarılı!");
        }
        public IActionResult Price()
        {
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Prices = _priceService.GetAll(),
                Ilcelers = _ilcelerService.GetAll().ToList(),
                Sehirlers = _sehirlerService.GetAll().ToList(),
                SemtMahs = _semtMahService.GetAll().ToList(),
                VehicleCategories = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                Companies = _companyService.GetAll().Where(x => x.isDeleted != "false").ToList()
            };
            return View(model);
        }
        [HttpPost, Route("Rezervation/Priceadd")]
        public IActionResult PriceAdd(Price price)
        {
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList();

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
            ViewBag.CompanyId = _companyService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList();

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
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                References = _referenceServis.GetAll()
            };
            return View(model);
        }
        [HttpPost, Route("Rezervation/ReferenceAdd")]
        public IActionResult ReferenceAdd(Reference reference)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _referenceServis.Create(reference);

            return Ok(reference);
        }
        [HttpPost, Route("rezervation/referenceedit")]
        public IActionResult ReferenceEdit(Reference reference)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

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

        public IActionResult DeleteRezervation(Guid id)
        {
            var entity = _rezervationService.GetById(id);
            var data = _customerService.GetList(x => x.RezervationId == id).Where(x => x.isDeleted != "false");
            if (data != null)
            {
                foreach (var item in data)
                {
                    _customerService.Delete(item);
                }
            }

            if (entity != null)
                _rezervationService.Delete(entity);

            return RedirectToAction("Rezervation");
        }

        public IActionResult AdditionalServices()
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList()
            };
            return View(model);
        }

        [HttpPost, Route("Rezervation/AdditionalServicesAdd")]
        public IActionResult AdditionalServicesAdd(AdditionalServices additionalServices)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _additionalServicesService.Create(additionalServices);

            return Ok("Başarılı!");
        }

        [HttpPost, Route("Rezervation/AdditionalServicesRezervationAdd")]
        public IActionResult AdditionalServicesRezervationAdd(Guid additionalServicesId, Guid rezervationId, string price)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();
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
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

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
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList()
            };
            return View(model);
        }
        public IActionResult Cari()
        {
            var userid = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var compUser = _userService.GetById(Guid.Parse(userid)).CompanyId;
            var typeComp = _companyService.GetById(compUser).CompanyType;
            var isAdmin = _companyService.GetList(x => x.CompanyType == "Admin")?.First().Id;
            ViewBag.isAdmin = typeComp;
            ViewBag.SehirId = _sehirlerService.GetAll();
            ViewBag.IlceId = _ilcelerService.GetAll();
            ViewBag.SemtMahId = _semtMahService.GetAll();
            ViewBag.CompanyId = _companyService.GetList(x => x.CompanyType == "Bussines" && x.isDeleted != "false");
            ViewBag.CarrierId = _companyService.GetList(x => x.CompanyType == "Partner" && x.isDeleted != "false");
            ViewBag.PriceId = _priceService.GetList(x => x.CompanyId == compUser) == null ? _priceService.GetList(x => x.CompanyId == isAdmin) : _priceService.GetList(x => x.CompanyId == compUser);
            ViewBag.VehicleCategoryId = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.CustomerId = _customerService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.ReferenceId = _referenceServis.GetAll();
            ViewBag.VehicleId = _vehicleService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.UserId = _userService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.ServiceTypeId = _serviceTypeService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.AdditionalServicesId = _additionalServicesService.GetAll().Where(x => x.isDeleted != "false").ToList();
            ViewBag.StatusId = _statuService.GetAll();
            ViewBag.Rezervation = compUser == isAdmin ? _rezervationService.GetAll().Where(x => x.isDeleted != "false" && x.TotalPrice != null && x.VehiclePrice != null).ToList() : _rezervationService.GetList(x => x.CompanyId == compUser).Where(x => x.isDeleted != "false" && x.TotalPrice != null && x.VehiclePrice != null).ToList();
            ViewBag.RezervationYear = compUser == isAdmin ? _rezervationService.GetAll().Where(x => x.isDeleted != "false" && x.TotalPrice != null && x.VehiclePrice != null).ToList() : _rezervationService.GetList(x => x.CompanyId == compUser).Where(x => x.isDeleted != "false" && x.TotalPrice != null && x.VehiclePrice != null).ToList();

            var rezervations = compUser == isAdmin ? _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList() : _rezervationService.GetList(x => x.CompanyId == compUser).Where(x => x.isDeleted != "false").ToList();

            SuperAdminRoleViewModel model = new SuperAdminRoleViewModel()
            {
                Rezervations = typeComp == "Admin" ? _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList() : _rezervationService.GetList(x => x.CompanyId == compUser),
                Prices = _priceService.GetList(x => x.CompanyId == compUser) == null ? _priceService.GetList(x => x.CompanyId == isAdmin) : _priceService.GetList(x => x.CompanyId == compUser),
                Sehirlers = _sehirlerService.GetAll().ToList(),
                Companies = _companyService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                Ilcelers = _ilcelerService.GetAll().ToList(),
                VehicleCategories = _vehicleCategoryService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                SemtMahs = _semtMahService.GetAll().ToList(),
                Users = _userService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                References = _referenceServis.GetAll(),
                AdditionalServices = _additionalServicesService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                ServiceTypes = _serviceTypeService.GetAll().Where(x => x.isDeleted != "false").ToList(),
                Status = _statuService.GetAll()
            };

            return View(model);
        }
        [HttpPost, Route("Rezervation/ServiceTypeAdd")]
        public IActionResult ServiceTypeAdd(ServiceType serviceType)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

            if (!ModelState.IsValid)
                return Ok("Başarısız!");
            else
                _serviceTypeService.Create(serviceType);

            return Ok("Başarılı!");
        }

        [HttpPost, Route("rezervation/ServiceTypeedit")]
        public IActionResult ServiceTypeEdit(ServiceType serviceType)
        {
            ViewBag.Rezervation = _rezervationService.GetAll().Where(x => x.isDeleted != "false").ToList();

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
        public IActionResult GetLocationCityPrice(string valueStart, string valueEnd)
        {
            var model = _priceService.GetList(x => x.StartIlceId == valueStart);
            var price = new List<Price>();
            foreach (var item in model)
            {
                var data = _priceService.GetList(x => x.EndIlceId == valueEnd);
                price.AddRange(data);
            }
            return Json(price);
        }

        //[HttpPost]
        //public IActionResult Cari(int? valueStart, int? valueStartYear)
        //{
        //    var liste = new List<Rezervation>();
        //    var listeYear = new List<Rezervation>();
        //    var userid = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
        //    var compUser = _userService.GetById(Guid.Parse(userid)).CompanyId;
        //    var typeComp = _companyService.GetById(compUser).CompanyType;
        //    var isAdmin = _companyService.GetList(x => x.CompanyType == "Admin").SingleOrDefault().Id;
        //    var rezervations = compUser == isAdmin ? _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList() : _rezervationService.GetList(x => x.CompanyId == compUser);
        //    foreach (var item in rezervations)
        //    {
        //        var filter = DateTime.Parse(item.StartDate).Month;
        //        var filterbuay = DateTime.Now.Month;
        //        var filterYear = DateTime.Parse(item.StartDate).Year;
        //        var filterbuYear = DateTime.Now.Year;
        //        if (filter == valueStart)
        //        {
        //            Rezervation rezervation = new Rezervation()
        //            {
        //                Id = item.Id,
        //                AdditionalServices = item.AdditionalServices,
        //                AirplaneTime = item.AirplaneTime,
        //                CarrierId = item.CarrierId,
        //                CompanyId = item.CompanyId,
        //                CreateDate = item.CreateDate,
        //                Customers = item.Customers,
        //                DeparturePoint = item.DeparturePoint,
        //                Destination = item.Destination,
        //                EndDate = item.EndDate,
        //                EndIlce = item.EndIlce,
        //                EndSehir = item.EndSehir,
        //                EndSemtMah = item.EndSemtMah,
        //                FlightCode = item.FlightCode,
        //                IntermediateStop = item.IntermediateStop,
        //                ModifiedName = item.ModifiedName,
        //                Personal = item.Personal,
        //                Company = item.Company,
        //                PersonalGsm = item.PersonalGsm,
        //                PersonalTC = item.PersonalTC,
        //                PersonCount = item.PersonCount,
        //                Plate = item.Plate,
        //                PriceId = item.PriceId,
        //                Prices = item.Prices,
        //                RefCode = item.RefCode,
        //                Reference = item.Reference,
        //                ReferenceId = item.ReferenceId,
        //                ServiceType = item.ServiceType,
        //                StartDate = item.StartDate,
        //                StartIlce = item.StartIlce,
        //                StartSehir = item.StartSehir,
        //                StartSemtMah = item.StartSemtMah,
        //                StatuId = item.StatuId,
        //                Status = item.Status,
        //                TotalPrice = item.TotalPrice,
        //                User = item.User,
        //                UserId = item.UserId,
        //                Vehicle = item.Vehicle,
        //                VehicleCategory = item.VehicleCategory,
        //                VehicleCategoryId = item.VehicleCategoryId,
        //                VehicleId = item.VehicleId,
        //                VehiclePrice = item.VehiclePrice,
        //            };
        //            liste.Add(rezervation);
        //        }
        //        if (filterYear == valueStartYear)
        //        {
        //            Rezervation rezervation = new Rezervation()
        //            {
        //                Id = item.Id,
        //                AdditionalServices = item.AdditionalServices,
        //                AirplaneTime = item.AirplaneTime,
        //                CarrierId = item.CarrierId,
        //                CompanyId = item.CompanyId,
        //                CreateDate = item.CreateDate,
        //                Customers = item.Customers,
        //                DeparturePoint = item.DeparturePoint,
        //                Destination = item.Destination,
        //                EndDate = item.EndDate,
        //                EndIlce = item.EndIlce,
        //                EndSehir = item.EndSehir,
        //                EndSemtMah = item.EndSemtMah,
        //                FlightCode = item.FlightCode,
        //                IntermediateStop = item.IntermediateStop,
        //                ModifiedName = item.ModifiedName,
        //                Personal = item.Personal,
        //                Company = item.Company,
        //                PersonalGsm = item.PersonalGsm,
        //                PersonalTC = item.PersonalTC,
        //                PersonCount = item.PersonCount,
        //                Plate = item.Plate,
        //                PriceId = item.PriceId,
        //                Prices = item.Prices,
        //                RefCode = item.RefCode,
        //                Reference = item.Reference,
        //                ReferenceId = item.ReferenceId,
        //                ServiceType = item.ServiceType,
        //                StartDate = item.StartDate,
        //                StartIlce = item.StartIlce,
        //                StartSehir = item.StartSehir,
        //                StartSemtMah = item.StartSemtMah,
        //                StatuId = item.StatuId,
        //                Status = item.Status,
        //                TotalPrice = item.TotalPrice,
        //                User = item.User,
        //                UserId = item.UserId,
        //                Vehicle = item.Vehicle,
        //                VehicleCategory = item.VehicleCategory,
        //                VehicleCategoryId = item.VehicleCategoryId,
        //                VehicleId = item.VehicleId,
        //                VehiclePrice = item.VehiclePrice,
        //            };
        //            listeYear.Add(rezervation);
        //        }
        //    }
        //    if (liste.Count == 0)
        //        ViewBag.Rezervation = compUser == isAdmin ? _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList() : _rezervationService.GetList(x => x.CompanyId == compUser);
        //    else
        //        ViewBag.Rezervation = liste;

        //    if (listeYear.Count == 0)
        //        ViewBag.RezervationYear = compUser == isAdmin ? _rezervationService.GetAll().Where(x=>x.isDeleted != "false").ToList() : _rezervationService.GetList(x => x.CompanyId == compUser);
        //    else
        //        ViewBag.RezervationYear = listeYear;

        //    return View();
        //}

        [HttpPost]
        public IActionResult Cari(int? valueStart, int? valueStartYear, Guid CompanyId)
        {
            ViewBag.CompanyId = _companyService.GetList(x => x.CompanyType == "Bussines" && x.isDeleted != "false");
            var liste = new List<Rezervation>();
            var listeYear = new List<Rezervation>();
            var userid = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            var compUser = _userService.GetById(Guid.Parse(userid)).CompanyId;
            var typeComp = _companyService.GetById(compUser).CompanyType;
            var isAdmin = _companyService.GetList(x => x.CompanyType == "Admin" && x.isDeleted != "false").SingleOrDefault().Id;
            var rezervations = compUser == isAdmin ? _rezervationService.GetAll().Where(x => x.isDeleted != "false" && x.TotalPrice != null && x.VehiclePrice != null).ToList() : _rezervationService.GetList(x => x.CompanyId == compUser && x.TotalPrice != null && x.VehiclePrice != null);
            var filterComp = _companyService.GetById(CompanyId);
            if (filterComp != null)
                rezervations = compUser == isAdmin ? _rezervationService.GetList(x => x.CompanyId == CompanyId && x.isDeleted != "false" && x.TotalPrice != null && x.VehiclePrice != null) : _rezervationService.GetList(x => x.CompanyId == compUser && x.isDeleted != "false" && x.TotalPrice != null && x.VehiclePrice != null);

            foreach (var item in rezervations)
            {
                var filter = DateTime.Parse(item.StartDate).Month;
                var filterbuay = DateTime.Now.Month;
                var filterYear = DateTime.Parse(item.StartDate).Year;
                var filterbuYear = DateTime.Now.Year;
                if (filter == valueStart)
                {
                    liste.Add(item);
                }
                if (filterYear == valueStartYear)
                {
                    listeYear.Add(item);
                }
            }

            if (liste.Count == 0)
                ViewBag.Rezervation = compUser == isAdmin ? rezervations : rezervations.Where(x => x.CompanyId == compUser && x.TotalPrice != null && x.VehiclePrice != null).ToList();
            else
                ViewBag.Rezervation = liste;

            if (listeYear.Count == 0)
                ViewBag.RezervationYear = compUser == isAdmin ? rezervations : rezervations.Where(x => x.CompanyId == compUser && x.TotalPrice != null && x.VehiclePrice != null).ToList();
            else
                ViewBag.RezervationYear = listeYear;

            return View();
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
            var model = _userService.GetList(x => x.CompanyId == value && x.isDeleted != "false");
            return Json(model);
        }
        [HttpGet]
        public IActionResult GetCompanyPlate(Guid value)
        {
            var model = _vehicleService.GetList(x => x.CompanyId == value && x.isDeleted != "false");
            return Json(model);
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
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

