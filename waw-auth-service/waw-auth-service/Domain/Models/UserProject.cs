namespace waw_auth_service.Domain.Models;

public class UserProject : BaseModel {
  public string Title { get; set; } = string.Empty;
  public string Summary { get; set; } = string.Empty;
  public DateTime Date { get; set; }

  // Relationships
  public long? ImageId { get; set; }
  public ExternalImage? Image { get; set; }

  public long? UserId { get; set; }
  public User? User { get; set; }
}
