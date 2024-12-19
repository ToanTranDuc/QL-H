using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class SanPham
    {
        private int id;
        private int idHang;
        private int idNCC;
        private int idXuatXu;
        private int idKieuDang;
        private int idMauSac;
        private int idTheLoai;
        private double GiaNhap;
        private double GiaBan;
        private string TenSP;
        private string MoTa;
        private DateTime? NgayNhap;
        private int SoLuong;

        public int Id { get => id; set => id = value; }
        public int IdHang { get => idHang; set => idHang = value; }
        public int IdNCC { get => idNCC; set => idNCC = value; }
        public int IdXuatXu { get => idXuatXu; set => idXuatXu = value; }
        public int IdKieuDang { get => idKieuDang; set => idKieuDang = value; }
        public int IdMauSac { get => idMauSac; set => idMauSac = value; }
        public int IdTheLoai { get => idTheLoai; set => idTheLoai = value; }
        public double GiaNhap1 { get => GiaNhap; set => GiaNhap = value; }
        public double GiaBan1 { get => GiaBan; set => GiaBan = value; }
        public string TenSP1 { get => TenSP; set => TenSP = value; }
        public string MoTa1 { get => MoTa; set => MoTa = value; }
        public DateTime? NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }

        public SanPham(int id, int idHang, int idNCC, int idXuatXu, int idKieuDang, int idMauSac, int idTheLoai, double GiaNhap, double GiaBan, string TenSP, string MoTa, DateTime? Ngaynhap, int SoLuong)
        {
            this.id = id;
            this.idHang = idHang;
            this.idNCC = idNCC;
            this.idXuatXu = idXuatXu;
            this.idKieuDang = idKieuDang;
            this.idMauSac = idMauSac;
            this.idTheLoai = idTheLoai;
            this.TenSP = TenSP;
            this.MoTa = MoTa;
            this.GiaBan = GiaBan;
            this.GiaNhap = GiaNhap;
            this.NgayNhap = Ngaynhap;
            this.SoLuong= SoLuong;
        }
        public SanPham(DataRow row)
        {
            this.id = (int)row["MaSP"];
            this.idHang = (int)row["MaHang"];
            this.idNCC = (int)row["MaNCC"];
            this.idXuatXu = (int)row["MaXuatXu"];
            this.idKieuDang = (int)row["MaKieuDang"];
            this.idMauSac = (int)row["MaMauSac"];
            this.idTheLoai = (int)row["MaTheLoai"];
            this.TenSP = row["TenSP"].ToString();
            this.MoTa = row["MoTa"].ToString();
            this.GiaBan = double.Parse(row["GiaBan"].ToString());
            this.GiaNhap = double.Parse(row["GiaNhap"].ToString());
            this.NgayNhap = (DateTime?)row["NgayNhap"];
            this.SoLuong = (int)row["SoLuong"];
        }
    }
}
