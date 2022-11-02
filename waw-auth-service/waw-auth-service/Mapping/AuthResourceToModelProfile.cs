using AutoMapper;
using waw_auth_service.Domain.Models;
using waw_auth_service.Resources;

namespace waw_auth_service.Mapping;

public static class AuthResourceToModelProfile {
  public static void Register(IProfileExpression profile) {
    profile.CreateMap<UserCreateRequest, User>();
    profile.CreateMap<UserUpdateRequest, User>();
    profile.CreateMap<ExternalImageRequest, ExternalImage>();
    profile.CreateMap<UserEducationRequest, UserEducation>();
    profile.CreateMap<UserExperienceRequest, UserExperience>();
    profile.CreateMap<UserProjectRequest, UserProject>();
  }
}
