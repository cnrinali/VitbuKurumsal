using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<MenuCategoryManager>().As<IMenuCategoryService>().SingleInstance();
            builder.RegisterType<EfMenuCategoryDal>().As<IMenuCategoryDal>().SingleInstance();

            builder.RegisterType<MenuManager>().As<IMenuService>().SingleInstance();
            builder.RegisterType<EfMenuDal>().As<IMenuDal>().SingleInstance();

            builder.RegisterType<RoleAuthorizationManager>().As<IRoleAuthorizationService>().SingleInstance();
            builder.RegisterType<EfRoleAuthorizationDal>().As<IRoleAuthorizationDal>().SingleInstance();

            builder.RegisterType<RoleManager>().As<IRoleService>().SingleInstance();
            builder.RegisterType<EfRoleDal>().As<IRoleDal>().SingleInstance();

            builder.RegisterType<UserRoleManager>().As<IUserRoleService>().SingleInstance();
            builder.RegisterType<EfUserRoleDal>().As<IUserRoleDal>().SingleInstance();

            builder.RegisterType<VehicleBrandManager>().As<IVehicleBrandService>().SingleInstance();
            builder.RegisterType<EfVehicleBrandDal>().As<IVehicleBrandDal>().SingleInstance();

            builder.RegisterType<VehicleModelManager>().As<IVehicleModelService>().SingleInstance();
            builder.RegisterType<EfVehicleModelDal>().As<IVehicleModelDal>().SingleInstance();

            builder.RegisterType<VehicleManager>().As<IVehicleService>().SingleInstance();
            builder.RegisterType<EfVehicleDal>().As<IVehicleDal>().SingleInstance();

            builder.RegisterType<WebSettingsParamManager>().As<IWebSettingsParamService>().SingleInstance();
            builder.RegisterType<EfWebSettingsParamDal>().As<IWebSettingsParamDal>().SingleInstance();

            builder.RegisterType<LogManager>().As<ILogService>().SingleInstance();
            builder.RegisterType<EfLogDal>().As<ILogDal>().SingleInstance();

            builder.RegisterType<VehicleCategoryManager>().As<IVehicleCategoryService>().SingleInstance();
            builder.RegisterType<EfVehicleCategoryDal>().As<IVehicleCategoryDal>().SingleInstance();

            builder.RegisterType<RezervationManager>().As<IRezervationService>().SingleInstance();
            builder.RegisterType<EfRezervationDal>().As<IRezervationDal>().SingleInstance();

            builder.RegisterType<PriceManager>().As<IPriceService>().SingleInstance();
            builder.RegisterType<EfPriceDal>().As<IPriceDal>().SingleInstance();

            builder.RegisterType<IlcelerManager>().As<IIlcelerService>().SingleInstance();
            builder.RegisterType<EfIlcelerDal>().As<IIlcelerDal>().SingleInstance();

            builder.RegisterType<SehirlerManager>().As<ISehirlerService>().SingleInstance();
            builder.RegisterType<EfSehirlerDal>().As<ISehirlerDal>().SingleInstance();

            builder.RegisterType<SemtMahManager>().As<ISemtMahService>().SingleInstance();
            builder.RegisterType<EfSemtMahDal>().As<ISemtMahDal>().SingleInstance();

            builder.RegisterType<AdditionalServicesManager>().As<IAdditionalServicesService>().SingleInstance();
            builder.RegisterType<EfAdditionalServicesDal>().As<IAdditionalServicesDal>().SingleInstance();

            builder.RegisterType<ServiceTypeManager>().As<IServiceTypeService>().SingleInstance();
            builder.RegisterType<EfServiceTypeDal>().As<IServiceTypeDal>().SingleInstance();

            builder.RegisterType<ReferenceManager>().As<IReferenceService>().SingleInstance();
            builder.RegisterType<EfReferenceDal>().As<IReferenceDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<AdditionalServicesRezervationManager>().As<IAdditionalServicesRezervationService>().SingleInstance();
            builder.RegisterType<EfAdditionalServicesRezervationDal>().As<IAdditionalServicesRezervationDal>().SingleInstance();

            builder.RegisterType<StatuManager>().As<IStatuService>().SingleInstance();
            builder.RegisterType<EfStatuDal>().As<IStatuDal>().SingleInstance();
        }
    }
}