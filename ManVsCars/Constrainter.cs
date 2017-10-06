using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Collections.Immutable;

namespace ManVsCars
{
    public class Constrainter: IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext,Route route,string parameterName,RouteValueDictionary values,RouteDirection routeDirection)
        {
            object possibleObj;
            if(values.TryGetValue(parameterName,out possibleObj) && possibleObj != null)
            {
                ImmutableHashSet<string> validStrs = new HashSet<string>() { "chair","salt" }.ToImmutableHashSet<string>();
                return validStrs.Contains(possibleObj.ToString(), StringComparer.OrdinalIgnoreCase);
            }
            return false;
        }
    }
}