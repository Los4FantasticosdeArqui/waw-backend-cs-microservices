using waw_auth_service.Domain.Repositories;
using waw_auth_service.Persistence.Repositories;

namespace waw_auth_service.Injection;

public static class AppInjections {
  public static void Register(IServiceCollection services) {
    AuthInjections.Register(services);
     
    services.AddScoped<IUnitOfWork, UnitOfWork>();
  }
}
