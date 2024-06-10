using E_BLL._GenericService;
using E_BLL.Services.Auth;
using E_BLL.Services.Categories;
using E_BLL.Services.Products;
using E_BLL.Services.Suppliers;
using E_BLL.Services.UserRoles;
using E_BLL.Services.Users;


namespace E_Commerce_Mira.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<ISupplierService, SupplierService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IAuthService, AuthService>();
            service.AddScoped<IUserRoleService, UserRoleService>();
            service.AddScoped<ICategoryService, CategoryService>();
            return service;
        }
    }
}
