using JonDJones.com.Core.NotificationCode;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace JonDJones.com.Core.NotificationCode
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
             app.MapSignalR();
        }
    }
}