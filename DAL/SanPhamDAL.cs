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
            SanPham product = null;
            string query = "SELECT MaSP, TenSP, MoTa, GiaNhap, GiaBan, NgayNhap, HinhAnh, SoLuong FROM SanPham WHERE MaSP = @MaSP";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new SanPham
                            {
                                MaSP = (int)reader["MaSP"],
                                TenSP = reader["TenSP"].ToString(),
                                GiaNhap = (float)reader["GiaNhap"],
                                // Thêm các thuộc tính khác nếu cần
                                SoLuong = (int)reader["SoLuong"] // Nếu bạn cũng muốn lấy số lượng
                            };
                        }
                    }
                }
            }
            return product;
        }
    }
}
