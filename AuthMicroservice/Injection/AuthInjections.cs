using AuthMicroservice.Authorization.Handlers.Implementations;
using AuthMicroservice.Authorization.Handlers.Interfaces;
using AuthMicroservice.Domain.Repositories;
using AuthMicroservice.Domain.Services;
using AuthMicroservice.Persistence.Repositories;
using AuthMicroservice.Services;

namespace AuthMicroservice.Injection;

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
