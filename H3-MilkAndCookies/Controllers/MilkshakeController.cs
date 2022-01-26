using Microsoft.AspNetCore.Mvc;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MilkshakeController : ControllerBase
    {
        [HttpGet(Name = "GetMilkshake")]
        public string Get(string favoriteMilkshake)
        {
            return "Your favorite milkshake is " + favoriteMilkshake;
        }
    }
}
