namespace waw_auth_service.Resources;

public class AuthResource : UserResource {
  public string Token { get; set; } = string.Empty;
}
