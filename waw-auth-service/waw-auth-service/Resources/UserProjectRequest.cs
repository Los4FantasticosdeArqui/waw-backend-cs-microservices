using System.ComponentModel.DataAnnotations;

namespace waw_auth_service.Resources;

public class UserProjectRequest {
  [Required]
  public string? Title { get; set; }
  [Required]
  public string? Summary { get; set; }
  [Required]
  public DateTime? Date { get; set; }

  public ExternalImageRequest? Image { get; set; }
}
