using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranDucTai_2090694906_BigSchool.Startup))]
namespace TranDucTai_2090694906_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
