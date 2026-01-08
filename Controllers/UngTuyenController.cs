using HocCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HocCoreMVC.Controllers
{
    public class UngTuyenController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UngTuyen model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            return View();
        }
    }
}
