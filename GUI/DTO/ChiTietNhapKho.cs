using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class ChiTietPhieuNhap
    {
        private int MaCTPN;
        private int MaPN;
        private int MaSP;
        private int SL;
        private double DG;
        private double TT;


        public int MaCTPN1 { get => MaCTPN; set => MaCTPN = value; }
        public int MaPN1 { get => MaPN; set => MaPN = value; }
        public int MaSP2 { get => MaSP; set => MaSP = value; }
        public int SL1 { get => SL; set => SL = value; }
        public double DG1 { get => DG; set => DG = value; }
        public double TT1 { get => TT; set => TT = value; }

        public ChiTietPhieuNhap(int MaCTPN, int MaPN, int MaSP, int SL, double DG)
        {
            this.MaSP = MaSP;
            this.MaCTPN = MaCTPN;
            this.MaPN = MaPN;
            this.SL = SL;
            this.DG = DG;
            this.TT = SL * DG;

        }
        public ChiTietPhieuNhap(DataRow row)
        {
            this.MaSP = (int)row["MaSanPham"];
            this.MaCTPN = (int)row["MaChiTietPhieuNhap"];
            this.MaPN = (int)row["MaPhieuNhap"];
            this.SL = (int)row["SoLuong"];
            this.DG = double.Parse(row["DonGia"].ToString());
            this.TT = SL * DG;
        }
    }
}
