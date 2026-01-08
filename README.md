# 🚀 HocCoreMVC - Bộ Bài Tập Thực Hành ASP.NET Core MVC

Chào mừng đến với dự án **HocCoreMVC**. Đây là kho lưu trữ các bài tập thực hành, các module chức năng nhỏ được xây dựng trên nền tảng **ASP.NET Core MVC** để rèn luyện kỹ năng Web Development, xử lý Logic C# và thao tác với Model-View-Controller.

## 🛠️ Công Nghệ Sử Dụng
* **Framework:** ASP.NET Core MVC (.NET 6.0 / .NET 8.0)
* **Ngôn ngữ:** C#
* **Front-end:** HTML5, CSS3, Bootstrap 5, Tailwind CSS
* **IDE:** Visual Studio 2022

## 📂 Danh Sách Chức Năng (Modules)

Dự án bao gồm các Controller xử lý các bài toán nghiệp vụ cụ thể như sau:

### 1. Quản Lý Sự Kiện (`SuKienController`)
* **Chức năng:** CRUD (Thêm, Xem, Sửa, Xóa) thông tin đăng ký tham gia sự kiện.
* **Logic:**
    * Tính tổng tiền dựa trên loại vé (Standard/VIP).
    * Tự động giảm giá **10%** nếu mua từ 5 vé trở lên.
    * Tìm kiếm và lọc danh sách khách hàng.
* **Model:** `DangKySuKien.cs`

### 2. Tiện Ích Hình Học (`HinhChuNhatController`, `HinhTamGiacController`)
* **Chức năng:** Tính toán các thông số hình học cơ bản.
* **Logic:**
    * Nhập chiều dài, chiều rộng (Hình chữ nhật) -> Trả về Chu vi, Diện tích.
    * Nhập cạnh và chiều cao (Hình tam giác) -> Tính diện tích.
* **Model:** `HinhChuNhatModel.cs`, `HinhTamGiacModel.cs`

### 3. Đặt Phòng Khách Sạn (`DatPhongController`)
* **Chức năng:** Form đặt phòng cho khách hàng.
* **Logic:** Xử lý thông tin check-in, check-out và thông tin khách hàng.
* **Model:** `DatPhong.cs`

### 4. Giỏ Hàng & Thương Mại Điện Tử (`GioHangController`)
* **Chức năng:** Mô phỏng chức năng giỏ hàng đơn giản.
* **Logic:** Thêm sản phẩm, tính tổng tiền đơn hàng.
* **Model:** `GioHang.cs`

### 5. Tuyển Dụng (`UngTuyenController`)
* **Chức năng:** Form nộp hồ sơ ứng tuyển việc làm.
* **Logic:** Validate thông tin ứng viên, upload CV (nếu có).
* **Model:** `UngTuyen.cs`

### 6. Các Tiện Ích Khác
* **`TinhToanController`**: Thực hiện các phép tính toán học cơ bản (+, -, *, /).
* **`ChaySoController`**: Xử lý các bài toán về vòng lặp, xử lý chuỗi hoặc thuật toán số học.

## 📸 Giao Diện Demo
*(Bạn có thể thêm ảnh chụp màn hình các trang web của bạn vào đây)*

## 🚀 Cài Đặt & Chạy Dự Án

1.  **Clone dự án:**
    ```bash
    git clone [https://github.com/manhtuan28/HocCoreMVC.git](https://github.com/manhtuan28/HocCoreMVC.git)
    ```
2.  **Mở dự án:**
    Mở file `HocCoreMVC.sln` bằng Visual Studio 2022.
3.  **Restore Packages:**
    Visual Studio sẽ tự động restore các gói NuGet cần thiết.
4.  **Chạy ứng dụng:**
    Nhấn `F5` hoặc nút `Run` (IIS Express / https) để khởi chạy trình duyệt.

## 👤 Tác Giả
* **Dev:** Tuancute
* **Mục tiêu:** Master ASP.NET Core MVC & Fullstack Web Dev.

---
*Happy Coding!* 💻