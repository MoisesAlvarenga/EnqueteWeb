
using Microsoft.AspNetCore.Mvc;


namespace EnqueteWeb.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

    }
}
