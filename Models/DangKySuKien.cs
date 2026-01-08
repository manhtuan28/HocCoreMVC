using System.ComponentModel.DataAnnotations;

namespace HocCoreMVC.Models
{
    public class DangKySuKien
    {
        // Thêm ID để quản lý Sửa/Xóa
        public int Id { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Display(Name = "Số vé")]
        [Required(ErrorMessage = "Vui lòng nhập số vé")]
        [Range(1, 100, ErrorMessage = "Số vé phải từ 1 đến 100")]
        public int SoVe { get; set; }

        [Display(Name = "Loại vé")]
        public string LoaiVe { get; set; }

        [Display(Name = "Thành tiền")]
        public double ThanhTien
        {
            get
            {
                double giaVe = (LoaiVe == "VIP") ? 1000000 : 500000;
                double tong = SoVe * giaVe;

                if (SoVe >= 5)
                {
                    tong = tong * 0.9;
                }
                return tong;
            }
        }
    }
}