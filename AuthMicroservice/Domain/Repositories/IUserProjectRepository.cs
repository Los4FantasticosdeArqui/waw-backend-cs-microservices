using AuthMicroservice.Domain.Models;

namespace AuthMicroservice.Domain.Repositories;

public interface IUserProjectRepository {
  Task<UserProject?> GetById(long id);

  Task<IList<UserProject>> ListByUserId(long userId);

  Task Add(UserProject userProject);

  void Update(UserProject userProject);

  void Remove(UserProject userProject);
}
