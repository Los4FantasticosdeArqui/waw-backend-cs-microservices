using waw_auth_service.Resources;

namespace waw_auth_service.Domain.Services.Communication;

public class AuthResponse : BaseResponse<AuthResource> {
  public AuthResponse(string message) : base(message) {}
  public AuthResponse(AuthResource resource) : base(resource) {}
}
