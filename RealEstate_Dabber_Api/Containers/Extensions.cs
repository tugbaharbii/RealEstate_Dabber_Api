using RealEstate_Dabber_Api.Models.DapperContex;
using RealEstate_Dabber_Api.Models.Repositoris.CategoryRepositoris;
using RealEstate_Dabber_Api.Models.Repositoris.ProductRepositori;
using RealEstate_Dabber_Api.Models.Repositoris.ProductRepository;
using RealEstate_Dabber_Api.Repositories.AppUserRepositories;
using RealEstate_Dabber_Api.Repositories.BottomGridRepositories;
using RealEstate_Dabber_Api.Repositories.ContactRepositories;
using RealEstate_Dabber_Api.Repositories.EmployeeRepositories;
using RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using RealEstate_Dabber_Api.Repositories.MessageRepositories;
using RealEstate_Dabber_Api.Repositories.PopularLocationRepositories;
using RealEstate_Dabber_Api.Repositories.ProductImageRepositories;
using RealEstate_Dabber_Api.Repositories.PropertyAmenityRepositories;
using RealEstate_Dabber_Api.Repositories.ServiceRepository;
using RealEstate_Dabber_Api.Repositories.StatisticsRepositories;
using RealEstate_Dabber_Api.Repositories.SubFeatureRepositories;
using RealEstate_Dabber_Api.Repositories.TestimonialRepositories;
using RealEstate_Dabber_Api.Repositories.ToDoListRepositories;
using RealEstate_Dabber_Api.Repositories.WhoWeAreRepository;

namespace RealEstate_Dabber_Api.Containers
{
    public  static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services) 
        {
            services.AddTransient<Context>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductsRepository, Last5ProductRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmentiyRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();


        }
    }
}
