using AuthPlus.Domain.Notification.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPlus.Domain.Common.Utility.Mail
{
    public interface IMailSender
    {
        bool SendMail(SendNotificationRequest sendNotificationRequest);
    }
}
