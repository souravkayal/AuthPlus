using AuthPlus.Domain.Common.Utility.Mail;
using AuthPlus.Domain.Notification.Request;
using AuthPlus.Service.Interface.Notification;

namespace AuthPlus.Service.Implementation.Notification
{
    public class NotificationService : INotificationService
    {

        private readonly INotificationHandler  _notificationHandler;

        public NotificationService(INotificationHandler notificationHandler)
        {
            this._notificationHandler = notificationHandler;
        }

        public async Task<bool>  SendNotification(SendNotificationRequest sendNotificationRequest)
        {
            await this._notificationHandler.Handle(sendNotificationRequest);
            
            return await Task.FromResult(true);
        }
    }
}
