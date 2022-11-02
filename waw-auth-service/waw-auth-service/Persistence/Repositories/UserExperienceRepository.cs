using Microsoft.EntityFrameworkCore;
using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Repositories;
using waw_auth_service.Persistence.Contexts;

namespace waw_auth_service.Persistence.Repositories;

public class UserExperienceRepository : BaseRepository, IUserExperienceRepository {
  public UserExperienceRepository(AppDbContext context) : base(context) {}

  public async Task<UserExperience?> GetById(long id) {
    return await context.UserExperience.FindAsync(id);
  }

  public async Task<IList<UserExperience>> ListByUserId(long userId) {
    return await context.UserExperience.Where(x => x.UserId == userId)
      .Include(x => x.Image)
     // .Include(x => x.Company)
      .ToListAsync();
  }

  public async Task Add(UserExperience userExperience) {
    await context.UserExperience.AddAsync(userExperience);
  }

  public void Update(UserExperience userExperience) {
    context.UserExperience.Update(userExperience);
  }

  public void Remove(UserExperience userExperience) {
    context.UserExperience.Remove(userExperience);
  }
}
