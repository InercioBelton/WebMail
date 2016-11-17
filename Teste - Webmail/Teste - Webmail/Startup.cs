using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teste___Webmail.Startup))]
namespace Teste___Webmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
