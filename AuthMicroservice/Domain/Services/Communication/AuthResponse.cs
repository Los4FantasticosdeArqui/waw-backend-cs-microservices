using AuthMicroservice.Resources;
using AuthMicroservice.Domain.Services.Communication;

namespace AuthMicroservice.Domain.Services.Communication;

public class AuthResponse : BaseResponse<AuthResource> {
  public AuthResponse(string message) : base(message) {}
  public AuthResponse(AuthResource resource) : base(resource) {}
}
