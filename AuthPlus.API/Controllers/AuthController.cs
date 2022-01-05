using AuthPlus.Domain.Entity;
using AuthPlus.Domain.Notification.Request;
using AuthPlus.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AuthPlus.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IUserService _userService;

        public AuthController(ILogger<WeatherForecastController> logger , IUserService userService)
        {
            _logger = logger;
            _userService = userService;    
        }

        [HttpGet]
        public async Task<User> Okey()
        {
            return await _userService.Get();
        }

        
    }
}
