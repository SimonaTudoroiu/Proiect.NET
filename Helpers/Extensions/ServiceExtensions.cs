using Project_Tudoroiu_Simona_251.Helpers.JwtToken;
using Project_Tudoroiu_Simona_251.Repositories.AdressRepository;
using Project_Tudoroiu_Simona_251.Repositories.OrderRepository;
using Project_Tudoroiu_Simona_251.Repositories.ProductInOrderRepository;
using Project_Tudoroiu_Simona_251.Repositories.ProductRepository;
using Project_Tudoroiu_Simona_251.Repositories.PromotionRepository;
using Project_Tudoroiu_Simona_251.Repositories.UserRepository;
using Project_Tudoroiu_Simona_251.Services.AddressService;
using Project_Tudoroiu_Simona_251.Services.OrderService;
using Project_Tudoroiu_Simona_251.Services.ProductService;
using Project_Tudoroiu_Simona_251.Services.PromotionService;
using Project_Tudoroiu_Simona_251.Services.UserService;

namespace Project_Tudoroiu_Simona_251.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductInOrderRepository, ProductInOrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IPromotionRepository, PromotionRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IPromotionService, PromotionService>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }

        public static IServiceCollection AddUtils(this IServiceCollection services)
        {
            services.AddScoped<IJwtUtils, JwtUtils.JwtUtils>();

            return services;
        }
    }
}
