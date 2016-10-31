using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignments2.Startup))]
namespace Assignments2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
