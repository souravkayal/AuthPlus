using AuthPlus.Domain.Notification.Request;
using AuthPlus.Service.Interface.Notification;
using Microsoft.AspNetCore.Mvc;

namespace AuthPlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly INotificationService _notificationService; 

        public NotificationController(ILogger<WeatherForecastController> logger, INotificationService notificationService)
        {
            this._logger = logger;  
            this._notificationService = notificationService;
        }


        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] SendNotificationRequest sendNotificationRequest)
        {
            return Ok(await _notificationService.SendNotification(sendNotificationRequest));
        }


        [HttpPost("verify")]
        public async Task<ActionResult> VerifyNotification([FromBody] SendNotificationRequest sendNotificationRequest)
        {
            return Ok();
        }


    }
}
