using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HakatonFinale.Startup))]
namespace HakatonFinale
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
