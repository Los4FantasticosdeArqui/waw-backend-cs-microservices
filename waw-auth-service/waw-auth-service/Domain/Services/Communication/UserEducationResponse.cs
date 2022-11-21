using waw_auth_service.Domain.Models;

namespace waw_auth_service.Domain.Services.Communication;

public class UserEducationResponse : BaseResponse<UserEducation> {
  public UserEducationResponse(string message) : base(message) {}
  public UserEducationResponse(UserEducation resource) : base(resource) {}
}
