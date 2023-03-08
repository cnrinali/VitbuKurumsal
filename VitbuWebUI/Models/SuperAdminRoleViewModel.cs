using Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace VitbuWebUIPartnerPanel.Models
{
    public class SuperAdminRoleViewModel
    {
        [BindProperty]
        public List<Menu> Menus { get; set; }
        [BindProperty]
        public List<MenuCategory> MenuCategories { get; set; }
        [BindProperty]
        public List<UserRole> UserRoles { get; set; }
        [BindProperty]
        public List<Role> Roles { get; set; }
        [BindProperty]
        public List<RoleAuthorization> RoleAuthorizations { get; set; }
        [BindProperty]
        public List<User> Users { get; set; }
        [BindProperty]
        public List<Vehicle> Vehicles { get; set; }
        [BindProperty]
        public List<VehicleBrand> VehicleBrands { get; set; }
        [BindProperty]
        public List<VehicleModel> VehicleModels { get; set; }
        [BindProperty]
        public List<VehicleCategory> VehicleCategories { get; set; }
        [BindProperty]
        public List<Company> Companies { get; set; }
        [BindProperty]
        public List<Rezervation> Rezervations { get; set; }
        [BindProperty]
        public List<Price> Prices { get; set; }
        [BindProperty]
        public List<PriceCarrier> PriceCarriers { get; set; }
        [BindProperty]
        public List<PriceVehicle> PriceVehicles { get; set; }
        [BindProperty]
        public List<Sehirler> Sehirlers { get; set; }
        [BindProperty]
        public List<Ilceler> Ilcelers { get; set; }
        [BindProperty]
        public List<SemtMah> SemtMahs { get; set; }
        [BindProperty]
        public List<Customer> Customers { get; set; }
        [BindProperty]
        public List<Reference> References { get; set; }
        [BindProperty]
        public List<AdditionalServices> AdditionalServices { get; set; }
        [BindProperty]
        public List<ServiceType> ServiceTypes { get; set; }
    }
}