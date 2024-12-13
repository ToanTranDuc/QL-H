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
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;
        public static PhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhapDAO(); return instance; }
            set { instance = value; }
        }
        private PhieuNhapDAO() { }

        public DataTable GetPhieuNhap()
        {
            string query = "SELECT PN.id , PN.DateCreate , NCC.TenNCC  FROM PhieuNhap as PN , NCC WHERE PN.MaNCC = NCC.MaNCC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public PhieuNhap GetPhieuNhap(int id)
        {
            string query = "SELECT PN.MaNCC , PN.DateCreate , NCC.TenNCC FROM PhieuNhap as PN , NCC Where PN.MaNCC = NCC.MaNCC AND PN.id =" + id;
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);

            PhieuNhap PN = new PhieuNhap(Data.Rows[0]);
            return PN;
        }
        public DataTable GetPhieuNhapByNCC(string NCCName,DateTime? Start, DateTime? End)
        {
            string query = "";
            if(NCCName == "")
            {
                query = "EXEC GetPhieuNhapByNCC @NCCName , @StartDate , @EndDate";
                return DataProvider.Instance.ExecuteQuery(query, new object[] { NCCName, Start, End });
            }
            query = "EXEC GetPhieuNhapByNCC @NCCName , @StartDate , @EndDate" ;
            return DataProvider.Instance.ExecuteQuery(query, new object[] {NCCName,Start,End});
        }
        public void InsertPN(int MaNCC, DateTime? DateCreate)
        {
            string query = "EXEC InsertPN @MaNCC , @DateCreate";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNCC, DateCreate});
        }
        public int GetMaxIDPN()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(id) from dbo.PhieuNhap");
            }
            catch
            {
                return 1;
            }
        }
        public void DeletePN(int idPN)
        {
            string query = "Delete dbo.PhieuNhap Where id =" + idPN;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
