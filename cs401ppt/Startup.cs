using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cs401ppt.Startup))]
namespace cs401ppt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
