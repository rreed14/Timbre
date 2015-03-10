using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Timbre.Startup))]
namespace Timbre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
