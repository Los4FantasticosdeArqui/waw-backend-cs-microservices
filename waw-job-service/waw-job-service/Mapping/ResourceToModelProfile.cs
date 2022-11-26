using AutoMapper;

namespace waw_job_service.Mapping;

public class ResourceToModelProfile : Profile {
  public ResourceToModelProfile() {
    JobResourceToModelProfile.Register(this);
  }
}
