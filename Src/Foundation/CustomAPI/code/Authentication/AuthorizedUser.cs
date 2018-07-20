using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Sitecore;
using Sitecore.Security.Domains;

namespace M1CP.Foundation.CustomAPI.Authentication
{
    public class AuthorizedUser : AuthorizationFilterAttribute
    {

        private readonly string _role;
        public AuthorizedUser(string role)
        {
            _role = role;
        }


        public override void OnAuthorization(HttpActionContext actionContext)
        {
            base.OnAuthorization(actionContext);
            var context = Context.User;

            if (Context.User.IsAdministrator || Context.User.IsInRole($"sitecore\\{_role}") && Context.User.IsAuthenticated)
                return;

            actionContext.Response =
                actionContext.ControllerContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Unauthorized Access; User is " + Context.User.LocalName);
        }
    }




}