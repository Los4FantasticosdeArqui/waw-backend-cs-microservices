using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace waw_auth_service.Resources;

public class UserCreateRequest {
  [SwaggerSchema("User fullname", Nullable = false)]
  [Required]
  public string? FullName { get; set; }

  [SwaggerSchema("User preferred name to use in the app", Nullable = false)]
  [Required]
  public string? PreferredName { get; set; }

  [SwaggerSchema("User email", Nullable = false)]
  [Required]
  public string? Email { get; set; }

  [SwaggerSchema("User location", Nullable = true)]
  public string? Location { get; set; }

  [SwaggerSchema("User biography", Nullable = true)]
  public string? Biography { get; set; }

  [SwaggerSchema("User abstract", Nullable = true)]
  public string? About { get; set; }

  [SwaggerSchema("User birthdate", Nullable = false)]
  [Required]
  public DateTime? Birthdate { get; set; }

  [SwaggerSchema("User password", Nullable = false)]
  [Required]
  public string? Password { get; set; }

  [SwaggerSchema("User cover picture", Nullable = true)]
  public ExternalImageRequest? Cover { get; set; }

  [SwaggerSchema("User profile picture", Nullable = true)]
  public ExternalImageRequest? Picture { get; set; }
}
