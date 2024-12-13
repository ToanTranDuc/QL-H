using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class ChiTietNhapKho
    {
        private int id;
        private int idPhieuNhap;
        private string SPName;
        private int SoLuong;
        private double DonGia;

        public int Id { get => id; set => id = value; }
        public int IdPhieuNhap { get => idPhieuNhap; set => idPhieuNhap = value; }
        public string SpName { get => SPName; set => SPName = value; }
        public int soLuong { get => SoLuong; set => SoLuong = value; }
        public double Dongia { get => DonGia; set => DonGia = value; }

        public ChiTietNhapKho(int id, int idPhieuNhap, string sPName, int soLuong,double DonGia)
        {
            this.id = id;
            this.idPhieuNhap = idPhieuNhap;
            this.SPName = sPName;
            this.SoLuong = soLuong;
            this.DonGia = Dongia;
        }
        public ChiTietNhapKho(DataRow row)
        {
            id = (int)row["ID"];
            idPhieuNhap = (int)row["idPhieuNhap"];
            SPName = row["TenSP"].ToString();
            SoLuong = (int)row["SoLuong"];
            DonGia = double.Parse(row["DonGia"].ToString());
        }
    }
}
