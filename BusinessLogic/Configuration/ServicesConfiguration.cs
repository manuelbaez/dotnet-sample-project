using BusinessLogic.Dtos;
using BusinessLogic.Services.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Configuration;

public static class ServicesConfiguration
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddTransient<IService<BookDto>, BooksService>();
    }

}