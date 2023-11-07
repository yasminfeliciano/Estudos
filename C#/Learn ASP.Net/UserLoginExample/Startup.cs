using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserLoginExample.Startup))]
namespace UserLoginExample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
