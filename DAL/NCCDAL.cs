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

            using (SqlConnection conn = SqlConnectionData.ConnectSP())
            {
                conn.Open();
                string query = "SELECT MaNCC, TenNCC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NCC ncc = new NCC
                            {
                                MaNCC = reader.GetInt32(0),
                                TenNCC = reader.GetString(1),
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
