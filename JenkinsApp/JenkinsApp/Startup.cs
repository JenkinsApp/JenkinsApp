using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsApp.Startup))]
namespace JenkinsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
