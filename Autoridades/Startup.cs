using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autoridades.Startup))]
namespace Autoridades
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
