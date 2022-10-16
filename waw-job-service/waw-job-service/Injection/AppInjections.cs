using waw_job_service.Domain.Repositories;
using waw_job_service.Persistence.Repositories;

namespace waw_job_service.Injection;

public static class AppInjections
{
    public static void Register(IServiceCollection services) {
        JobInjections.Register(services);
        
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}