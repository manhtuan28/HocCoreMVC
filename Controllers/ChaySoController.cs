using Microsoft.AspNetCore.Mvc;

namespace HocCoreMVC.Controllers
{
    public class ChaySoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
