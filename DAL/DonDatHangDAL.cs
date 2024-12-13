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
            var donDatHangList = new List<DonDatHang>();

            using (SqlConnection conn = SqlConnectionData.ConnectSP())
            {
                
                string query = @"
                SELECT d.ID_DonDatHang, d.Ngay_Dat, n.TenNCC, n.MaNCC, d.SoLuong, d.TongGia, d.TrangThai, d.MaSP, s.TenSP, s.MoTa, s.GiaNhap, s.HinhAnh, s.MaNCC,
                FROM tblDonDatHang d
                JOIN NCC n ON d.MaNCC = n.MaNCC
                JOIN SanPham s ON d.MaSP = s.MaSP";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DonDatHang donDatHang = new DonDatHang
                            {
                                ID_DonDatHang = Convert.ToInt32(reader["ID_DonDatHang"]),
                                NgayDat = Convert.ToDateTime(reader["Ngay_Dat"]),
                                TenNCC = reader["TenNCC"].ToString(),
                                MaNCC = Convert.ToInt32(reader["MaNCC"]),
                                MaSP = Convert.ToInt32(reader["MaSP"]),
                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                TongGia = Convert.ToSingle(reader["TongGia"]),
                                TrangThai = reader["TrangThai"].ToString(),
                                SanPham = new SanPham
                                {
                                    MaSP = Convert.ToInt32(reader["MaSP"]),
                                    TenSP = reader["TenSP"].ToString(),
                                    MoTa = reader["MoTa"].ToString(),
                                    GiaNhap = Convert.ToSingle(reader["GiaNhap"]),
                                    HinhAnh = reader["HinhAnh"] != DBNull.Value ? (byte[])reader["HinhAnh"] : null,
                                    MaNCC = Convert.ToInt32(reader["MaNCC"]),
                                    
                                }
                            };
                                
                            donDatHangList.Add(donDatHang);
                        }
                    }
                }
            }

            return donDatHangList;
        }
    }
}
