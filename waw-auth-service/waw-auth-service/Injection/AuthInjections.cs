using waw_auth_service.Authorization.Handlers.Implementations;
using waw_auth_service.Authorization.Handlers.Interfaces;
using waw_auth_service.Domain.Repositories;
using waw_auth_service.Domain.Services;
using waw_auth_service.Persistence.Repositories;
using waw_auth_service.Services;

namespace waw_auth_service.Injection;

public static class AuthInjections {
  public static void Register(IServiceCollection services) {
    services.AddScoped<IUserRepository, UserRepository>();
    services.AddScoped<IUserService, UserService>();

    services.AddScoped<IUserEducationRepository, UserEducationRepository>();
    services.AddScoped<IUserEducationService, UserEducationService>();

    services.AddScoped<IUserExperienceRepository, UserExperienceRepository>();
    services.AddScoped<IUserExperienceService, UserExperienceService>();

    services.AddScoped<IUserProjectRepository, UserProjectRepository>();
    services.AddScoped<IUserProjectService, UserProjectService>();

    services.AddScoped<IJwtHandler, JwtHandler>();
  }
}
