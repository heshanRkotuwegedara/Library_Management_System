using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibrarymanagementSystem.Startup))]
namespace LibrarymanagementSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
