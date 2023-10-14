using Microsoft.AspNetCore.Mvc;

namespace PizzaOrderSystem.MVC.Controllers
{
    public class OrderSystemController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
        public IActionResult GetPay()
        {
            return View();
        }


    }
}
