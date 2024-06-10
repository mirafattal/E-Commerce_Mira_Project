using E_DAL.Repositories.Categories;
using E_DAL.Repositories.Products;
using E_DAL.Repositories.Suppliers;
using E_DAL.Repositories.UserRoles;
using E_DAL.Repositories.Users;

namespace E_Commerce_Mira.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<ISupplierRepository, SupplierRepository>();
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddScoped<IUserRoleRepository, UserRoleRepository>();
            return service;
        }
    }
}
