using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrelloClone.Startup))]
namespace TrelloClone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
