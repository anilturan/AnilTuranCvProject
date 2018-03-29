using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnilTuran.Startup))]
namespace AnilTuran
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
