using AutoMapper;

namespace waw_job_service.Mapping;

public class ModelToResourceProfile : Profile {
  public ModelToResourceProfile() {
    JobModelToResourceProfile.Register(this);
  }
}
