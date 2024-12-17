using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace DAL
{
    public class SqlConnectionData1
    {
        public static SqlConnection Connect()
        {

            string strcon = @"Data Source=BEETINHTINHTE\MSSQLSEVER1;Initial Catalog=QLDongHo;Integrated Security=True;";
            //string strcon = "Data Source=.\\sqlexpress;Initial Catalog=QLDH;Integrated Security=True;";
            //string strcon = "Data Source=TK\\SQLEXPRESS;Initial Catalog=QuanLyBanDongHo;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class TaiKhoanDAL
    {
        public TaiKhoan CheckLogin(string username, string password)
        {
            TaiKhoan user = null;

            try
            {
                using (SqlConnection conn = SqlConnectionData1.Connect())
                {
                    conn.Open(); // Đảm bảo mở kết nối trước khi thực hiện lệnh SQL

                    string query = @"
                SELECT tk.ID_DangNhap, tk.TenDangNhap, tk.MatKhau, ID_NhanVien, nv.Ho_Ten, nv.Trang_Thai, cv.Ten_ChucVu
                FROM tblTaiKhoan tk
                JOIN tblNhanVien nv ON tk.ID_DangNhap = nv.ID_DangNhap
                JOIN tblChucVu cv ON nv.ID_ChucVu = cv.ID_ChucVu
                WHERE tk.TenDangNhap = @username AND tk.MatKhau = @password";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                        command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string trangThai = reader["Trang_Thai"].ToString();
                                if (trangThai == "Đã nghỉ việc")
                                {
                                    throw new Exception("Tài khoản đã nghỉ việc, không thể đăng nhập.");
                                }

                                user = new TaiKhoan
                                {
                                    ID_DangNhap = (int)reader["ID_DangNhap"],
                                    TenDangNhap = reader["TenDangNhap"].ToString(),
                                    MatKhau = reader["MatKhau"].ToString(),
                                    NhanVien = new NhanVien
                                    {
                                        Ho_Ten = reader["Ho_Ten"].ToString(),
                                        ID_NhanVien = (int)reader["ID_NhanVien"],
                                        /*NhanVienQuyen = new List<NhanVien_Quyen>
                                        {
                                            ID_NhanVien = reader[""]
                                        }*/
                                        ChucVu = new ChucVu
                                        {
                                            Ten_ChucVu = reader["Ten_ChucVu"].ToString()
                                        }
                                    }
                                };
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra đăng nhập: " + ex.Message);
            }

            return user;
        }

        public List<NhanVien_Quyen> GetUserPermissions(int idNhanVien)
        {
            var permissions = new List<NhanVien_Quyen>();
            string query = @"
                SELECT nq.ID_NhanVien, nq.ID_Quyen, q.TenQuyen
                FROM tblNhanVien_Quyen nq
                JOIN tblQuyen q ON nq.ID_Quyen = q.ID_Quyen
                WHERE nq.ID_NhanVien = @idNhanVien";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@idNhanVien", idNhanVien);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var permission = new NhanVien_Quyen
                            {
                                ID_NhanVien = (int)reader["ID_NhanVien"],
                                ID_Quyen = (int)reader["ID_Quyen"],
                                Quyen = new Quyen
                                {
                                    ID_Quyen = (int)reader["ID_Quyen"],
                                    TenQuyen = reader["TenQuyen"].ToString()
                                }
                            };
                            permissions.Add(permission);
                        }
                    }
                }
            }

            return permissions;
        }

        public int InsertAccount(TaiKhoan taiKhoan)
        {
            using (var connection = SqlConnectionData1.Connect())
            {
                connection.Open();
                string insertAccountQuery = @"
                    INSERT INTO tblTaiKhoan (TenDangNhap, MatKhau) 
                    VALUES (@TenDangNhap, @MatKhau);
                    SELECT CAST(SCOPE_IDENTITY() as int);";

                var command = new SqlCommand(insertAccountQuery, connection);
                command.Parameters.AddWithValue("@TenDangNhap", taiKhoan.TenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                int newAccountId = (int)command.ExecuteScalar();
                return newAccountId;
            }
        }
        public bool CheckAccountExists(string username)
        {
            try
            {
                using (var connection = SqlConnectionData1.Connect())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM tblTaiKhoan WHERE TenDangNhap = @TenDangNhap";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenDangNhap", username);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra tài khoản: " + ex.Message);
                return false;
            }
        }
    
        public List<TaiKhoan> GetAllAccounts()
        {
            List<TaiKhoan> accountList = new List<TaiKhoan>();
            try
            {
                using (var connection = SqlConnectionData1.Connect())
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        tk.ID_DangNhap, 
                        tk.TenDangNhap, 
                        tk.MatKhau, 
                        nv.ID_NhanVien, 
                        nv.Ho_Ten, 
                        nv.Trang_Thai
                    FROM 
                        tblTaiKhoan tk
                    JOIN 
                        tblNhanVien nv ON tk.ID_DangNhap = nv.ID_DangNhap";

                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TaiKhoan account = new TaiKhoan
                                {
                                    ID_DangNhap = (int)reader["ID_DangNhap"],
                                    TenDangNhap = reader["TenDangNhap"].ToString(),
                                    MatKhau = reader["MatKhau"].ToString(),
                                    NhanVien = new NhanVien
                                    {
                                        ID_NhanVien = (int)reader["ID_NhanVien"],
                                        Ho_Ten = reader["Ho_Ten"].ToString(),
                                        Trang_Thai = reader["Trang_Thai"].ToString()
                                    }
                                };
                                accountList.Add(account);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tất cả tài khoản: " + ex.Message);
            }
            return accountList;
        }
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                using (SqlConnection conn = SqlConnectionData1.Connect())
                {
                    conn.Open();
                    string query = @"
                    UPDATE tblTaiKhoan
                    SET 
                        TenDangNhap = @TenDangNhap,
                        MatKhau = @MatKhau
                    WHERE ID_DangNhap = @ID_DangNhap;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_DangNhap", taiKhoan.ID_DangNhap);
                        cmd.Parameters.AddWithValue("@TenDangNhap", taiKhoan.TenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }

}
