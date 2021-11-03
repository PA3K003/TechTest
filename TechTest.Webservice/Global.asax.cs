using AutoMapper;
using System;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TechTest.DAL;
using TechTest.Model;

namespace TechTest.Webservice
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<EmployeeDbContext>(null);
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
.Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                              "text/html",
                              StringComparison.InvariantCultureIgnoreCase,
                              true,
                              "application/json"));
            ConfigureAutomapper();
        }
        private void ConfigureAutomapper()
        {
            //AutoMapper.Mapper.Mapper.Initialize(cfg => {
            //    cfg.CreateMap<Employee, EmployeeModel>(); cfg.CreateMap<EmployeeModel, Employee>();

            //});
           
        }
    }
}
