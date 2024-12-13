using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonDatHangDAL
    {
        public List<DonDatHang> GetListDonDatHang()
        {
            List<DonDatHang> list = new List<DonDatHang>();
            string query = "SELECT d.ID_DonDatHang, d.NgayDat, d.MaNCC, n.TenNCC, d.GhiChu, d.TongGia, d.TrangThai " +
                           "FROM tblDonDatHang d " +
                           "JOIN NCC n ON d.MaNCC = n.MaNCC";

            using (SqlConnection conn = SqlConnectionData1.ConnectSP())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DonDatHang donDatHang = new DonDatHang
                    {
                        ID_DonDatHang = Convert.ToInt32(reader["ID_DonDatHang"]),
                        NgayDat = Convert.ToDateTime(reader["NgayDat"]),
                        MaNCC = Convert.ToInt32(reader["MaNCC"]),
                        TenNCC = reader["TenNCC"].ToString(),
                        GhiChu = reader["GhiChu"].ToString(),
                        TongGia = Convert.ToSingle(reader["TongGia"]),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    list.Add(donDatHang);
                }
            }
            return list;
        }
    }
}
