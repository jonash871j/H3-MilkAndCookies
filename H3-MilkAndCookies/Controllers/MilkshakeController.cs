using Microsoft.AspNetCore.Mvc;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MilkshakeController : ControllerBase
    {
        [HttpGet(Name = "GetFavoriteMilkshake")]
        public void Get(string favoriteMilkshake)
        {
            Response.Cookies.Append("favoriteMilkshake", favoriteMilkshake);
        }

        [HttpGet(Name = "GetFromCookie")]
        [Route("[action]")]
        public void GetFromCookie()
        {
            string? cookie = Request.Cookies["favoriteMilkshake"];
            if (cookie != null)
            {
                Console.WriteLine(cookie);
            }
        }
    }
}
