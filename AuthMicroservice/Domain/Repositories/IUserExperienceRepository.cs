using AuthMicroservice.Domain.Models;

namespace AuthMicroservice.Domain.Repositories;

public interface IUserExperienceRepository {
  Task<UserExperience?> GetById(long id);

  Task<IList<UserExperience>> ListByUserId(long userId);

  Task Add(UserExperience userExperience);

  void Update(UserExperience userExperience);

  void Remove(UserExperience userExperience);
}
