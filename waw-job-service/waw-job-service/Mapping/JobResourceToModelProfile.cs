using AutoMapper;
using waw_job_service.Domain.Model;
using waw_job_service.Resources;

namespace waw_job_service.Mapping;

public static class JobResourceToModelProfile {
  public static void Register(IProfileExpression profile) {
    profile.CreateMap<OfferRequest, Offer>();
  }
}
