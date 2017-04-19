﻿using CinemaUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CinemaUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var errMsg = Server.GetLastError().Message;
            if (string.IsNullOrWhiteSpace(errMsg)) return;
            Response.RedirectToRoute(new { Controller = "Error",Action = "", strErrMsg=errMsg});
            this.Context.ClearError();
          
        }
      

    }
}