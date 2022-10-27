namespace waw_employer_service.Domain.Model
{
    public class Company : BaseModel {
      public string Name { get; set; } = string.Empty;
      public string? Address { get; set; }
      public string Email { get; set; } = string.Empty;
    }
}

