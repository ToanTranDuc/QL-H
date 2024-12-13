using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Quản_lý_đồng_hồ.DTO;

namespace Quản_lý_đồng_hồ.DAO
{
    public class ChiTietNhapKhoDAO
    {
        private static ChiTietNhapKhoDAO instance;
        public static ChiTietNhapKhoDAO Instance
        {
            get { if (instance == null) instance = new ChiTietNhapKhoDAO(); return instance; }
            set { instance = value; }
        }
        private ChiTietNhapKhoDAO() { }

        public List<ChiTietNhapKho> GetChiTietNhapKhoByID(int id)
        {
            List<ChiTietNhapKho> CTNKList = new List<ChiTietNhapKho> ();
            string query = "Select SP.MaSP as ID, CTPN.idPhieuNhap as [idPhieuNhap], SP.TenSP as [TenSP] , CTPN.count as [SoLuong] , SP.GiaNhap as [DonGia] FROM ChiTietPhieuNhap as CTPN , SanPham as SP WHERE CTPN.idSanPham = SP.MaSP AND CTPN.idPhieuNhap = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow CTNK in data.Rows)
            {
                ChiTietNhapKho CT = new ChiTietNhapKho(CTNK);
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
