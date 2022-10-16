using waw_job_service.Domain.Model;

namespace waw_job_service.Domain.Services.Communication;

public class OfferResponse : BaseResponse<Offer> {
  public OfferResponse(string message) : base(message) {}
  public OfferResponse(Offer resource) : base(resource) {}
}
