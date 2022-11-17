using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace waw_auth_service.Resources;

public class ExternalImageRequest {
  [SwaggerSchema("User fullname", Nullable = false)]
  [Required]
  public string? Href { get; set; }

  [SwaggerSchema("Image alternative title", Nullable = true)]
  public string? Alt { get; set; }
}
