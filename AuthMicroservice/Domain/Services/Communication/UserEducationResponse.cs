using AuthMicroservice.Domain.Models;

namespace AuthMicroservice.Domain.Services.Communication;

public class UserEducationResponse : BaseResponse<UserEducation> {
  public UserEducationResponse(string message) : base(message) {}
  public UserEducationResponse(UserEducation resource) : base(resource) {}
}
