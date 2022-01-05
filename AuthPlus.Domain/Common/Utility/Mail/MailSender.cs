using AuthPlus.Domain.Common.Utility.Mail;
using AuthPlus.Domain.Notification.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AuthPlus.Domain.Common.Utility
{
    public class MailSender : IMailSender
    {
        public bool SendMail(SendNotificationRequest sendNotificationRequest)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(sendNotificationRequest.From);
                mail.To.Add(sendNotificationRequest.To);
                mail.Subject = "OTP from AuthPlus";
                mail.Body = "OTP Send - " + new Random().Next(1000, 9999);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ctrlcvprogrammer@gmail.com", "");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                //hdnle exception
                return false;
            }
        }
    }
}
