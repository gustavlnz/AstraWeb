using Microsoft.AspNetCore.Mvc;

namespace AstraWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly Services.SellersServices _sellersServices;
        public SellersController(Services.SellersServices sellersServices)
        {
            _sellersServices = sellersServices;
        }
        public IActionResult Index()
        {
            var list = _sellersServices.FindAll();
            return View(list);
        }
    }
}
