using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekti.Startup))]
namespace Projekti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
