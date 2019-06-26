using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wisdombite.MVC.Startup))]
namespace Wisdombite.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
