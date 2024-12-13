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
    public class PhieuXuatDAO
    {
        private static PhieuXuatDAO instance;
        public static PhieuXuatDAO Instance
        {
            get { if (instance == null) instance = new PhieuXuatDAO(); return instance; }
            set { instance = value; }
        }
        private PhieuXuatDAO() { }

        public DataTable GetPhieuXuat()
        {
            string query = "SELECT * From dbo.PhieuXuat";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public PhieuXuat GetPhieuXuat(int id)
        {
            string query = "SELECT * FROM dbo.PhieuXuat where PhieuXuat.id ="+id;
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);

            PhieuXuat PN = new PhieuXuat(Data.Rows[0]);
            return PN;
        }
      
        public void InsertPX(int MaNCC, DateTime? DateCreate)
        {
            string query = "EXEC InsertPX @DateCreate";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {  DateCreate });
        }
        public int GetMaxIDPX()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(id) from dbo.PhieuXuat");
            }
            catch
            {
                return 1;
            }
        }
        public void DeletePX(int idPX)
        {
            string query = "Delete dbo.PhieuXuat Where id =" + idPX;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetPhieuXuatByDate( DateTime? Start, DateTime? End)
        {
           
                string query = "EXEC GetPhieuXuatByNCC  @StartDate , @EndDate";
                return DataProvider.Instance.ExecuteQuery(query, new object[] { Start, End });
      
        }
    }
}
