using waw_auth_service.Domain.Models;

namespace waw_auth_service.Domain.Repositories;

public interface IUserExperienceRepository {
  Task<UserExperience?> GetById(long id);

  Task<IList<UserExperience>> ListByUserId(long userId);

  Task Add(UserExperience userExperience);

  void Update(UserExperience userExperience);

  void Remove(UserExperience userExperience);
}
