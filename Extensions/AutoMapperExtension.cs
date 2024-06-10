using E_BLL.Mapping;

namespace E_Commerce_Mira.Extensions
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));
            return service;
        }
    }
}
