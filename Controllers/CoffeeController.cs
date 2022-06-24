using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("lover")]
        public string GetCoffeeLover()
        {
            return "I like coffee!";
        }

        [HttpGet("")]
        [HttpGet("{name}")]
        public Coffee GetCoffee(string? name)
        {
            return new Coffee(name ?? "latte", (name != null ? name.Length : -1));
        }
        //[HttpGet("")]
        //public string GetCoffeeDefault()
        //{
        //    return "Search a Coffee!";
        //}
    }
}
