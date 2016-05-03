using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TestMobileAppShasService.Startup))]

namespace TestMobileAppShasService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}