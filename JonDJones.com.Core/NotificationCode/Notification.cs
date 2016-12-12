using System;
using System.Globalization;

namespace JonDJones.com.Core.NotificationCode
{
    public class Notification
    {
        public Notification()
        {
            Message = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            Read = false;
        }

        public string Message { get; }

        public bool Read { get; set;  }
    }
}