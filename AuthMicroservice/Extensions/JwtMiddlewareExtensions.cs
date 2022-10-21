using AuthMicroservice.Authorization.Middleware;

namespace AuthMicroservice.Extensions;

public static class JwtMiddlewareExtensions {
  public static IApplicationBuilder UseJwtMiddleware(this IApplicationBuilder builder) {
    return builder.UseMiddleware<JwtMiddleware>();
  }
}