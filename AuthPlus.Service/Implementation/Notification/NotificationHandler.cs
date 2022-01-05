using AuthPlus.Domain.Common.Utility.Mail;
using AuthPlus.Domain.Notification.Request;
using AuthPlus.Service.Interface.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPlus.Service.Implementation.Notification
{

    public class NotificationHandler : INotificationHandler
    {
        private readonly IMailSender _mailSender;

        public NotificationHandler(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public Task<bool> Handle(SendNotificationRequest sendNotificationRequest)
        {
            //TODO : put this in DB


            //TODO : Inject logic for sending various type of notification using 
            _mailSender.SendMail(sendNotificationRequest);
            return Task.FromResult(true);   
        }
    }
}
