using Microsoft.Owin;
using Owin;

//[assembly: OwinStartupAttribute(typeof(LineBotApp.Startup))]
namespace LineBotApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
