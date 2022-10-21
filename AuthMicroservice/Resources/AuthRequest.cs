using System.ComponentModel.DataAnnotations;

namespace AuthMicroservice.Resources;

public class AuthRequest {
  [Required]
  public string Email { get; set; } = string.Empty;

  [Required]
  public string Password { get; set; } = string.Empty;
}
