using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaymentGatewayAsp.Startup))]
namespace PaymentGatewayAsp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
