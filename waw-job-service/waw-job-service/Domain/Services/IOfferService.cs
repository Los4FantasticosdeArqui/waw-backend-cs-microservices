using waw_job_service.Domain.Model;
using waw_job_service.Domain.Services.Communication;

namespace waw_job_service.Domain.Services;

public interface IOfferService {
  Task<IEnumerable<Offer>> ListAll();
  Task<OfferResponse> Create(Offer offer);
  Task<OfferResponse> Update(long id, Offer offer);
  Task<OfferResponse> Delete(long id);
}
