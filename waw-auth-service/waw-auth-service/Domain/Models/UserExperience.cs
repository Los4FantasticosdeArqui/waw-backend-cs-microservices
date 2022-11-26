// using WAW.API.Employers.Domain.Models;
namespace waw_auth_service.Domain.Models;

public class UserExperience : BaseModel {
  public string Title { get; set; } = string.Empty;
  public string Location { get; set; } = string.Empty;
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public string TimeDiff { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;

  // Relationships
  public long? ImageId { get; set; }
  public ExternalImage? Image { get; set; }

  // public long? CompanyId { get; set; }
  // public Company? Company { get; set; }

  public long? UserId { get; set; }
  public User? User { get; set; }
}
