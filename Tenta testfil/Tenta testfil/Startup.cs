using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tenta_testfil.Startup))]
namespace Tenta_testfil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
