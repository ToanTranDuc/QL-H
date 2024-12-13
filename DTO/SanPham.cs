using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public float GiaNhap { get; set; }
        public float GiaBan { get; set; }
        public DateTime NgayNhap { get; set; }
        public byte[] HinhAnh { get; set; }
        public int MaHang { get; set; }
        public int MaNCC { get; set; }
        public int MaTheLoai { get; set; }
        public int MaXuatXu { get; set; }
        public int MaMauSac { get; set; }
        public int MaKieuDang { get; set; }
        public string TrangThai { get; set; }
        public int SoLuong {  get; set; }



        public SanPham() { }

        // Constructor đầy đủ tham số
        public SanPham(int maSP, string tenSP, string moTa, int mahang, int mancc, int maxuatXu, int matheLoai,
                       int mamauSac, int makieuDang, float giaNhap, float giaBan, DateTime ngayNhap, byte[] hinhAnh, int soLuong, string trangThai)
        {
            MaSP = maSP;
            TenSP = tenSP;
            MoTa = moTa;
            MaHang = mahang;
            MaNCC = mancc;
            MaXuatXu = maxuatXu;
            MaTheLoai = matheLoai;
            MaMauSac = mamauSac;
            MaKieuDang = makieuDang;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            NgayNhap = ngayNhap;
            HinhAnh = hinhAnh;
            SoLuong = soLuong;
            TrangThai = trangThai;
        }

    }
}
