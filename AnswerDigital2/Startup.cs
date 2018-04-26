using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnswerDigital2.Startup))]
namespace AnswerDigital2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
