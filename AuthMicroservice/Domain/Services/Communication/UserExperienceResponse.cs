using AuthMicroservice.Domain.Models;


namespace AuthMicroservice.Domain.Services.Communication;

public class UserExperienceResponse : BaseResponse<UserExperience> {
  public UserExperienceResponse(string message) : base(message) {}
  public UserExperienceResponse(UserExperience resource) : base(resource) {}
}
