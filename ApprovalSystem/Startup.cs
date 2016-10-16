using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApprovalSystem.Startup))]
namespace ApprovalSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
