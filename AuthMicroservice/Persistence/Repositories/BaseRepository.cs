using AuthMicroservice.Persistence.Contexts;

namespace AuthMicroservice.Persistence.Repositories;

public class BaseRepository {
  protected readonly AppDbContext context;

  public BaseRepository(AppDbContext context) {
    this.context = context;
  }
}
