﻿using Microsoft.AspNetCore.Mvc;

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
    }
}
