using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietDonDatHangDAL
    {
        public List<ChiTietDonDatHang> GetChiTietDonDatHang(int idDonDatHang)
        {
            List<ChiTietDonDatHang> list = new List<ChiTietDonDatHang>();
            string query = "SELECT ct.ID_ChiTiet, ct.ID_DonDatHang, ct.MaSP, sp.TenSP, ct.SoLuong, ct.Gia " +
                           "FROM tblChiTietDonDatHang ct " +
                           "JOIN SanPham sp ON ct.MaSP = sp.MaSP " +
                           "WHERE ct.ID_DonDatHang = @ID_DonDatHang";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_DonDatHang", idDonDatHang);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietDonDatHang chiTiet = new ChiTietDonDatHang
                    {
                        ID_ChiTiet = Convert.ToInt32(reader["ID_ChiTiet"]),
                        ID_DonDatHang = Convert.ToInt32(reader["ID_DonDatHang"]),
                        MaSP = Convert.ToInt32(reader["MaSP"]),
                        TenSP = reader["TenSP"].ToString(),
                        SoLuong = Convert.ToInt32(reader["SoLuong"]),
                        GiaNhap = Convert.ToSingle(reader["Gia"])
                    };
                    list.Add(chiTiet);
                }
            }
            return list;
        }
    }
}