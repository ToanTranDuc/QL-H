using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        public List<SanPham> GetProductsBySupplier(int maNCC)
        {
            var products = new List<SanPham>();
            string query = @"
                SELECT MaSP, TenSP, SoLuong, GiaNhap 
                FROM SanPham 
                WHERE MaNCC = @MaNCC";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MaNCC", maNCC);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new SanPham
                            {
                                MaSP = (int)reader["MaSP"],
                                TenSP = reader["TenSP"].ToString(),
                                SoLuong = (int)reader["SoLuong"],
                                GiaNhap = (float)reader.GetDecimal(reader.GetOrdinal("GiaNhap"))

                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
        public SanPham GetProductById(int maSP)
        {
            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                string query = "SELECT MaSP, TenSP, GiaNhap FROM SanPham WHERE MaSP = @MaSP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new SanPham
                            {
                                MaSP = reader.GetInt32(0),
                                TenSP = reader.GetString(1),
                                GiaNhap = Convert.ToSingle(reader["GiaNhap"])
                            };
                        }
                    }
                }
            }
            return null; // Nếu không tìm thấy, trả về null
        }
    }
}
