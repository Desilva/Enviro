using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace env.Utilities
{
    public class AuthorizeUserAttribute : AuthorizeAttribute
    {
        private string returnUrl = "";

        public AuthorizeUserAttribute(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var isAuthorized = base.AuthorizeCore(httpContext);
            if (!isAuthorized)
            {
                return false;
            }

            if (httpContext.Session["user"] == null)
            {
                return false;
            }

            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var routeData = filterContext.RouteData;
            var controllerName = routeData.Values["controller"].ToString();
            var actionName = routeData.Values["action"].ToString();
            if (controllerName == "FSR" || controllerName == "PriorityMatrix" || controllerName == "ProjectCharter")
            {
                actionName = "Edit";
            }
            var area = "";
            var id = "";
            //if (routeData.Values.Count > 2)
            //{
            //    area = routeData.Values["area"].ToString();
            //    id = routeData.Values["id"].ToString();
            //}
            var url = new UrlHelper(filterContext.RequestContext);
            filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new
                            {
                                controller = "Account",
                                action = "Login",
                                returnUrl = returnUrl,
                                e = filterContext.HttpContext.Request.Params["e"],
                                c = url.Action(actionName, controllerName, new { area = area, id = id })
                            })
                        );
        }
    }
}