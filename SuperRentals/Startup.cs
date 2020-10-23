using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperRentals.Startup))]
namespace SuperRentals
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
