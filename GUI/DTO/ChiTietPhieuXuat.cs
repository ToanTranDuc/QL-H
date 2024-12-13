using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class ChiTietPhieuXuat
    {
        private int MaCTPX;
        private int MaPX;
        private int MaSP;
        private int SL;
        private double DG;
        private double TT;

     
        public int MaCTPX1 { get => MaCTPX; set => MaCTPX = value; }
        public int MaPX1 { get => MaPX; set => MaPX = value; }
        public int MaSP2 { get => MaSP; set => MaSP = value; }
        public int SL1 { get => SL; set => SL = value; }
        public double DG1 { get => DG; set => DG = value; }
        public double TT1 { get => TT; set => TT = value; }

        public ChiTietPhieuXuat(int MaCTPX, int MaPX, int MaSP, int SL, double DG)
        {
            this.MaSP = MaSP;
            this.MaCTPX = MaCTPX;
            this.MaPX = MaPX;
            this.SL = SL;
            this.DG = DG;
            this.TT = SL * DG;

        }
        public ChiTietPhieuXuat(DataRow row)
        {
            this.MaSP = (int)row["MaSanPham"];
            this.MaCTPX = (int)row["MaChiTietPhieuXuat"];
            this.MaPX = (int)row["MaPhieuXuat"];
            this.SL = (int)row["SoLuong"];
            this.DG = double.Parse(row["DonGia"].ToString());
            this.TT = SL * DG;
        }
    }
}
