using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class Tonkho
    {
        private int MaSP;
        private int SoLuongTon;

        public int MaSP1 { get => MaSP; set => MaSP = value; }
        public int SoLuongTon1 { get => SoLuongTon; set => SoLuongTon = value; }

        public Tonkho(int id, int soluong)
        {
            MaSP = id;
            SoLuongTon = soluong;
        }
        public Tonkho(DataRow row)
        {
            MaSP = (int)row["MaSP"];
            SoLuongTon = (int)row["SoLuong"];
        }
    }
}
