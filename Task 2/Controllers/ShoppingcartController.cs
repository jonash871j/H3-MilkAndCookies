using Microsoft.AspNetCore.Mvc;
using MilkAndCookies.Models;
using MilkAndCookies.Utility;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingcartController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get(string name, double price)
        {
            var products = HttpContext.Session.GetObjectFromJson<List<Product>>("ShoppingcartKey");
            if (products == null)
            {
                products = new List<Product>();
            }
            products.Add(new Product { Name = name, Price = price });
            HttpContext.Session.SetObjectAsJson("ShoppingcartKey", products);
            return products;
        }
    }
}
