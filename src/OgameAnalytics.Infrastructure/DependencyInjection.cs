using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using OgameAnalytics.Infrastructure.Data;


namespace OgameAnalytics.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<OgameDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));



        return services;
    }
}
