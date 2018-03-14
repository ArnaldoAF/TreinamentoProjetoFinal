using GAtec.Northwind.Business;
using GAtec.Northwind.Data;
using GAtec.Northwind.Domain.Business;
using GAtec.Northwind.Domain.Repository;
using GAtec.Northwind.Util;
using GAtec.Northwind.Util.Validation;
using GAtec.Northwind.Web.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace GAtec.Northwind.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public UnityContainer Container { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Container = new UnityContainer();

            Container.RegisterType<ICategoryRepository, CategoryRepository>();
            Container.RegisterType<ICategoryService, CategoryService>();
            Container.RegisterType<IValidationError, DefaultValidation>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(Container));
        }
    }
}
