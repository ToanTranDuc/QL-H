using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDong
    {
        public int MaHopDong { get; set; }
        public string TenHopDong { get; set; }
        public DateTime NgayKy { get; set; }
        public string NguoiKy { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayHieuLuc { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal GiaTri { get; set; }
        public string TrangThai { get; set; }
        public int MaNCC { get; set; }
        public HopDong() { }

        public HopDong(int maHopDong, string tenHopDong, DateTime ngayKy, string nguoiKy, string moTa, DateTime ngayHieuLuc, DateTime ngayHetHan, decimal giaTri, string trangThai, int maNCC)
        {
            MaHopDong = maHopDong;
            TenHopDong = tenHopDong;
            NgayKy = ngayKy;
            NguoiKy = nguoiKy;
            MoTa = moTa;
            NgayHieuLuc = ngayHieuLuc;
            NgayHetHan = ngayHetHan;
            GiaTri = giaTri;
            TrangThai = trangThai;
            MaNCC = maNCC;
        }
    }
}
