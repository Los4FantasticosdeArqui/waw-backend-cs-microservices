using AutoMapper;
using AuthMicroservice.Domain.Models;
using AuthMicroservice.Resources;

namespace AuthMicroservice.Mapping;

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
