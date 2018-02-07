using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HappinessForm.Startup))]
namespace HappinessForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
