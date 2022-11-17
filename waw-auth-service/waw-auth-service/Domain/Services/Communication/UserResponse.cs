using waw_auth_service.Domain.Models;

namespace waw_auth_service.Domain.Services.Communication;

public class UserResponse : BaseResponse<User> {
  public UserResponse(string message) : base(message) {}
  public UserResponse(User resource) : base(resource) {}
}
