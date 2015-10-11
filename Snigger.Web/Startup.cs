using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Snigger.Web.Startup))]
namespace Snigger.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
