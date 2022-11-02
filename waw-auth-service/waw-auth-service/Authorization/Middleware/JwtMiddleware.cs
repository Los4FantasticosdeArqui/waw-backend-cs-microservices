using System.Net;
using System.Net.Mime;
using System.Text.Json;
using waw_auth_service.Authorization.Handlers.Interfaces;
using waw_auth_service.Domain.Services;
using waw_auth_service.Domain.Services.Communication;

namespace waw_auth_service.Authorization.Middleware;

public class JwtMiddleware {
  private readonly RequestDelegate next;

  public JwtMiddleware(RequestDelegate next) {
    this.next = next;
  }

  public async Task Invoke(HttpContext context, IUserService userService, IJwtHandler jwtHandler) {
    var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
    if (string.IsNullOrEmpty(token)) {
      await next(context);
      return;
    }

    var userId = jwtHandler.ValidateToken(token);
    if (userId is null) {
      await next(context);
      return;
    }

    var user = await userService.FindById(userId.Value);
    if (user is null) {
      var response = context.Response;
      response.ContentType = MediaTypeNames.Application.Json;
      response.StatusCode = (int) HttpStatusCode.NotFound;
      var body = new ErrorResponse("User not found");
      var result = JsonSerializer.Serialize(body);
      await response.WriteAsync(result);
      return;
    }

    context.Items["User"] = user;
    await next(context);
  }
}
