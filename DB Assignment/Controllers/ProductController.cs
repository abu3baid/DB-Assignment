using DB_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DB_Assignment.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult MyName()
        {
            return Ok("My name is Mohammed Abu Ibaid");
        }
        [HttpPost]
        public IActionResult Price()
        {
            Product product = new Product();
            product.Name = "Acer Laptop";
            product.Price = 1300.00;
            return Ok($"{product.Name} Price is {product.Price}$");
        }
    }
}
