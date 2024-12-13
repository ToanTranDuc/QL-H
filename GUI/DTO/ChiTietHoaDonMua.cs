using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class ChiTietHoaDonMua
    {
        private int MaCT;
        private int MaHDM;
        private int MaSP;
        private int SL;
        private double DG;
        private double TT;

        public int MaCT1 { get => MaCT; set => MaCT = value; }
        public int MaHDM1 { get => MaHDM; set => MaHDM = value; }
        public int MaSP1 { get => MaSP; set => MaSP = value; }
        public int SL1 { get => SL; set => SL = value; }
        public double DG1 { get => DG; set => DG = value; }
        public double TT1 { get => TT; set => TT = value; }

        public ChiTietHoaDonMua(int MaCTHDM, int MaHDM, int MaSP, int SL, double DG)
        {
            this.MaSP1 = MaSP;
            this.MaHDM = MaHDM;
            this.MaCT = MaCTHDM;
            this.SL1 = SL;
            this.DG1 = DG;
            this.TT1 = SL * DG;

        }
        public ChiTietHoaDonMua(DataRow row)
        {
            this.MaSP1 = (int)row["MaSP"];
            this.MaCT = (int)row["ID_ChiTiet"];
            this.MaHDM = (int)row["ID_DonDatHang"];
            this.SL1 = (int)row["SoLuong"];
            this.DG1 = double.Parse(row["Gia"].ToString());
            this.TT1 = SL1 * DG1;
        }
    }
}
