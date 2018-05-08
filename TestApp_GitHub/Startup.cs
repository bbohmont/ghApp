using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApp_GitHub.Startup))]
namespace TestApp_GitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
