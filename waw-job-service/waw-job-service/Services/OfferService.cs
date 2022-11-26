using waw_job_service.Domain.Model;
using waw_job_service.Domain.Repositories;
using waw_job_service.Domain.Services;
using waw_job_service.Domain.Services.Communication;

namespace waw_job_service.Services;

public class OfferService : IOfferService {
  private readonly IOfferRepository repository;
  private readonly IUnitOfWork unitOfWork;

  public OfferService(IOfferRepository repository, IUnitOfWork unitOfWork) {
    this.repository = repository;
    this.unitOfWork = unitOfWork;
  }

  public Task<IEnumerable<Offer>> ListAll() {
    return repository.ListAll();
  }

  public async Task<OfferResponse> Create(Offer offer) {
    try {
      await repository.Add(offer);
      await unitOfWork.Complete();
      return new OfferResponse(offer);
    } catch (Exception e) {
      return new OfferResponse($"An error occurred while saving the offer: {e.Message}");
    }
  }

  public async Task<OfferResponse> Update(long id, Offer offer) {
    var current = await repository.FindById(id);
    if (current == null) return new OfferResponse("Offer not found");

    offer.CopyTo(current);

    try {
      repository.Update(current);
      await unitOfWork.Complete();
      return new OfferResponse(current);
    } catch (Exception e) {
      return new OfferResponse($"An error occurred while updating the offer: {e.Message}");
    }
  }

  public async Task<OfferResponse> Delete(long id) {
    var current = await repository.FindById(id);
    if (current == null) return new OfferResponse("Offer not found");

    try {
      repository.Remove(current);
      await unitOfWork.Complete();
      return new OfferResponse(current);
    } catch (Exception e) {
      return new OfferResponse($"An error occurred while deleting the offer: {e.Message}");
    }
  }
}
