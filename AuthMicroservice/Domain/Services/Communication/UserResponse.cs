using AuthMicroservice.Domain.Models;
namespace AuthMicroservice.Domain.Services.Communication;

public class UserResponse : BaseResponse<User> {
  public UserResponse(string message) : base(message) {}
  public UserResponse(User resource) : base(resource) {}
}
