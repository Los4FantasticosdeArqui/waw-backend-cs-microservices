using AutoMapper;


namespace AuthMicroservice.Mapping;

public class ModelToResourceProfile : Profile {
  public ModelToResourceProfile() {
    AuthModelToResourceProfile.Register(this);
 
  }
}
