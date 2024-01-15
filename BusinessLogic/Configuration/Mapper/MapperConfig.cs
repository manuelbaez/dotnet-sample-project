using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Configuration.Mapper;
public static class MapperConfig
{
    public static void ConfigureMappings(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(BooksMappingProfile));
    }
}