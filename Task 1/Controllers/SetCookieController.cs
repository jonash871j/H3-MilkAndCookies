using Microsoft.AspNetCore.Mvc;
using MilkAndCookies.Utility;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SetCookieController : ControllerBase
    {
        [HttpGet]
        public string Get(string cookieData)
        {
            Response.Cookies.Append("cookieData", cookieData, CookieUtility.DefaultOptions);
            return "Your data is " + cookieData;
        }
    }
}
