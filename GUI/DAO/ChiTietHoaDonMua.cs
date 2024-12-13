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
    public class ChiTietHoaDonMuaDAO
    {
        private static ChiTietHoaDonMuaDAO instance;
        public static ChiTietHoaDonMuaDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDonMuaDAO(); return instance; }
            set { instance = value; }
        }
        private ChiTietHoaDonMuaDAO() { }

        public List<ChiTietHoaDonMua> GetChiTietHoaDonMuaByID(int id)
        {
            List<ChiTietHoaDonMua> CTXKList = new List<ChiTietHoaDonMua>();
            string query = "Select * From tblChiTietDonDatHang where ID_DonDatHang = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow CTXK in data.Rows)
            {
                ChiTietHoaDonMua CT = new ChiTietHoaDonMua(CTXK);
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
            string query = "Delete dbo.tblChiTietDonHangDat Where ID_DonDatHang =" + idPX;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public ChiTietHoaDonMua GetCTHDMByHDAndSP(int ID_DonDatHang, int MaSP)
        {
            string query = "Select * From tblChiTietDonDatHang where ID_DonDatHang = " + ID_DonDatHang + " AND MasP = " + MaSP;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            ChiTietHoaDonMua CTHDM = new ChiTietHoaDonMua(data.Rows[0]);
            return CTHDM;
        }
    }
}
