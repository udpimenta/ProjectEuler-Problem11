using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Problem11.UI.WebApplicationMVC.Startup))]
namespace Problem11.UI.WebApplicationMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
