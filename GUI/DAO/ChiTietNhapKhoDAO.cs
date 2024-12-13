using System;
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
    public class ChiTietPhieuNhapDAO
    {
        private static ChiTietPhieuNhapDAO instance;
        public static ChiTietPhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuNhapDAO(); return instance; }
            set { instance = value; }
        }
        private ChiTietPhieuNhapDAO() { }

        public List<ChiTietPhieuNhap> GetChiTietPhieuNhapByID(int id)
        {
            List<ChiTietPhieuNhap> CTNKList = new List<ChiTietPhieuNhap> ();
            string query = "Select * From ChiTietPhieuNhap as CTPN WHERE CTPN.MaPhieuNhap = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow CTNK in data.Rows)
            {
                ChiTietPhieuNhap CT = new ChiTietPhieuNhap(CTNK);
                CTNKList.Add(CT);
            } 
            return CTNKList;
            
        }
        public void InsertCTNKho(int idSP, int idPN , int SoLuong , double DonGia)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertCTNK @idSanPham , @idPhieuNhap , @SoLuong , @DonGia ", new object[] { idSP, idPN, SoLuong, DonGia });
        }
        public void DeleteCTNKho(int idPN)
        {
            string query = "Delete dbo.ChiTietPhieuNhap Where idPhieuNhap =" + idPN;
            DataProvider.Instance.ExecuteNonQuery (query);
        }
    }
}
