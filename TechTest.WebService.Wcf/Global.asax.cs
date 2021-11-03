using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using TechTest.DAL;
using TechTest.Model;

namespace TechTest.WebService.Wcf
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            Database.SetInitializer<EmployeeDbContext>(null);
                   ConfigureAutomapper();
        }
        private void ConfigureAutomapper()
        {/// Old static code
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<Employee, EmployeeModel>(); cfg.CreateMap<EmployeeModel, Employee>();

            //});

        }

    }
}
//protected void Application_Start(object sender, EventArgs e)
//{

//}

//protected void Session_Start(object sender, EventArgs e)
//{

//}

//protected void Application_BeginRequest(object sender, EventArgs e)
//{

//}

//protected void Application_AuthenticateRequest(object sender, EventArgs e)
//{

//}

//protected void Application_Error(object sender, EventArgs e)
//{

//}

//protected void Session_End(object sender, EventArgs e)
//{

//}

//protected void Application_End(object sender, EventArgs e)
//{

//}
