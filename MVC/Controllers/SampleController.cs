using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;

namespace MvcCore.Controllers
{
    public class SampleController : Controller
    {
        public string hello(string name,int num=3)
        {
            return "Happy Valentines Day Dear " + name + "Are you the one" + num;
        }
        public IActionResult Index(string name,int value)
        {
            ViewData["name"] = name;
            ViewData["value"] = value;
            return View();
        }
        public IActionResult GetCustomer()
        {
            Customer customer = new Customer()
            { CustomerId = 100, CustomerName = "Gayu", Gender = "F", City = "Chennai", Region = "TamilNadu" };
            return View("CustomerDisplay",customer);

            

        }
        public IActionResult NewCustomer()
        {
            return View();
        }
        public IActionResult SubmitCustomer(Customer customer) {
            return View("CustomerDisplay",customer);
            

        }
        public IActionResult GetMovie()
        {
            Movie movie = new Movie() { Title = "dada", Description = "nice movie", rating = 5, Price = 150 };
       

            return View(""); }
    }
}
