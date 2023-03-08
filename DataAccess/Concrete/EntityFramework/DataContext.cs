using Entities.Abstract;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@"Server=(localdb)\MSSQLLocalDB;Database=UmmanProductPromotion;integrated security=true;"
            //optionsBuilder.UseSqlServer(@"Data Source=127.0.0.1,1433;Initial Catalog=VitbuDb;User ID=sa;Password=34160*Asus;");
            optionsBuilder.UseSqlServer(@"data source = 89.252.180.91\MSSQLSERVER2016; uid=vitbucom_kurumsalvitbu;pwd=0f4ut1R3@;Database=vitbucom_kurumsalvitbu;Persist Security Info=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleAuthorization> RoleAuthorizations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<WebSettingsParam> WebSettingsParams { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Sehirler> Sehirler { get; set; }
        public DbSet<SemtMah> SemtMah { get; set; }
        public DbSet<Ilceler> Ilceler { get; set; }
        public DbSet<Ulkeler> Ulkeler { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<PriceVehicle> PriceVehicles { get; set; }
        public DbSet<PriceCarrier> PriceCarriers { get; set; }
        public DbSet<Statu> Status { get; set; }
        public DbSet<AdditionalServicesRezervation> AdditionalServicesRezervations { get; set; }

    }
}
