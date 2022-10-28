using Microsoft.EntityFrameworkCore;
using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Repositories;
using waw_auth_service.Persistence.Contexts;

namespace waw_auth_service.Persistence.Repositories;

public class UserEducationRepository : BaseRepository, IUserEducationRepository {
  public UserEducationRepository(AppDbContext context) : base(context) {}

  public async Task<UserEducation?> GetById(long id) {
    return await context.UserEducation.FindAsync(id);
  }

  public async Task<IList<UserEducation>> ListByUserId(long userId) {
    return await context.UserEducation.Where(x => x.UserId == userId).Include(x => x.Image).ToListAsync();
  }

  public async Task Add(UserEducation userEducation) {
    await context.UserEducation.AddAsync(userEducation);
  }

  public void Update(UserEducation userEducation) {
    context.UserEducation.Update(userEducation);
  }

  public void Remove(UserEducation userEducation) {
    context.UserEducation.Remove(userEducation);
  }
}
