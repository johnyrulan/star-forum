using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarForum.Presentation.Web.Startup))]
namespace StarForum.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
