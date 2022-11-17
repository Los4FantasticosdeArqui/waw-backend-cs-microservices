using waw_auth_service.Domain.Models;

namespace waw_auth_service.Domain.Repositories;

public interface IUserProjectRepository {
  Task<UserProject?> GetById(long id);

  Task<IList<UserProject>> ListByUserId(long userId);

  Task Add(UserProject userProject);

  void Update(UserProject userProject);

  void Remove(UserProject userProject);
}
