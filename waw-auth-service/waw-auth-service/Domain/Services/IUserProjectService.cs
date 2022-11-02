using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Services.Communication;

namespace waw_auth_service.Domain.Services;

public interface IUserProjectService {
  Task<IList<UserProject>> ListByUserId(long userId);

  Task<UserProjectResponse> Add(UserProject request);

  Task<UserProjectResponse> Update(long id, UserProject request);

  Task<bool> Remove(long id, long userId);
}
