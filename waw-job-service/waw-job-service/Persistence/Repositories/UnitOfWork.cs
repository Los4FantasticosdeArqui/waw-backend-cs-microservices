using waw_job_service.Domain.Repositories;
using waw_job_service.Persistence.Contexts;

namespace waw_job_service.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork {
  private readonly AppDbContext context;

  public UnitOfWork(AppDbContext context) {
    this.context = context;
  }

  public async Task Complete() {
    await context.SaveChangesAsync();
  }
}
