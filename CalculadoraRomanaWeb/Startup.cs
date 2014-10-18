using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculadoraRomanaWeb.Startup))]
namespace CalculadoraRomanaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
