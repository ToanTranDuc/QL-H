using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonDatHangDAL
    {
        public List<DonDatHang> GetListDonDatHang()
        {
            List<DonDatHang> list = new List<DonDatHang>();
            string query = "SELECT d.ID_DonDatHang, d.NgayDat, d.MaNCC, n.TenNCC, d.GhiChu, d.TongGia, d.TrangThai " +
                           "FROM tblDonDatHang d " +
                           "JOIN NCC n ON d.MaNCC = n.MaNCC";

            using (SqlConnection conn = SqlConnectionData1.ConnectSP())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DonDatHang donDatHang = new DonDatHang
                    {
                        ID_DonDatHang = Convert.ToInt32(reader["ID_DonDatHang"]),
                        NgayDat = Convert.ToDateTime(reader["NgayDat"]),
                        MaNCC = Convert.ToInt32(reader["MaNCC"]),
                        TenNCC = reader["TenNCC"].ToString(),
                        GhiChu = reader["GhiChu"].ToString(),
                        TongGia = Convert.ToSingle(reader["TongGia"]),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    list.Add(donDatHang);
                }
            }
            return list;
        }
        public void SaveDonDatHang(DonDatHang donDatHang, List<ChiTietDonDatHang> chiTietDonDatHangs)
        {
            // Lưu thông tin đơn đặt hàng
            // Giả sử bạn đã có lớp DAL để thực hiện các thao tác với cơ sở dữ liệu

            using (var connection = SqlConnectionData1.Connect())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Lưu đơn đặt hàng
                        string queryInsertDonDatHang = "INSERT INTO tblDonDatHang (MaNCC, NgayDat, TongGia, TrangThai) VALUES (@MaNCC, @NgayDat, @TongGia, @TrangThai); SELECT SCOPE_IDENTITY();";
                        var cmd = new SqlCommand(queryInsertDonDatHang, connection, transaction);
                        cmd.Parameters.AddWithValue("@MaNCC", donDatHang.MaNCC);
                        cmd.Parameters.AddWithValue("@NgayDat", donDatHang.NgayDat);
                        cmd.Parameters.AddWithValue("@TongGia", donDatHang.TongGia);
                        cmd.Parameters.AddWithValue("@TrangThai", donDatHang.TrangThai);

                        // Lấy ID của đơn đặt hàng vừa tạo
                        donDatHang.ID_DonDatHang = Convert.ToInt32(cmd.ExecuteScalar());

                        // Lưu chi tiết đơn đặt hàng
                        foreach (var chiTiet in chiTietDonDatHangs)
                        {
                            string queryInsertChiTiet = "INSERT INTO tblChiTietDonDatHang (ID_DonDatHang, MaSP, SoLuong) VALUES (@ID_DonDatHang, @MaSP, @SoLuong)";
                            var cmdChiTiet = new SqlCommand(queryInsertChiTiet, connection, transaction);
                            cmdChiTiet.Parameters.AddWithValue("@ID_DonDatHang", donDatHang.ID_DonDatHang);
                            cmdChiTiet.Parameters.AddWithValue("@MaSP", chiTiet.MaSP);
                            cmdChiTiet.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                            cmdChiTiet.ExecuteNonQuery();
                        }

                        // Cam kết giao dịch
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Nếu có lỗi, hoàn tác giao dịch
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
