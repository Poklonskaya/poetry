﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Mvc4WebApplication
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            logger.Info("Application Start");
        }
        public void Init()
        {
            logger.Info("Application Init");
        }

        public void Dispose()
        {
            logger.Info("Application Dispose");
        }

        protected void Application_Error()
        {
            var e = new InvalidCastException("My error");

            logger.Error("Application_Error", e);
        }


        protected void Application_End()
        {
            logger.Info("Application End");
        }
    }

}  
    
        
            
  

      
    

