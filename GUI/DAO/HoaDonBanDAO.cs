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
    public class HoaDonBanDAO
    {
        private static HoaDonBanDAO instance;
        public static HoaDonBanDAO Instance
        {
            get { if (instance == null) instance = new HoaDonBanDAO(); return instance; }
            set { instance = value; }
        }
        private HoaDonBanDAO() { }

        public DataTable GetHoaDonBan()
        {
            string query = "SELECT * FROM HoaDonBan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public HoaDonBan GetHoaDonBan(int id)
        {
            string query = "SELECT * From HoaDonBan where MaHoaDon = " + id;
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);

            HoaDonBan HD = new HoaDonBan(Data.Rows[0]);
            return HD;
        }
        public void InsertHDB(double TongTien, DateTime? DateCreate, string GhiChu)
        {
            string query = "EXEC InsertHDB  @DateCreate , @GhiChu , @TongTien ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { DateCreate, GhiChu , TongTien});
        }
        public int GetMaxIDHDB()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(MaHoaDon) from dbo.HoaDonBan");
            }
            catch
            {
                return 1;
            }
        }
        public void DeleteHDB(int idHDB)
        {
            string query = "Delete dbo.HoaDonBan Where MaHoaDon =" + idHDB;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetHoaDonByDate(DateTime? Start, DateTime? End)
        {

            string query = "EXEC GetHoaDonByDate  @StartDate , @EndDate";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Start, End });

        }
      
    }
}
