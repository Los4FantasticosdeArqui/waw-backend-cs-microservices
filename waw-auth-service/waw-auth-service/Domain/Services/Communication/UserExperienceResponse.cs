using waw_auth_service.Domain.Models;

namespace waw_auth_service.Domain.Services.Communication;

public class UserExperienceResponse : BaseResponse<UserExperience> {
  public UserExperienceResponse(string message) : base(message) {}
  public UserExperienceResponse(UserExperience resource) : base(resource) {}
}
