using AutoMapper;
using AuthMicroservice.Domain.Models;
using AuthMicroservice.Resources;

namespace AuthMicroservice.Mapping;

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
