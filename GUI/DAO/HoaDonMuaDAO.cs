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
    public class HoaDonMuaDAO
    {
        private static HoaDonMuaDAO instance;
        public static HoaDonMuaDAO Instance
        {
            get { if (instance == null) instance = new HoaDonMuaDAO(); return instance; }
            set { instance = value; }
        }
        private HoaDonMuaDAO() { }

        public DataTable GetHoaDonMua()
        {
            string query = "SELECT * From dbo.tblDonDatHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public HoaDonMua GetHoaDonMua(int id)
        {
            string query = "SELECT * FROM dbo.tblDonDatHang where ID_DonDatHang =" + id;
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);

            HoaDonMua PN = new HoaDonMua(Data.Rows[0]);
            return PN;
        }
        public DataTable GetHoaDonMuaByNCC(int MaNCC, DateTime? Start, DateTime? End)
        {
            string query = "EXEC GetDonDatHangByNCC @MaNCC , @StartDate , @EndDate ";
           
            DataTable Data = DataProvider.Instance.ExecuteQuery(query,new object[] {MaNCC, Start,End});
            return Data;
        }
        public void UpdateHoaDonMuaTrangThai(string TrangThai, int ID_DonDatHang)
        {
            string query = "UPDATE  dbo.tblDonDatHang Set TrangThai = " + TrangThai +  " WHERE ID_DonDatHang = " + ID_DonDatHang;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

      
    }
}
