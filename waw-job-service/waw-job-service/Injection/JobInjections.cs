using waw_job_service.Domain.Repositories;
using waw_job_service.Domain.Services;
using waw_job_service.Persistence.Repositories;
using waw_job_service.Services;

namespace waw_job_service.Injection;

public static class JobInjections {
  public static void Register(IServiceCollection services) {
    services.AddScoped<IOfferRepository, OfferRepository>();
    services.AddScoped<IOfferService, OfferService>();
  }
}
