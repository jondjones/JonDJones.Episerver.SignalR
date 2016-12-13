using System;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using JonDJones.Com.Core.Pages;

namespace JonDJones.com.Core.NotificationCode
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class NotificationGeneratorIntalisationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            context.InitComplete += InitCompleteHandler;

            var events = ServiceLocator.Current.GetInstance<IContentEvents>();
            events.PublishedContent += EventsPublishedContent;
        }

        private void EventsPublishedContent(object sender, ContentEventArgs e)
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            var content = repo.Get<IContent>(e.ContentLink);

            if (!(content is ContentPage))
                return;

            var notification = new Notification
            {
                Message = "Content Page Published Notification"
            };

            NotificationCentre.Instance.AddNewNotification(notification);
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