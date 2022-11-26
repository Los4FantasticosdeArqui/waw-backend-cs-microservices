using waw_auth_service.Authorization.Middleware;

namespace waw_auth_service.Extensions;

public static class JwtMiddlewareExtensions {
  public static IApplicationBuilder UseJwtMiddleware(this IApplicationBuilder builder) {
    return builder.UseMiddleware<JwtMiddleware>();
  }
}
