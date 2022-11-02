using waw_auth_service.Domain.Models;

namespace waw_auth_service.Authorization.Handlers.Interfaces;

public interface IJwtHandler {
  string GenerateToken(User user);
  long? ValidateToken(string token);
}
