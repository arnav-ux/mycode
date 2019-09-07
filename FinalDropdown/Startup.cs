using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalDropdown.Startup))]
namespace FinalDropdown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
