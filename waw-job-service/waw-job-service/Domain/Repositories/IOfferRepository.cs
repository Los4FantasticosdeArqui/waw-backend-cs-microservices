using waw_job_service.Domain.Model;

namespace waw_job_service.Domain.Repositories;

public interface IOfferRepository {
  Task<IEnumerable<Offer>> ListAll();

  Task Add(Offer offer);

  Task<Offer?> FindById(long id);

  void Update(Offer offer);

  void Remove(Offer offer);
}
