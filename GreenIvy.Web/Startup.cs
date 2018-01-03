using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenIvy.Web.Startup))]
namespace GreenIvy.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
