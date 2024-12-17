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
    }
}
