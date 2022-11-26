using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Services.Communication;

namespace waw_auth_service.Domain.Services;

public interface IUserEducationService {
  Task<IList<UserEducation>> ListByUserId(long userId);

  Task<UserEducationResponse> Add(UserEducation request);

  Task<UserEducationResponse> Update(long id, UserEducation request);

  Task<bool> Remove(long id, long userId);
}
