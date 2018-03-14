using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GAtec.Northwind.Web.Startup))]
namespace GAtec.Northwind.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
