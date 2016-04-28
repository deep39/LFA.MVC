using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFA.MVC.Startup))]
namespace LFA.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
