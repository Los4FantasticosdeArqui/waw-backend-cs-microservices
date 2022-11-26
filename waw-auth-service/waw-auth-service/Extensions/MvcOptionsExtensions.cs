using Microsoft.AspNetCore.Mvc;
using waw_auth_service.Utils;

namespace waw_auth_service.Extensions;

// Adapted from https://stackoverflow.com/a/58406404/15040387
public static class MvcOptionsExtensions {
  public static void UseGeneralRoutePrefix(this MvcOptions options, string prefix) {
    var routeAttribute = new RouteAttribute(prefix);
    var prefixConvention = new RoutePrefixConvention(routeAttribute);
    options.Conventions.Add(prefixConvention);
  }
}
