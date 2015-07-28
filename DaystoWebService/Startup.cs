using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DaystoWebService.Startup))]
namespace DaystoWebService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
