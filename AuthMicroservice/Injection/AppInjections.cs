using AuthMicroservice.Domain.Repositories;
using AuthMicroservice.Persistence.Repositories;

namespace AuthMicroservice.Injection;

public static class AppInjections {
  public static void Register(IServiceCollection services) {
    AuthInjections.Register(services);
     
    services.AddScoped<IUnitOfWork, UnitOfWork>();
  }
}
