using AstraWebMvc.Models;
using AstraWebMvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AstraWebMvc.Data;

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
        public IActionResult Create()
        {
            // Busca todos os departamentos e envia para a View
            var departments = _sellersServices.FindAllDepartment();
            ViewBag.DepartmentId = new SelectList(departments, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellersServices.Insert(seller);
            return RedirectToAction(nameof(Index));

        }
       
    }
}
