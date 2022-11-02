﻿using Microsoft.AspNetCore.Mvc;
using waw_chat_service.Utils;

namespace waw_chat_service.Extensions;

public static class MvcOptionsExtensions {
    public static void UseGeneralRoutePrefix(this MvcOptions options, string prefix) {
        var routeAttribute = new RouteAttribute(prefix);
        var prefixConvention = new RoutePrefixConvention(routeAttribute);
        options.Conventions.Add(prefixConvention);
    }
}