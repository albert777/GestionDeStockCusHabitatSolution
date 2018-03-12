using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionDeStockCusHabitat.Startup))]
namespace GestionDeStockCusHabitat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
