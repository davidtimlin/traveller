using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravellerMVC.Startup))]
namespace TravellerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
