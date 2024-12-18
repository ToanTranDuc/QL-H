using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class NCCDAL
    {
        public List<NCC> GetListNCC()
        {
            List<NCC> danhSachNCC = new List<NCC>();

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                string query = "SELECT MaNCC, TenNCC FROM NCC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NCC ncc = new NCC
                            {
                                MaNCC = (int)reader["MaNCC"],
                                TenNCC = reader["TenNCC"].ToString()
                            };
                            danhSachNCC.Add(ncc);
                        }
                    }
                }
            }

            return danhSachNCC;
        }
        public List<SanPham> GetProductsBySupplier(int maNCC)
        {
            List<SanPham> products = new List<SanPham>();

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                string query = "SELECT MaSP, TenSP, GiaNhap FROM SanPham WHERE MaNCC = @MaNCC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SanPham product = new SanPham
                            {
                                MaSP = (int)reader["MaSP"],
                                TenSP = reader["TenSP"].ToString(),
                                GiaNhap = Convert.ToSingle(reader["GiaNhap"]) // Hoặc decimal, tùy thuộc vào kiểu dữ liệu
                            };
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }
    }
}
