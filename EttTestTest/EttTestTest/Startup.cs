using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EttTestTest.Startup))]
namespace EttTestTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
