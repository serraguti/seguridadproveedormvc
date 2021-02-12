using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguridadProveedorMVC.Startup))]
namespace SeguridadProveedorMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
