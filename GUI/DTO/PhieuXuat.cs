using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class PhieuXuat
    {
        private int MaPX;
        private DateTime? DateXuat;
        private string LyDo;

        public int MaPX1 { get => MaPX; set => MaPX = value; }
        public DateTime? DateXuat1 { get => DateXuat; set => DateXuat = value; }
        public string LyDo1 { get => LyDo; set => LyDo = value; }

        public PhieuXuat(int id, DateTime? DateXuat, string LyDo)
        {
            this.MaPX = id;
            this.DateXuat1 = DateXuat;
            this.LyDo = LyDo; 
        }
        public PhieuXuat(DataRow row)
        {
            this.MaPX = (int)row["MaPhieuXuat"];
            this.DateXuat1 = (DateTime?)row["NgayLapPhieuXuat"];
            this.LyDo = row["LyDoXuat"].ToString();
        }
    }
}
