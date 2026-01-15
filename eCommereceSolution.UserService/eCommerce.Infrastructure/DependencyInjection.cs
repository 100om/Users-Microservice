using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure; // file Scoped Name Space

public static class DependencyInjection
{
    /// <summary>
 /// Extension method to add Core services to the dependency injection container
 /// </summary>
 /// <param name="services"></param>
 /// <returns></returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services) // builder.Services is an IServiceCollection.
    {
        //TO DO: Add services to the IoC container
        //Core services often include data access, caching and other low-level components.
        services.AddTransient<IUsersRepository, UsersRepository>();
        services.AddTransient<DapperDbContext>();
        return services;

    }

}
