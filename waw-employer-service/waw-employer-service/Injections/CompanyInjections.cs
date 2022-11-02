using waw_employer_service.Domain.Repositories;
using waw_employer_service.Domain.Services.Communication;
using waw_employer_service.Persistence.Repositories;

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
