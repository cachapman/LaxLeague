using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeagueSite.Startup))]
namespace LeagueSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
