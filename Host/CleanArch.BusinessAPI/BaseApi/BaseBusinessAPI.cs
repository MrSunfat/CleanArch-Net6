using CleanArch.BusinessAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.BusinessAPI
{
    [ApiController]
    [Route("[controller]")]
    public class BaseBusinessAPI : ControllerBase {
        protected readonly AppConfig _appConfig;

        public BaseBusinessAPI(IServiceProvider provider)
        {
            _appConfig = provider.GetRequiredService<AppConfig>();
        }

        [AllowAnonymous]
        [HttpGet("test")]
        public IActionResult Get() {
            return Ok("Test Get!");
        }
    }
}