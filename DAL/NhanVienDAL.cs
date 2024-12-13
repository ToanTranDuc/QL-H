using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DAL
{
    public class NhanVienDAL
    {
        public List<NhanVien> GetAllEmployees()
        {
            var employees = new List<NhanVien>();

            string query = @"
                SELECT nv.ID_NhanVien, nv.ID_DangNhap, nv.Ho_Ten, nv.Ngay_Sinh, nv.Gioi_Tinh,
                       nv.Dia_Chi, nv.Que_Quan, nv.CCCD, nv.Ngay_Cap, nv.Noi_Cap, nv.So_Dien_Thoai,
                       nv.Email, nv.ID_ChucVu, nv.Ngay_Tao, nv.Nguoi_Tao, nv.Ngay_Sua, 
                       nv.Nguoi_Sua, nv.Duong_Dan_Anh, nv.Trang_Thai,
                       tk.TenDangNhap, tk.MatKhau, cv.Ten_ChucVu
                FROM tblNhanVien nv
                JOIN tblTaiKhoan tk ON nv.ID_DangNhap = tk.ID_DangNhap
                JOIN tblChucVu cv ON nv.ID_ChucVu = cv.ID_ChucVu";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new NhanVien
                            {
                                ID_NhanVien = (int)reader["ID_NhanVien"],
                                ID_DangNhap = (int)reader["ID_DangNhap"],
                                Ho_Ten = reader["Ho_Ten"].ToString(),
                                Ngay_Sinh = (DateTime)reader["Ngay_Sinh"],
                                Gioi_Tinh = reader["Gioi_Tinh"].ToString(),
                                Dia_Chi = reader["Dia_Chi"].ToString(),
                                Que_Quan = reader["Que_Quan"].ToString(),
                                CCCD = reader["CCCD"].ToString(),
                                Ngay_Cap = (DateTime)reader["Ngay_Cap"],
                                Noi_Cap = reader["Noi_Cap"].ToString(),
                                So_Dien_Thoai = reader["So_Dien_Thoai"].ToString(),
                                Email = reader["Email"].ToString(),
                                ID_ChucVu = (int)reader["ID_ChucVu"],
                                Ngay_Tao = (DateTime)reader["Ngay_Tao"],
                                Nguoi_Tao = reader["Nguoi_Tao"].ToString(),
                                Ngay_Cap_Nhat = (DateTime)reader["Ngay_Sua"],
                                Nguoi_Cap_Nhat = reader["Nguoi_Sua"].ToString(),
                                Duong_Dan_Anh = reader["Duong_Dan_Anh"] != DBNull.Value ? (byte[])reader["Duong_Dan_Anh"] : null,
                                Trang_Thai = reader["Trang_Thai"].ToString(),
                                TaiKhoan = new TaiKhoan
                                {
                                    TenDangNhap = reader["TenDangNhap"].ToString(),
                                    MatKhau = reader["MatKhau"].ToString()
                                },
                                ChucVu = new ChucVu
                                {
                                    ID_ChucVu = (int)reader["ID_ChucVu"],
                                    Ten_ChucVu = reader["Ten_ChucVu"].ToString()
                                },
                                NhanVienQuyen = GetUserPermissions((int)reader["ID_NhanVien"])
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        private List<NhanVien_Quyen> GetUserPermissions(int idNhanVien)
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

        public bool UpdateEmployee(NhanVien nhanVien)
        {
            using (var connection = SqlConnectionData1.Connect())
            {
                connection.Open();

                // Cập nhật thông tin nhân viên
                string updateEmployeeQuery = @"
            UPDATE tblNhanVien 
            SET Ho_Ten = @HoTen, 
                CCCD = @CCCD, 
                Ngay_Sinh = @NgaySinh, 
                Dia_Chi = @DiaChi, 
                So_Dien_Thoai = @So_DienThoai, 
                Email = @Email, 
                Que_Quan = @QueQuan, 
                Nguoi_Sua = @NguoiCapNhat,
                Ngay_Sua = @NgayCapNhat,
                Ngay_Cap = @NgayCap, 
                Noi_Cap = @NoiCap, 
                Trang_Thai = @TrangThai,
                Gioi_Tinh = @GioiTinh,
                ID_ChucVu = @ID_ChucVu,
                Duong_Dan_Anh = @DuongDanAnh
            WHERE ID_NhanVien = @ID";

                var command = new SqlCommand(updateEmployeeQuery, connection);
                command.Parameters.AddWithValue("@HoTen", nhanVien.Ho_Ten);
                command.Parameters.AddWithValue("@CCCD", nhanVien.CCCD);
                command.Parameters.AddWithValue("@NgaySinh", nhanVien.Ngay_Sinh);
                command.Parameters.AddWithValue("@DiaChi", nhanVien.Dia_Chi);
                command.Parameters.AddWithValue("@So_DienThoai", nhanVien.So_Dien_Thoai);
                command.Parameters.AddWithValue("@Email", nhanVien.Email);
                command.Parameters.AddWithValue("@QueQuan", nhanVien.Que_Quan);
                command.Parameters.AddWithValue("@NguoiCapNhat", nhanVien.Nguoi_Cap_Nhat);
                command.Parameters.AddWithValue("@NgayCapNhat", nhanVien.Ngay_Cap_Nhat);
                command.Parameters.AddWithValue("@NgayCap", nhanVien.Ngay_Cap);
                command.Parameters.AddWithValue("@NoiCap", nhanVien.Noi_Cap);
                command.Parameters.AddWithValue("@TrangThai", nhanVien.Trang_Thai);
                command.Parameters.AddWithValue("@GioiTinh", nhanVien.Gioi_Tinh); 
                command.Parameters.AddWithValue("@ID_ChucVu", nhanVien.ID_ChucVu);
                command.Parameters.AddWithValue("@DuongDanAnh", nhanVien.Duong_Dan_Anh ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ID", nhanVien.ID_NhanVien);
                int rowsAffected = command.ExecuteNonQuery();

                // Cập nhật quyền
                UpdatePermissions(nhanVien.ID_NhanVien, nhanVien.NhanVienQuyen);
                return rowsAffected > 0;
            }
        }
        public bool UpdatePermissions(int nhanVienId, List<NhanVien_Quyen> nhanVienQuyen)
        {
            try
            {
                using (var connection = SqlConnectionData1.Connect())
                {
                    connection.Open();
                    // Xóa quyền cũ
                    string deletePermissionsQuery = "DELETE FROM tblNhanVien_Quyen WHERE ID_NhanVien = @ID";

                    var deleteCommand = new SqlCommand(deletePermissionsQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@ID", nhanVienId);
                    deleteCommand.ExecuteNonQuery();

                    // Thêm quyền mới
                    string insertPermissionQuery = "INSERT INTO tblNhanVien_Quyen (ID_NhanVien, ID_Quyen) VALUES (@ID_NhanVien, @ID_Quyen)";

                    foreach (var quyen in nhanVienQuyen)
                    {
                        var insertCommand = new SqlCommand(insertPermissionQuery, connection);
                        insertCommand.Parameters.AddWithValue("@ID_NhanVien", nhanVienId);
                        insertCommand.Parameters.AddWithValue("@ID_Quyen", quyen.ID_Quyen);
                        insertCommand.ExecuteNonQuery();
                    }
                }
                return true; // Thành công
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                Console.WriteLine("Lỗi khi cập nhật quyền: " + ex.Message);
                return false; // Thất bại
            }
        }

        public int InsertEmployee(NhanVien nhanVien)
        {
            try
            {
                using (var connection = SqlConnectionData1.Connect())
                {
                    connection.Open();
                    string insertEmployeeQuery = @"
            INSERT INTO tblNhanVien (ID_DangNhap, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Dia_Chi, Que_Quan, 
                                     CCCD, Ngay_Cap, Noi_Cap, So_Dien_Thoai, Email, 
                                     ID_ChucVu, Ngay_Tao, Nguoi_Tao, Ngay_Sua, Nguoi_Sua, Duong_Dan_Anh, Trang_Thai)
            OUTPUT INSERTED.ID_DangNhap
            VALUES (@IDDangNhap, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @QueQuan, 
                    @CCCD, @NgayCap, @NoiCap, @So_DienThoai, @Email, 
                    @IDChucVu, @NgayTao, @NguoiTao, @NgayCapNhat, @NguoiCapNhat, @DuongDanAnh, @TrangThai)";

                    using (var command = new SqlCommand(insertEmployeeQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IDDangNhap", nhanVien.ID_DangNhap);
                        command.Parameters.AddWithValue("@HoTen", nhanVien.Ho_Ten);
                        command.Parameters.AddWithValue("@NgaySinh", nhanVien.Ngay_Sinh);
                        command.Parameters.AddWithValue("@GioiTinh", nhanVien.Gioi_Tinh);
                        command.Parameters.AddWithValue("@DiaChi", nhanVien.Dia_Chi);
                        command.Parameters.AddWithValue("@QueQuan", nhanVien.Que_Quan);
                        command.Parameters.AddWithValue("@CCCD", nhanVien.CCCD);
                        command.Parameters.AddWithValue("@NgayCap", nhanVien.Ngay_Cap);
                        command.Parameters.AddWithValue("@NoiCap", nhanVien.Noi_Cap);
                        command.Parameters.AddWithValue("@So_DienThoai", nhanVien.So_Dien_Thoai);
                        command.Parameters.AddWithValue("@Email", nhanVien.Email);
                        command.Parameters.AddWithValue("@IDChucVu", nhanVien.ID_ChucVu);
                        command.Parameters.AddWithValue("@NgayTao", nhanVien.Ngay_Tao);
                        command.Parameters.AddWithValue("@NguoiTao", nhanVien.Nguoi_Tao);
                        command.Parameters.AddWithValue("@NgayCapNhat", nhanVien.Ngay_Cap_Nhat);
                        command.Parameters.AddWithValue("@NguoiCapNhat", nhanVien.Nguoi_Cap_Nhat);
                        command.Parameters.AddWithValue("@DuongDanAnh", nhanVien.Duong_Dan_Anh ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@TrangThai", nhanVien.Trang_Thai);

                        // Lấy ID nhân viên vừa tạo
                        var result = command.ExecuteScalar();
                        return (int)Convert.ToInt32(result); // Trả về ID
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm nhân viên: " + ex.Message);
                return -1; // Trả về null nếu có lỗi
            }
        }
        public NhanVien GetNhanVien(int ID)
        {
            NhanVien nv = new NhanVien();

            string query = @"
                SELECT nv.ID_NhanVien, nv.ID_DangNhap, nv.Ho_Ten, nv.Ngay_Sinh, nv.Gioi_Tinh,
                       nv.Dia_Chi, nv.Que_Quan, nv.CCCD, nv.Ngay_Cap, nv.Noi_Cap, nv.So_Dien_Thoai,
                       nv.Email, nv.ID_ChucVu, nv.Ngay_Tao, nv.Nguoi_Tao, nv.Ngay_Sua, 
                       nv.Nguoi_Sua, nv.Duong_Dan_Anh, nv.Trang_Thai,
                       tk.TenDangNhap, tk.MatKhau, cv.Ten_ChucVu
                FROM tblNhanVien nv
                JOIN tblTaiKhoan tk ON nv.ID_DangNhap = tk.ID_DangNhap
                JOIN tblChucVu cv ON nv.ID_ChucVu = cv.ID_ChucVu
                WHERE nv.ID_NhanVien = @ID_NhanVien";

            using (SqlConnection conn = SqlConnectionData1.Connect())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID_NhanVien", ID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nv.ID_NhanVien = (int)reader["ID_NhanVien"];
                            nv.ID_DangNhap = (int)reader["ID_DangNhap"];
                            nv.Ho_Ten = reader["Ho_Ten"].ToString();
                            nv.Ngay_Sinh = (DateTime)reader["Ngay_Sinh"];
                            nv.Gioi_Tinh = reader["Gioi_Tinh"].ToString();
                            nv.Dia_Chi = reader["Dia_Chi"].ToString();
                            nv.Que_Quan = reader["Que_Quan"].ToString();
                            nv.CCCD = reader["CCCD"].ToString();
                            nv.Ngay_Cap = (DateTime)reader["Ngay_Cap"];
                            nv.Noi_Cap = reader["Noi_Cap"].ToString();
                            nv.So_Dien_Thoai = reader["So_Dien_Thoai"].ToString();
                            nv.Email = reader["Email"].ToString();
                            nv.ID_ChucVu = (int)reader["ID_ChucVu"];
                            nv.Ngay_Tao = (DateTime)reader["Ngay_Tao"];
                            nv.Nguoi_Tao = reader["Nguoi_Tao"].ToString();
                            nv.Ngay_Cap_Nhat = (DateTime)reader["Ngay_Sua"];
                            nv.Nguoi_Cap_Nhat = reader["Nguoi_Sua"].ToString();
                            nv.Duong_Dan_Anh = reader["Duong_Dan_Anh"] != DBNull.Value ? (byte[])reader["Duong_Dan_Anh"] : null;
                            nv.Trang_Thai = reader["Trang_Thai"].ToString();
                            nv.TaiKhoan = new TaiKhoan
                            {
                                TenDangNhap = reader["TenDangNhap"].ToString(),
                                MatKhau = reader["MatKhau"].ToString()
                            };
                            nv.ChucVu = new ChucVu
                            {
                                ID_ChucVu = (int)reader["ID_ChucVu"],
                                Ten_ChucVu = reader["Ten_ChucVu"].ToString()
                            };
                            nv.NhanVienQuyen = GetUserPermissions((int)reader["ID_NhanVien"]);
                        }
                    }
                }
            }

            return nv;
        }
    }
}