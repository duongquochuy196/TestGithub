using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGihub.Startup))]
namespace TestGihub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //ádf
        // Thay đổi lần 3
        }
    }
}
