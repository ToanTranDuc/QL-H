using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public int ID_DangNhap { get; set; } // Primary key
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        // Navigation Property để lấy thông tin Nhân Viên
        public NhanVien NhanVien { get; set; }

    }
}
