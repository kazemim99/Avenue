using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Avenue.Admin.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
