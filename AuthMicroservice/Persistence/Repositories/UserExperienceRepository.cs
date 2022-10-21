using Microsoft.EntityFrameworkCore;
using AuthMicroservice.Domain.Models;
using AuthMicroservice.Domain.Repositories;
using AuthMicroservice.Persistence.Contexts;
using AuthMicroservice.Persistence.Repositories;

namespace AuthMicroservice.Persistence.Repositories;

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
