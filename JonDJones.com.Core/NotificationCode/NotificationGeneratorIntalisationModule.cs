using System;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace JonDJones.com.Core.NotificationCode
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class NotificationGeneratorIntalisationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            context.InitComplete += InitCompleteHandler;
        }

        public void Preload(string[] parameters)
        {
 
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        private void InitCompleteHandler(object sender, EventArgs e)
        {
        }
    }
}