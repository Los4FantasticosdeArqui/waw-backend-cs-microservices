using AuthMicroservice.Domain.Models;
using AuthMicroservice.Domain.Services.Communication;

namespace AuthMicroservice.Domain.Services;

public interface IUserProjectService {
  Task<IList<UserProject>> ListByUserId(long userId);

  Task<UserProjectResponse> Add(UserProject request);

  Task<UserProjectResponse> Update(long id, UserProject request);

  Task<bool> Remove(long id, long userId);
}
