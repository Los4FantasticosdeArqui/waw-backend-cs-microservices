using AutoMapper;
namespace AuthMicroservice.Mapping;

public class ResourceToModelProfile : Profile {
  public ResourceToModelProfile() {
    AuthResourceToModelProfile.Register(this);
  
  }
}
