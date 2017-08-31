using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Avenue.Admin.Startup))]
namespace Avenue.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
