using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Fsd.Lukasz.Cs.Ex4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Aspplication_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutofacConfig.Configure();
        }
    }
}