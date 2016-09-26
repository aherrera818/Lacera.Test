using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaceraWebApp.Startup))]
namespace LaceraWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
