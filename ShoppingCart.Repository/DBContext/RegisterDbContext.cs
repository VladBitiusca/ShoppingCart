using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ShoppingCart.Repository.DBContext
{
    public static class RegisterDbContext
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DBConnection")));

            return services;
        }
    }
}
