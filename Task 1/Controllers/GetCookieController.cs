using Microsoft.AspNetCore.Mvc;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetCookieController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string? cookie = Request.Cookies["cookieData"];
            if (cookie != null)
            {
                return "Cookie data is " + cookie;
            }
            return "Unknown";
        }
    }
}
