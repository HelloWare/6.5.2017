using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeSystem.Startup))]
namespace ResumeSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
