using System.Collections.Generic;
using Microsoft.AspNet.SignalR;

namespace JonDJones.com.Core.NotificationCode
{
    public class NotificationHub : Hub
    {
        private readonly NotificationCentre _notificationCentre;

        public NotificationHub() : this(NotificationCentre.Instance) { }

        public NotificationHub(NotificationCentre notificationCentre)
        {
            _notificationCentre = notificationCentre;
        }

        public IEnumerable<Notification> GetNotifications()
        {
            return _notificationCentre.GetAllSystemNotifications();
        }

        public void MarkNotifacationsAsRead()
        {
            _notificationCentre.MarkNotificationAsRead();
        }

        public void DeleteAllNotifications()
        {
            _notificationCentre.DeleteAllNotifications();
        }
    }
}