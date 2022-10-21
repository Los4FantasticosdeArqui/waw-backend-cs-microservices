using AuthMicroservice.Domain.Models;
using AuthMicroservice.Domain.Services.Communication;

namespace AuthMicroservice.Domain.Services;

public interface IUserEducationService {
  Task<IList<UserEducation>> ListByUserId(long userId);

  Task<UserEducationResponse> Add(UserEducation request);

  Task<UserEducationResponse> Update(long id, UserEducation request);

  Task<bool> Remove(long id, long userId);
}
