using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PragmaticUnited.Startup))]
namespace PragmaticUnited
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
