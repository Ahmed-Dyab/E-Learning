
using Microsoft.AspNetCore.Mvc;


namespace E_Learning.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
    }

}
