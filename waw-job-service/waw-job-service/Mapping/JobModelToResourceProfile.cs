using AutoMapper;
using waw_job_service.Domain.Model;
using waw_job_service.Resources;

namespace waw_job_service.Mapping;

public static class JobModelToResourceProfile {
  public static void Register(IProfileExpression profile) {
    profile.CreateMap<Offer, OfferResource>();
  }
}
