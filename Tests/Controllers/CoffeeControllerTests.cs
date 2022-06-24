using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        CoffeeController controller = new CoffeeController();
        
        [Test]
        public void TestGetCoffeeLover()
        {
            string expectedContent = "I like coffee!";
            var result = controller.GetCoffeeLover();
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void TestForWhenValueIsNotProvided()
        {
            var expectedContent = new Coffee ("latte", -1);
            var result = controller.GetCoffee(null);
            Assert.AreEqual(expectedContent.ToString(), result.ToString());
        }
        
        [Test]
        public void TestForWhenValueIsProvided()
        {            
            string coffeeType = "cappuccino";
            var expectedContent = new Coffee("cappuccino", 10); ;
            var result = controller.GetCoffee(coffeeType);
            Assert.AreEqual(expectedContent.ToString(), result.ToString());
        }
    }
}
