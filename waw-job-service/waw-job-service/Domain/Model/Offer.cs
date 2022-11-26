namespace waw_job_service.Domain.Model;

public class Offer : BaseModel {
  public string Title { get; set; } = string.Empty;
  public string? Image { get; set; }
  public string Description { get; set; } = string.Empty;
  public string SalaryRange { get; set; } = string.Empty;
  public bool Status { get; set; }
}
