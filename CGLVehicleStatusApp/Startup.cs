using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CGLVehicleStatusApp.Startup))]
namespace CGLVehicleStatusApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
