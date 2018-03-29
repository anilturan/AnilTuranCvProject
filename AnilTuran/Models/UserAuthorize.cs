using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnilTuran.Models
{
    public class UserAuthorize: AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
           // LoginViewModel model = new LoginViewModel() { Email = "anl.turan@hotmail.com" };
           if(httpContext.Request.Cookies[".AspNet.ApplicationCookie"] !=null )
            {
                return true;
            }
           else
            {
                httpContext.Response.Redirect("/Account/Login");
                return false;
            }
        }
    }
}