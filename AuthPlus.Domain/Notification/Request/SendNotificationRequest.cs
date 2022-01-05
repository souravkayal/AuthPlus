using AuthPlus.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPlus.Domain.Notification.Request
{
    public class SendNotificationRequest
    {
        public string To { get; set; }
        public string From { get; set; }
        public NotificationChannel Channel { get; set; }
    }
}
