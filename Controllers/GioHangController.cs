using Microsoft.AspNetCore.Mvc;
using HocCoreMVC.Models;

namespace HocCoreMVC.Controllers
{
    public class GioHangController : Controller
    {
        [HttpGet]
        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(GioHang model)
        {
            model.ThanhTien = model.SoLuongSanPham * model.DonGia;
            
            if(model.ThanhTien > 500000)
            {
                model.Phi = 0;
            }
            else
            {
                model.Phi = 30000;
            }

            model.TongThanhToan = model.ThanhTien + model.Phi;

            return View(model);
        }
    }
}
