using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GolpoPuri.Startup))]
namespace GolpoPuri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
