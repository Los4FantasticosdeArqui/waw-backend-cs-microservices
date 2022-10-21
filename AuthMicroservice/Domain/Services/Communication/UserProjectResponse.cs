using AuthMicroservice.Domain.Models;

namespace AuthMicroservice.Domain.Services.Communication;

public class UserProjectResponse : BaseResponse<UserProject> {
  public UserProjectResponse(string message) : base(message) {}
  public UserProjectResponse(UserProject resource) : base(resource) {}
}
