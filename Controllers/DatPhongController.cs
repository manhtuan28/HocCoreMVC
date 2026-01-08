using Microsoft.AspNetCore.Mvc;
using HocCoreMVC.Models;

namespace HocCoreMVC.Controllers
{
    public class DatPhongController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            DatPhong model = new DatPhong()
            {
                NgayNhanPhong = DateTime.Now,
                NgayTraPhong = DateTime.Now.AddDays(1),
                SoNguoiLon = 2,
                SoTreEm = 0
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(DatPhong model)
        {
            TimeSpan thoiGian = model.NgayTraPhong - model.NgayNhanPhong;
            int soNgay = thoiGian.Days;

            if (soNgay <= 0)
            {
                model.ThongBaoLoi = "Ngày trả phòng phải lớn hơn ngày nhận phòng!";
                model.TongTien = 0;
            }
            else
            {
                model.SoNgayO = soNgay;

                decimal giaPhongCoBan = 1500000;
                decimal phuThuTreEm = 100000;

                decimal giaMotDem = giaPhongCoBan + (model.SoTreEm * phuThuTreEm);
                model.TongTien = giaMotDem * soNgay;
            }

            return View(model);
        }
    }
}
