using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAL
    {
        public List<ChucVu> GetAllChucVu()
        {
            var chucVus = new List<ChucVu>();

            string query = @"
                SELECT ID_ChucVu, Ma_ChucVu, Ten_ChucVu, Ghi_Chu
                FROM tblChucVu";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var chucVu = new ChucVu
                            {
                                ID_ChucVu = (int)reader["ID_ChucVu"],
                                Ma_ChucVu = reader["Ma_ChucVu"].ToString(),
                                Ten_ChucVu = reader["Ten_ChucVu"].ToString(),
                                Ghi_Chu = reader["Ghi_Chu"].ToString(),
                                NhanVien = new List<NhanVien>() // Khởi tạo danh sách nhân viên
                            };
                            chucVus.Add(chucVu);
                        }
                    }
                }
            }
            return chucVus;
        }
        public bool UpdateChucVu(ChucVu chucVu)
        {
            string query = @"
        UPDATE tblChucVu
        SET Ma_ChucVu = @Ma_ChucVu, 
            Ten_ChucVu = @Ten_ChucVu, 
            Ghi_Chu = @Ghi_Chu
        WHERE ID_ChucVu = @ID_ChucVu";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID_ChucVu", chucVu.ID_ChucVu);
                    command.Parameters.AddWithValue("@Ma_ChucVu", chucVu.Ma_ChucVu);
                    command.Parameters.AddWithValue("@Ten_ChucVu", chucVu.Ten_ChucVu);
                    command.Parameters.AddWithValue("@Ghi_Chu", chucVu.Ghi_Chu);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu cập nhật thành công
                }
            }
        }

        public bool InsertChucVu(ChucVu chucVu)
        {
            string query = @"INSERT INTO tblChucVu (Ma_ChucVu, Ten_ChucVu, Ghi_Chu) 
                             VALUES (@Ma_ChucVu, @Ten_ChucVu, @Ghi_Chu)";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ma_ChucVu", chucVu.Ma_ChucVu);
                    cmd.Parameters.AddWithValue("@Ten_ChucVu", chucVu.Ten_ChucVu);
                    cmd.Parameters.AddWithValue("@Ghi_Chu", chucVu.Ghi_Chu);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public bool DeleteChucVu(int idChucVu)
        {
            string query = @"
        DELETE FROM tblChucVu
        WHERE ID_ChucVu = @ID_ChucVu";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID_ChucVu", idChucVu);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }
    }
}
