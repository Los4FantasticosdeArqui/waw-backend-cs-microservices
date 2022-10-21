using AuthMicroservice.Domain.Models;

namespace AuthMicroservice.Authorization.Handlers.Interfaces;

public interface IJwtHandler {
  string GenerateToken(User user);
  long? ValidateToken(string token);
}
