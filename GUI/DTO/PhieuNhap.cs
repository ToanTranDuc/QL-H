using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class PhieuNhap
    {
        private int MaNCC;
        private int MaPN;
        private DateTime? DateNhap;
        private string GhiChu;

        public int MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public int MaPN1 { get => MaPN; set => MaPN = value; }
        public DateTime? DateNhap1 { get => DateNhap; set => DateNhap = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }

        public PhieuNhap(int MaNCC , DateTime? DateNhap , string GhiChu, int MaPN)
        { 
                this.MaNCC1 = MaNCC;
                this.DateNhap1 = DateNhap;
                this.GhiChu = GhiChu;
                this.MaPN = MaPN;
            }
        public PhieuNhap(DataRow row)
        {
            this.MaNCC = (int)row["MaNCC"];
            this.MaPN = (int)row["MaPhieuNhap"];
            this.DateNhap = (DateTime?)row["NgayLapPhieuNhap"];
            this.GhiChu = row["GhiChu"].ToString();

        }
    }
}
