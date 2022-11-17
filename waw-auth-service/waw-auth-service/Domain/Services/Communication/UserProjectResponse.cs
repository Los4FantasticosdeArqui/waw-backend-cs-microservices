using waw_auth_service.Domain.Models;

namespace waw_auth_service.Domain.Services.Communication;

public class UserProjectResponse : BaseResponse<UserProject> {
  public UserProjectResponse(string message) : base(message) {}
  public UserProjectResponse(UserProject resource) : base(resource) {}
}
