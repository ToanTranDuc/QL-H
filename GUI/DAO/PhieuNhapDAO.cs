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
            string query = "SELECT * FROM PhieuNhap as PN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public PhieuNhap GetPhieuNhap(int id)
        {
            string query = "SELECT * From PhieuNhap where MaPhieuNhap = " + id;
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);

            PhieuNhap PN = new PhieuNhap(Data.Rows[0]);
            return PN;
        }
        public DataTable GetPhieuNhapByNCC(int MaNCC,DateTime? Start, DateTime? End)
        {
            string query = "";
           
            query = "EXEC GetPhieuNhapByNCC @MaNCC , @StartDate , @EndDate" ;
            return DataProvider.Instance.ExecuteQuery(query, new object[] {MaNCC,Start,End});
        }
        public void InsertPN(int MaNCC, DateTime? DateCreate, string GhiChu)
        {
            string query = "EXEC InsertPN @MaNCC , @DateCreate , @GhiChu ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNCC, DateCreate,GhiChu });
        }
        public int GetMaxIDPN()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(MaPhieuNhap) from dbo.PhieuNhap");
            }
            catch
            {
                return 1;
            }
        }
        public void DeletePN(int idPN)
        {
            string query = "Delete dbo.PhieuNhap Where MaPhieuNhap =" + idPN;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
