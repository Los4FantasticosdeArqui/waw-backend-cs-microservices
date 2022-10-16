using Microsoft.EntityFrameworkCore;
using waw_job_service.Domain.Model;
using waw_job_service.Domain.Repositories;
using waw_job_service.Persistence.Contexts;

namespace waw_job_service.Persistence.Repositories;

public class OfferRepository : BaseRepository, IOfferRepository {
  public OfferRepository(AppDbContext context) : base(context) {}

  public async Task<IEnumerable<Offer>> ListAll() {
    return await context.Offers.ToListAsync();
  }

  public async Task Add(Offer offer) {
    await context.Offers.AddAsync(offer);
  }

  public async Task<Offer?> FindById(long id) {
    return await context.Offers.FindAsync(id);
  }

  public void Update(Offer offer) {
    context.Offers.Update(offer);
  }

  public void Remove(Offer offer) {
    context.Offers.Remove(offer);
  }
}
