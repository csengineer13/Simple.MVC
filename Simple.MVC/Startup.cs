using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple.MVC.Startup))]
namespace Simple.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
