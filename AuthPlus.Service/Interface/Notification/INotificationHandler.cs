using AuthPlus.Domain.Notification.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPlus.Service.Interface.Notification
{
    public interface INotificationHandler
    {
        public Task<bool> Handle(SendNotificationRequest notification);
    }
}
