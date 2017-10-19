using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rsms.Startup))]
namespace rsms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
