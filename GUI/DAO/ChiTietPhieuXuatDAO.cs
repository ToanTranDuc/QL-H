﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GUI.DTO;

namespace GUI.DAO
{
    public class ChiTietPhieuXuatDAO
    {
        private static ChiTietPhieuXuatDAO instance;
        public static ChiTietPhieuXuatDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuXuatDAO(); return instance; }
            set { instance = value; }
        }
        private ChiTietPhieuXuatDAO() { }

        public List<ChiTietPhieuXuat> GetChiTietPhieuXuatByID(int id)
        {
            List<ChiTietPhieuXuat> CTXKList = new List<ChiTietPhieuXuat>();
            string query = "Select * From ChiTietPhieuXuat where ChiTIetPhieuXuat.MaPhieuXuat = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow CTXK in data.Rows)
            {
                ChiTietPhieuXuat CT = new ChiTietPhieuXuat(CTXK);
                CTXKList.Add(CT);
            }
            return CTXKList;

        }
        public void InsertCTXKho(int idSP, int idPN, int SoLuong, double DonGia)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertCTXK @idSanPham , @idPhieuNhap , @SoLuong , @DonGia ", new object[] { idSP, idPN, SoLuong, DonGia });
        }
        public void DeleteCTXKho(int idPX)
        {
            string query = "Delete dbo.ChiTietPhieuXuat Where MaPhieuXuat =" + idPX;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
