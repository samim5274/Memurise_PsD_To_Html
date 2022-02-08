using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Memoris.Startup))]
namespace Memoris
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
