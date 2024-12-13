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
        private int id;
        private int idPhieuXuat;
        private string SPName;
        private int SoLuong;
        private double DonGia;

        public int Id { get => id; set => id = value; }
        public int IdPhieuXuat { get => idPhieuXuat; set => idPhieuXuat = value; }
        public string SpName { get => SPName; set => SPName = value; }
        public int soLuong { get => SoLuong; set => SoLuong = value; }
        public double Dongia { get => DonGia; set => DonGia = value; }

        public ChiTietPhieuXuat(int id, int idPhieuXuat, string sPName, int soLuong, double DonGia)
        {
            this.id = id;
            this.idPhieuXuat = idPhieuXuat;
            this.SPName = sPName;
            this.SoLuong = soLuong;
            this.DonGia = Dongia;
        }
        public ChiTietPhieuXuat(DataRow row)
        {
            id = (int)row["ID"];
            idPhieuXuat = (int)row["idPhieuXuat"];
            SPName = row["TenSP"].ToString();
            SoLuong = (int)row["SoLuong"];
            DonGia = double.Parse(row["DonGia"].ToString());
        }
    }
}
