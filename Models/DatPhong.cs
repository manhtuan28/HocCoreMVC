using System;
using System.ComponentModel.DataAnnotations;

namespace HocCoreMVC.Models
{
    public class DatPhong
    {
        public string HoTen { get; set; }
        public DateTime NgayNhanPhong { get; set; }
        public DateTime NgayTraPhong { get; set; }
        public int SoNguoiLon { get; set; }
        public int SoTreEm { get; set; }

        public int SoNgayO { get; set; }
        public decimal TongTien { get; set; }
        public string ThongBaoLoi { get; set; }
    }
}
