using E_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Mira.Extensions
{
    public static class DbExtensions
    {
        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<ECommerceContext>(options =>
                                 options.UseSqlServer(ConnectionString));
            return service;
        }
    }
}
