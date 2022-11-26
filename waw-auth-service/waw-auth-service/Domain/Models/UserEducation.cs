namespace waw_auth_service.Domain.Models;

public class UserEducation : BaseModel {
  public string University { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public int StartYear { get; set; }
  public int EndYear { get; set; }

  // Relationships
  public long? ImageId { get; set; }
  public ExternalImage? Image { get; set; }

  public long? UserId { get; set; }
  public User? User { get; set; }
}
