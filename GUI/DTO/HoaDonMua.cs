using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class HoaDonMua
    {
        private int MaNCC;
        private int MaHDM;
        private DateTime? DateNhap;
        private string GhiChu;
        private string TrangThai;
        private double TongTien;

        public int MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public int MaHDM1 { get => MaHDM; set => MaHDM = value; }
        public DateTime? DateNhap1 { get => DateNhap; set => DateNhap = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
        public double TongTien1 { get => TongTien; set => TongTien = value; }

        public HoaDonMua(int MaNCC, DateTime? DateNhap, string GhiChu, int MaPN, string TrangThai, double TongTien)
        {
            this.MaNCC1 = MaNCC;
            this.DateNhap1 = DateNhap;
            this.GhiChu1 = GhiChu;
            this.MaHDM = MaPN;
            this.TongTien = TongTien;
            this.TrangThai = TrangThai;
        }
        public HoaDonMua(DataRow row)
        {
            this.MaNCC1 = (int)row["MaNCC"];
            this.MaHDM = (int)row["ID_DonDatHang"];
            this.DateNhap1 = (DateTime?)row["NgayDat"];
            this.GhiChu1 = row["GhiChu"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            this.TongTien = double.Parse(row["TongGia"].ToString());

        }
    }
}
