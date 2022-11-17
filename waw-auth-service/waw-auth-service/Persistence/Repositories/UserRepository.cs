using Microsoft.EntityFrameworkCore;
using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Repositories;
using waw_auth_service.Persistence.Contexts;

namespace waw_auth_service.Persistence.Repositories;

public class UserRepository : BaseRepository, IUserRepository {
  public UserRepository(AppDbContext context) : base(context) {}

  public async Task<IEnumerable<User>> ListAll() {
    return await context.Users.ToListAsync();
  }

  public async Task<IList<UserEducation>?> ListEducationByUser(long userId) {
    var user = await context.Users.Where(x => x.Id == userId)
      .Include(x => x.Education)
      .ThenInclude(x => x.Image)
      .SingleOrDefaultAsync();

    return user?.Education;
  }

  public async Task<IList<UserExperience>?> ListExperienceByUser(long userId) {
    var user = await context.Users.Where(x => x.Id == userId)
      .Include(x => x.Experience)
      // .ThenInclude(x => x.Company)
      .SingleOrDefaultAsync();

    return user?.Experience;
  }

  public async Task<IList<UserProject>?> ListProjectsByUser(long userId) {
    var user = await context.Users.Where(x => x.Id == userId)
      .Include(x => x.Projects)
      .ThenInclude(x => x.Image)
      .SingleOrDefaultAsync();

    return user?.Projects;
  }

  public async Task Add(User user) {
    await context.Users.AddAsync(user);
  }

  public async Task<User?> FindById(long id) {
    return await context.Users.Where(u => u.Id == id)
      .Include(u => u.Cover)
      .Include(u => u.Picture)
      .FirstOrDefaultAsync();
  }

  public async Task<User?> FindByEmail(string email) {
    return await context.Users.Where(u => u.Email == email)
      .Include(u => u.Cover)
      .Include(u => u.Picture)
      .FirstOrDefaultAsync();
  }

  public bool ExistsByEmail(string email) {
    return context.Users.Any(x => x.Email == email);
  }

  public void Update(User user) {
    context.Users.Update(user);
  }
}
