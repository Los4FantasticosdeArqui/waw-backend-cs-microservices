 
namespace AuthMicroservice.Domain.Models;
public class ExternalImage : BaseModel {
  public string Href { get; set; } = string.Empty;
  public string? Alt { get; set; }
}
