using Microsoft.AspNetCore.Mvc;
using MilkAndCookies.Utility;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MilkshakeController : ControllerBase
    {
        [HttpGet]
        public string Get(string favoriteMilkshake)
        {
            Response.Cookies.Append("favoriteMilkshake", favoriteMilkshake, CookieUtility.DefaultOptions);
            return "Your favorite milkshake is " + favoriteMilkshake;
        }

        [HttpGet]
        [Route("[action]")]
        public string GetFromCookie()
        {
            string? cookie = Request.Cookies["favoriteMilkshake"];
            if (cookie != null)
            {
                return "Your favorite milkshake from cookie is " + cookie;
            }
            return "Unknown";
        }
    }
}
