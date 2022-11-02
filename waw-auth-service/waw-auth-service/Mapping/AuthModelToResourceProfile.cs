using AutoMapper;
using waw_auth_service.Domain.Models;
using waw_auth_service.Resources;

namespace waw_auth_service.Mapping;

public static class AuthModelToResourceProfile {
  public static void Register(IProfileExpression profile) {
    profile.CreateMap<User, UserResource>();
    profile.CreateMap<User, AuthResource>();
    profile.CreateMap<ExternalImage, ExternalImageResource>();
    profile.CreateMap<UserEducation, UserEducationResource>();
    profile.CreateMap<UserExperience, UserExperienceResource>();
    profile.CreateMap<UserProject, UserProjectResource>();
  }
}
