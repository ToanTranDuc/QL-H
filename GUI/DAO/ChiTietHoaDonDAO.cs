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
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;
        public static ChiTietHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDonDAO(); return instance; }
            set { instance = value; }
        }
        private ChiTietHoaDonDAO() { }

        public List<ChiTietHoaDon> GetChiTietHoaDonByID(int id)
        {
            List<ChiTietHoaDon> CTNKList = new List<ChiTietHoaDon>();
            string query = "Select * From ChiTietHoaDon as CTPN WHERE CTPN.MaHoaDon = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow CTNK in data.Rows)
            {
                ChiTietHoaDon CT = new ChiTietHoaDon(CTNK);
                CTNKList.Add(CT);
            }
            return CTNKList;

        }
        public void InsertCTHDB(int idSP, int idPN, int SoLuong, double DonGia)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertCTHDB @idSanPham , @idHoaDon , @SoLuong , @DonGia ", new object[] { idSP, idPN, SoLuong, DonGia });
        }
        public void DeleteCTHDB(int idPN)
        {
            string query = "Delete dbo.ChiTietHoaDon Where MaHoaDon =" + idPN;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
