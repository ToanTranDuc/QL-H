using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NCC
    {
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string Email { get; set; }
        public string MST { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime NgayTao { get; set; }
        public string TrangThai { get; set; }

        public NCC() { }
        
        public NCC(int maNCC, string tenNCC, string mst, string email, string diaChi, string dienThoai, string nguoiTao, DateTime ngayCapNhat, string nguoiCapNhat, DateTime ngayTao, string trangThai)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            MST = mst;
            Email = email;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            NguoiTao = nguoiTao;
            NgayCapNhat = ngayCapNhat;
            NguoiCapNhat = nguoiCapNhat;
            NgayTao = ngayTao;
            TrangThai = trangThai;
        }
    }
}
