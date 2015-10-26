using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentRegistrationPortal.Startup))]
namespace StudentRegistrationPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
