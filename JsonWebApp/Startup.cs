using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JsonWebApp.Startup))]
namespace JsonWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
