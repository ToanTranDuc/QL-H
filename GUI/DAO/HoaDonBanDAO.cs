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
        public DataTable GetHoaDonBanByNCC(int MaNCC, DateTime? Start, DateTime? End)
        {
            string query = "";

            query = "EXEC GetHoaDonBanByNCC @MaNCC , @StartDate , @EndDate";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { MaNCC, Start, End });
        }
        public void InsertPN(int MaNCC, DateTime? DateCreate, string GhiChu)
        {
            string query = "EXEC InsertPN @MaNCC , @DateCreate , @GhiChu ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNCC, DateCreate, GhiChu });
        }
        public int GetMaxIDPN()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(MaHoaDonBan) from dbo.HoaDonBan");
            }
            catch
            {
                return 1;
            }
        }
        public void DeletePN(int idPN)
        {
            string query = "Delete dbo.HoaDonBan Where MaHoaDonBan =" + idPN;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
