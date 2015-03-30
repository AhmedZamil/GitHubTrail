using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTrail.Startup))]
namespace GitHubTrail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
