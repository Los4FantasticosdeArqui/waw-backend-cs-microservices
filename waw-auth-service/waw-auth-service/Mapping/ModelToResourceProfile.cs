using AutoMapper;

namespace waw_auth_service.Mapping;

public class ModelToResourceProfile : Profile {
  public ModelToResourceProfile() {
    AuthModelToResourceProfile.Register(this);
 
  }
}
