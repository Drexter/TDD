using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Autofac;
using Autofac.Integration.Web;
using TDDSample.Data;
using TDDSample.Data.Infrastructure;



namespace TDDSample.Web
{
    public class Global : System.Web.HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;

        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            //MOCKED DATA: Uncomment if you want to use it.
            //builder.RegisterType<MockEmployeeData>().As<IEmployeeData>().InstancePerRequest();

            //DB DATA: Actual Data coming from the database.
            builder.RegisterType<EmployeeData>().As<IEmployeeData>().InstancePerRequest();
            _containerProvider = new ContainerProvider(builder.Build());
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}