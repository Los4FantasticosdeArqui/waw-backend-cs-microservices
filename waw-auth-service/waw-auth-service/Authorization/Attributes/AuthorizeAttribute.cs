using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Services.Communication;

namespace waw_auth_service.Authorization.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter {
  public void OnAuthorization(AuthorizationFilterContext context) {
    var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();

    if (allowAnonymous) return;

    var user = (User?) context.HttpContext.Items["User"];
    if (user is not null) return;

    var body = new ErrorResponse("Unauthorized");
    context.Result = new JsonResult(body) {StatusCode = StatusCodes.Status401Unauthorized,};
  }
}
