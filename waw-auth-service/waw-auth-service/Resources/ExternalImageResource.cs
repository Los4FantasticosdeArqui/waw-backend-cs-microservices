using Swashbuckle.AspNetCore.Annotations;

namespace waw_auth_service.Resources;

public class ExternalImageResource {
  [SwaggerSchema("Image identifier", Nullable = false, ReadOnly = true)]
  public long Id { get; set; }

  [SwaggerSchema("Image URI", Nullable = false)]
  public string? Href { get; set; }

  [SwaggerSchema("Image alternative title", Nullable = true)]
  public string? Alt { get; set; }
}
