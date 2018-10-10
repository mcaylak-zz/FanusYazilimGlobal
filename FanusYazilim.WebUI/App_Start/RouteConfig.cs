using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FanusYazilim.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Category", id = UrlParameter.Optional }
            //);
            routes.MapRoute("Default", "", new { controller = "Home", action = "Statistics" });


            routes.MapRoute("Category", "Category", new { controller = "Home", action = "Category" });
            routes.MapRoute("AddCategory", "AddCategory", new { controller = "Home", action = "AddCategory" });
            routes.MapRoute("DeleteCategory", "DeleteCategory/{categoryId}", new { controller = "Home", action = "DeleteCategory" });

            routes.MapRoute("Advertisement", "Advertisement", new { controller = "Home", action = "Advertisement" });
            routes.MapRoute("AddAdvertisement", "AddAdvertisement", new { controller = "Home", action = "AddAdvertisement" });


            routes.MapRoute("Content", "Content", new { controller = "Home", action = "Content" });
            routes.MapRoute("Contents", "Contents", new { controller = "Home", action = "Contents" });
            routes.MapRoute("AddContent", "AddContent", new { controller = "Home", action = "AddContent" });
            routes.MapRoute("Deletecontent", "DeleteContent{ContentID}", new { controller = "Home", action = "DeleteContent" });

            routes.MapRoute("Statistics", "Statistics", new { controller = "Home", action = "Statistics" });


            routes.MapRoute("Logout", "Logout", new { controller = "Login", action = "Logout" });


            routes.MapRoute("ChangePassword", "ChangePassword", new { controller = "Home", action = "ChangePassword" });
            routes.MapRoute("NewPassword", "NewPassword/{guid}", new { controller = "Login", action = "NewPassword" });



            routes.MapRoute("Login", "Login", new { controller = "Login", action = "Login" });
            routes.MapRoute("ForgotPass", "ForgotPassword", new { controller = "Login", action = "ForgotPassword" });
            
        }
    }
}
