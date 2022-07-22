using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADODemo1.Startup))]
namespace ADODemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
