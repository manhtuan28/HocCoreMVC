using HocCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HocCoreMVC.Controllers
{
    public class HinhChuNhatController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new HinhChuNhatModel());
        }

        [HttpPost]
        public IActionResult Index(HinhChuNhatModel hcn)
        {
            hcn.ChuVi = (hcn.ChieuDai + hcn.ChieuRong) * 2;
            hcn.DienTich = hcn.ChieuDai * hcn.ChieuRong;

            hcn.DaTinh = true;

            return View(hcn);
        }
    }
}
