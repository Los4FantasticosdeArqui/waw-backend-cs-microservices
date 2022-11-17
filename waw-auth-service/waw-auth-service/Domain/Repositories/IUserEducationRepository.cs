using waw_auth_service.Domain.Models;

namespace waw_auth_service.Domain.Repositories;

public interface IUserEducationRepository {
  Task<UserEducation?> GetById(long id);

  Task<IList<UserEducation>> ListByUserId(long userId);

  Task Add(UserEducation userEducation);

  void Update(UserEducation userEducation);

  void Remove(UserEducation userEducation);
}
