using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class HoaDonBan
    {
        private int MaHD;
        private double TongTien;
        private DateTime? DateNhap;
        private string GhiChu;

        public int MaHD1 { get => MaHD; set => MaHD = value; }
        public double TongTien1 { get => TongTien; set => TongTien = value; }
        public DateTime? DateNhap1 { get => DateNhap; set => DateNhap = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }

        public HoaDonBan(int MaHD, DateTime? DateNhap, string GhiChu, double TongTien)
        {
            this.MaHD = MaHD;
            this.TongTien1 = TongTien;
            this.DateNhap = DateNhap;
            this.GhiChu = GhiChu;
        }
        public HoaDonBan(DataRow rows)
        {
            MaHD = (int)rows["MaHoaDon"];
            TongTien = double.Parse(rows["TongTien"].ToString());
            DateNhap = (DateTime?)rows["NgayLapHoaDon"];
            GhiChu = rows["GhiChu"].ToString();
        }
    }
}
