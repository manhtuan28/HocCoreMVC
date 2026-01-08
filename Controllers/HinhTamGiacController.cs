using HocCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HocCoreMVC.Controllers
{
    public class HinhTamGiacController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new HinhTamGiacModel());
        }

        [HttpPost]
        public IActionResult Index(HinhTamGiacModel tg)
        {
            // Kiểm tra điều kiện tạo thành tam giác: Tổng 2 cạnh phải lớn hơn cạnh còn lại
            if (tg.CanhA + tg.CanhB > tg.CanhC &&
                tg.CanhA + tg.CanhC > tg.CanhB &&
                tg.CanhB + tg.CanhC > tg.CanhA)
            {
                // 1. Tính Chu vi
                tg.ChuVi = tg.CanhA + tg.CanhB + tg.CanhC;

                // 2. Tính Diện tích (Công thức Heron)
                double p = tg.ChuVi / 2; // Nửa chu vi
                tg.DienTich = Math.Sqrt(p * (p - tg.CanhA) * (p - tg.CanhB) * (p - tg.CanhC));

                // Làm tròn số cho đẹp (lấy 2 chữ số thập phân)
                tg.DienTich = Math.Round(tg.DienTich, 2);

                tg.DaTinh = true;
            }
            else
            {
                // Nếu không thỏa mãn, gửi lỗi ra View
                ModelState.AddModelError("CanhC", "Ba cạnh này không tạo thành một tam giác hợp lệ!");
            }

            return View(tg);
        }
    }
}
