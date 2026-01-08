using HocCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HocCoreMVC.Controllers
{
    public class TinhToanController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new TinhToanModel());
        }
        [HttpPost]
        public IActionResult Index(TinhToanModel model)
        {
            switch (model.PhepTinh)
            {
                case "Cong":
                    model.KetQua = model.SoThuNhat + model.SoThuHai;
                    break;
                case "Tru":
                    model.KetQua = model.SoThuNhat - model.SoThuHai;
                    break;
                case "Nhan":
                    model.KetQua = model.SoThuNhat * model.SoThuHai;
                    break;
                case "Chia":
                    if (model.SoThuHai == 0)
                    {
                        ModelState.AddModelError("SoThuHai", "Không thể chia cho số 0");
                        return View(model);
                    }
                    model.KetQua = model.SoThuNhat / model.SoThuHai;
                    break;
            }

            model.DaTinh = true;
            return View(model);
        }
    }
}
