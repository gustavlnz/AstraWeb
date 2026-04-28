using Microsoft.AspNetCore.Mvc;

namespace AstraWebMvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
