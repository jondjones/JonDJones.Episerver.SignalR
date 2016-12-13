using System.Reflection;
using EPiServer.BaseLibrary.Scheduling;
using EPiServer.Logging.Compatibility;
using EPiServer.PlugIn;

namespace JonDJones.com.Core.NotificationCode
{
    [ScheduledPlugIn(DisplayName = "Notification Scheduled Task",
    SortIndex = 100)]
    public class NotificationScheduledTask : JobBase
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static bool MessagesPushed = false;

        public NotificationScheduledTask()
        {
            IsStoppable = true;
        }

        public override string Execute()
        {
            var notification = new Notification
            {
                Message = "Schedule Task Notification"
            };

            NotificationCentre.Instance.AddNewNotification(notification);
            return ToString();
        }
        public override string ToString()
        {
            return string.Format(
            "Message pushed = {0} ",
            MessagesPushed);
        }
    }
}