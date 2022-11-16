using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prjASPMVCFirstApp.Startup))]
namespace prjASPMVCFirstApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
