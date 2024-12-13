using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class ChiTietHoaDon
    {
        private int MaCTHD;
        private int MaHD;
        private int MaSP;
        private int SL;
        private double DG;
        private double TT;

        public int MaCTHD1 { get => MaCTHD; set => MaCTHD = value; }
        public int MaHD1 { get => MaHD; set => MaHD = value; }
        public int MaSP1 { get => MaSP; set => MaSP = value; }
        public int SL1 { get => SL; set => SL = value; }
        public double DG1 { get => DG; set => DG = value; }
        public double TT1 { get => TT; set => TT = value; }

        public ChiTietHoaDon(int MaCTPN, int MaPN, int MaSP, int SL, double DG)
        {
            this.MaSP1 = MaSP;
            this.MaCTHD = MaCTPN;
            this.MaHD = MaPN;
            this.SL1 = SL;
            this.DG1 = DG;
            this.TT1 = SL * DG;

        }
        public ChiTietHoaDon(DataRow row)
        {
            this.MaSP1 = (int)row["MaSanPham"];
            this.MaCTHD = (int)row["MaChiTietHoaDon"];
            this.MaHD = (int)row["MaHoaDon"];
            this.SL1 = (int)row["SoLuong"];
            this.DG1 = double.Parse(row["DonGia"].ToString());
            this.TT1 = SL1 * DG1;
        }
    }
}
