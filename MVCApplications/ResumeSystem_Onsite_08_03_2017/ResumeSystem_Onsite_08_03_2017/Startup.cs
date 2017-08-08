using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeSystem_Onsite_08_03_2017.Startup))]
namespace ResumeSystem_Onsite_08_03_2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
