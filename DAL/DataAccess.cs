using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()

        {
            string sql = @"Data Source=beetinhtinhte\mssqlsever1;Initial Catalog=QLCuaHangDH;Integrated Security=True;";
            //string sql = @"Data Source=LAPTOP\SQLEXPRESS1;Initial Catalog=QLSP;Integrated Security=True;TrustServerCertificate=True; Encrypt=True;";
            SqlConnection conn = new SqlConnection(sql);
            return conn;
        }
    }

    public class DataBaseAccess

    {
        public static string CheckLogic(SanPham sanpham)
        {
            string sp = null;
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open(); // Thực hiện logic kiểm tra sản phẩm
                string query = "SELECT COUNT(*) FROM SanPham WHERE MaSP = @MaSP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", sanpham.MaSP);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        sp = "Sản phẩm đã tồn tại.";
                    }
                    else
                    {
                        sp = "Sản phẩm không tồn tại.";
                    }
                }
            }
            return sp;
        }

    }
}
