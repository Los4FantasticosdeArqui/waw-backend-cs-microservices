using waw_employer_service.Domain.Repositories;
using waw_employer_service.Domain.Services;
using waw_employer_service.Persistence.Repositories;
using waw_employer_service.Services;

namespace waw_employer_service.Injections
{
    public static class CompanyInjections
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();
        }
    }
}
