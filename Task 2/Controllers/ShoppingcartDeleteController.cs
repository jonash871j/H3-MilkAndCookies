using Microsoft.AspNetCore.Mvc;
using MilkAndCookies.Models;
using MilkAndCookies.Utility;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingcartDeleteController : ControllerBase
    {
        [HttpDelete]
        public IEnumerable<Product> Delete(string name)
        {
            var products = HttpContext.Session.GetObjectFromJson<List<Product>>("ShoppingcartKey");
            if (products == null)
            {
                return Enumerable.Empty<Product>();
            }
            products.RemoveAll(p => p.Name == name);
            HttpContext.Session.SetObjectAsJson("ShoppingcartKey", products);
            return products;
        }
    }
}
