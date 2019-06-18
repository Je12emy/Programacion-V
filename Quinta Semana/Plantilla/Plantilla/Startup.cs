using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plantilla.Startup))]
namespace Plantilla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
