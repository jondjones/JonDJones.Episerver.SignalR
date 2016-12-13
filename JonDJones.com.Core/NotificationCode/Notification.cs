using System;
using System.Globalization;

namespace JonDJones.com.Core.NotificationCode
{
    public class Notification
    {
        public Notification()
        {
            Date = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            Read = false;
        }

        public string Date { get; set; }

        public string Message { get; set; }

        public bool Read { get; set;  }
    }
}