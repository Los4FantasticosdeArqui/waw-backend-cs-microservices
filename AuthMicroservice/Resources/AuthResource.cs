namespace AuthMicroservice.Resources;

public class AuthResource : UserResource {
  public string Token { get; set; } = string.Empty;
}
