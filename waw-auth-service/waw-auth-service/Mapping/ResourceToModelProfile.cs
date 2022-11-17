using AutoMapper;

namespace waw_auth_service.Mapping;

public class ResourceToModelProfile : Profile {
  public ResourceToModelProfile() {
    AuthResourceToModelProfile.Register(this);
  
  }
}
