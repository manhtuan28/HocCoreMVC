using Microsoft.AspNetCore.Mvc;
using HocCoreMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace HocCoreMVC.Controllers
{
    public class SuKienController : Controller
    {
        private static List<DangKySuKien> _danhSach = new List<DangKySuKien>
        {
            new DangKySuKien { Id = 1, HoTen = "Nguyen Van A", Email = "a@gmail.com", SoVe = 2, LoaiVe = "Standard" },
            new DangKySuKien { Id = 2, HoTen = "Tran Thi B", Email = "b@gmail.com", SoVe = 6, LoaiVe = "VIP" }
        };

        public IActionResult Index(string searchString, string sortOrder)
        {
            var result = from s in _danhSach select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                result = result.Where(s => s.HoTen.ToLower().Contains(searchString.ToLower()));
            }

            switch (sortOrder)
            {
                case "ve_desc":
                    result = result.OrderByDescending(s => s.SoVe);
                    break;
                default:
                    result = result.OrderBy(s => s.Id);
                    break;
            }

            return View(result.ToList());
        }

        public IActionResult Details(int id)
        {
            var item = _danhSach.FirstOrDefault(x => x.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DangKySuKien model)
        {
            if (ModelState.IsValid)
            {
                model.Id = _danhSach.Count > 0 ? _danhSach.Max(x => x.Id) + 1 : 1;
                _danhSach.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var item = _danhSach.FirstOrDefault(x => x.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(DangKySuKien model)
        {
            if (ModelState.IsValid)
            {
                var existingItem = _danhSach.FirstOrDefault(x => x.Id == model.Id);
                if (existingItem != null)
                {
                    existingItem.HoTen = model.HoTen;
                    existingItem.Email = model.Email;
                    existingItem.SoVe = model.SoVe;
                    existingItem.LoaiVe = model.LoaiVe;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var item = _danhSach.FirstOrDefault(x => x.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = _danhSach.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _danhSach.Remove(item);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}