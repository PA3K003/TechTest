using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TechTest.ServiceConsumer.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureAutomapper();
        }
        private void ConfigureAutomapper()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<Employee, EmployeeModel>(); cfg.CreateMap<EmployeeModel, Employee>();

            //});

        }
    }
}
