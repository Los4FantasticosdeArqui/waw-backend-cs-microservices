using waw_employer_service.Domain.Repositories;
using waw_employer_service.Persistence.Repositories;

namespace waw_employer_service.Injections
{
    public static class AppInjections
    {
        public static void Register(IServiceCollection services)
        {
            CompanyInjections.Register(services);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}