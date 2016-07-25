using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningEmailAuth.Startup))]
namespace LearningEmailAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
