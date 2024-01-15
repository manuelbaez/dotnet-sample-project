using BusinessLogic.Repositories;
using BusinessLogic.Repositories.Abstract;
using DataAccess.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Configuration;

public static class RepositoriesConfiguration
{
    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddTransient<IRepository<Book>, BooksRepository>();
    }

}