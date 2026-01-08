using System.ComponentModel.DataAnnotations;

namespace HocCoreMVC.Models
{
    public class UngTuyen
    {
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [Phone]
        public string SoDienThoai { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn vị trí")]
        public string ViTriUngTuyen { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn kinh nghiệm")]
        public string KinhNghiem { get; set; }
    }
}
