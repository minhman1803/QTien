using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QTien.Startup))]
namespace QTien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
