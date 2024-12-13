using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int ID_NhanVien { get; set; }
        public int ID_DangNhap { get; set; }
        public string Ho_Ten { get; set; }
        public DateTime Ngay_Sinh { get; set; }
        public string Gioi_Tinh { get; set; }
        public string Dia_Chi { get; set; }
        public string Que_Quan { get; set; }
        public string CCCD { get; set; }
        public DateTime Ngay_Cap { get; set; }
        public string Noi_Cap { get; set; }
        public string So_Dien_Thoai { get; set; }
        public string Email { get; set; }
        public int ID_ChucVu { get; set; }
        public DateTime Ngay_Tao { get; set; }
        public string Nguoi_Tao { get; set; }
        public DateTime Ngay_Cap_Nhat { get; set; }
        public string Nguoi_Cap_Nhat { get; set; }
        public byte[] Duong_Dan_Anh { get; set; }
        public string Trang_Thai { get; set; }

        public TaiKhoan TaiKhoan { get; set; } //Liên kết bảng tài khoản
        public ChucVu ChucVu { get; set; }//Liên kết bảng chức vụ
        public List<NhanVien_Quyen> NhanVienQuyen { get; set; }
    }
}
