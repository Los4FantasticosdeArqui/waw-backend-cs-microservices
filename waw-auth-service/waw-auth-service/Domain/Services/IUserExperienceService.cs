using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Services.Communication;

namespace waw_auth_service.Domain.Services;

public interface IUserExperienceService {
  Task<IList<UserExperience>> ListByUserId(long userId);

  Task<UserExperienceResponse> Add(UserExperience request);

  Task<UserExperienceResponse> Update(long id, UserExperience request);

  Task<bool> Remove(long id, long userId);
}
