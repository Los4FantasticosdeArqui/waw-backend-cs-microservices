using AuthMicroservice.Domain.Models;
using AuthMicroservice.Domain.Services.Communication;

namespace AuthMicroservice.Domain.Services;

public interface IUserExperienceService {
  Task<IList<UserExperience>> ListByUserId(long userId);

  Task<UserExperienceResponse> Add(UserExperience request);

  Task<UserExperienceResponse> Update(long id, UserExperience request);

  Task<bool> Remove(long id, long userId);
}
