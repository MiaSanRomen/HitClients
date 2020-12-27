using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HitClients.Cloud.Startup))]
namespace HitClients.Cloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
