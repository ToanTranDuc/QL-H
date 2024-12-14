using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace DAL
{
    public class LoadSP
    {
        //private string connectionString = @"Data Source=LAPTOP\SQLEXPRESS1;Initial Catalog=QLSP;Integrated Security=True;TrustServerCertificate=True; Encrypt=True;";
        private string connectionString =
           @"Data Source=BEETINHTINHTE\MSSQLSEVER1;Initial Catalog=QLSP;Integrated Security=True;TrustServerCertificate=True;";
        public List<XuatXu> LayTatCaXuatXu()
        {
            List<XuatXu> danhSachXuatXu = new List<XuatXu>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaXuatXu, QuocGia FROM XuatXu";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    XuatXu xuatXu = new XuatXu
                    {
                        MaXuatXu = (int)reader["MaXuatXu"],
                        QuocGia = reader["QuocGia"].ToString()
                    };
                    danhSachXuatXu.Add(xuatXu);
                }
            }
            return danhSachXuatXu;
        }

        public List<Hang> LayTatCaHang()
        {
            List<Hang> danhSachHang = new List<Hang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaHang, TenHang FROM Hang";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Hang hang = new Hang
                    {
                        MaHang = (int)reader["MaHang"],
                        TenHang = reader["TenHang"].ToString()
                    };
                    danhSachHang.Add(hang);
                }
            }
            return danhSachHang;
        }

        public List<TheLoai> LayTatCaTheLoai()
        {
            List<TheLoai> danhSachTheLoai = new List<TheLoai>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaTheLoai, TenTheLoai FROM TheLoai";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TheLoai theLoai = new TheLoai
                    {
                        MaTheLoai = (int)reader["MaTheLoai"],
                        TenTheLoai = reader["TenTheLoai"].ToString()
                    };
                    danhSachTheLoai.Add(theLoai);
                }
            }
            return danhSachTheLoai;
        }

        public List<NCC> LayTatCaNCC()
        {
            List<NCC> danhSachNCC = new List<NCC>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNCC, TenNCC FROM NCC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
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
            return danhSachNCC;
        }
        public List<NCC> LayThongTinNCC()
        {
            List<NCC> danhSachThongTinNCC = new List<NCC>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT MaNCC, TenNCC, MST, DienThoai, Email, DiaChi, NguoiTao, NgayCapNhat, NguoiCapNhat, NgayTao, TrangThai FROM NCC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NCC ncc = new NCC
                    {
                        MaNCC = (int)reader["MaNCC"],
                        TenNCC = reader["TenNCC"].ToString(),
                        MST = reader["MST"].ToString(),
                        DienThoai = reader["DienThoai"].ToString(),
                        Email = reader["Email"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        NguoiTao = reader["NguoiTao"].ToString(),
                        NgayCapNhat = (DateTime)reader["NgayCapNhat"],
                        NguoiCapNhat = reader["NguoiCapNhat"].ToString(),
                        NgayTao = (DateTime)reader["NgayTao"],
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    danhSachThongTinNCC.Add(ncc);
                }
            }
            return danhSachThongTinNCC;
        }
        public List<NCC> LayTrangThaiNCC()
        {
            List<NCC> danhSachTTNCC = new List<NCC>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT TrangThai FROM NCC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NCC trangThai = new NCC
                    {
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    danhSachTTNCC.Add(trangThai);
                }
            }
            return danhSachTTNCC;
        }
        public List<KieuDang> LayTatCaKieuDang()
        {
            List<KieuDang> danhSachKieuDang = new List<KieuDang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaKieuDang, TenKieuDang FROM KieuDang";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KieuDang kieuDang = new KieuDang
                    {
                        MaKieuDang = (int)reader["MaKieuDang"],
                        TenKieuDang = reader["TenKieuDang"].ToString()
                    };
                    danhSachKieuDang.Add(kieuDang);
                }
            }
            return danhSachKieuDang;
        }

        public List<MauSac> LayTatCaMauSac()
        {
            List<MauSac> danhSachMauSac = new List<MauSac>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaMauSac, TenMauSac FROM MauSac";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MauSac mauSac = new MauSac
                    {
                        MaMauSac = (int)reader["MaMauSac"],
                        TenMauSac = reader["TenMauSac"].ToString()
                    };
                    danhSachMauSac.Add(mauSac);
                }
            }
            return danhSachMauSac;
        }

        public List<SanPham> LayTatTrangThai()
        {
            List<SanPham> danhSachTrangThai = new List<SanPham>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT TrangThai FROM SanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham trangThai = new SanPham
                    {
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    danhSachTrangThai.Add(trangThai);
                }
            }
            return danhSachTrangThai;
        }
        public byte[] LayHinhAnh(int maSP)
        {
            byte[] hinhAnh = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT HinhAnh FROM SanPham WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    hinhAnh = (byte[])result;
                }
            }
            return hinhAnh;
        }


        public DataTable LayDanhSachSanPham()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                sp.MaSP, 
                sp.TenSP, 
                sp.MoTa,
                ncc.TenNCC, 
                hang.TenHang, 
                xx.QuocGia, 
                tl.TenTheLoai, 
                sp.HinhAnh,
                sp.TrangThai,
                sp.SoLuong
            FROM 
                SanPham sp
            JOIN 
                NCC ncc ON sp.MaNCC = ncc.MaNCC
            JOIN 
                Hang hang ON sp.MaHang = hang.MaHang
            JOIN 
                XuatXu xx ON sp.MaXuatXu = xx.MaXuatXu
            JOIN 
                TheLoai tl ON sp.MaTheLoai = tl.MaTheLoai";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }


        public DataTable TimKiemSanPham(string column, string keyword)
        {
            DataTable dt = new DataTable();

            // Ánh xạ tên cột
            var columnMapping = new Dictionary<string, string>
            {
                { "Mã sản phẩm", "MaSP" },
                { "Tên sản phẩm", "TenSP" },
                { "Mô tả", "MoTa" },
                { "NCC", "TenNCC" },
                { "Hãng", "TenHang" },
                { "Xuất Xứ", "QuocGia" },
                { "Thể loại", "TenTheLoai" },
                { "Trạng thái", "TrangThai" },
                { "Số lượng", "SoLuong" }
            };

            if (!columnMapping.TryGetValue(column, out string originalColumnName))
            {
                throw new ArgumentException("Tên cột không hợp lệ.");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $@"
            SELECT 
                sp.MaSP, 
                sp.TenSP, 
                sp.MoTa,
                ncc.TenNCC, 
                hang.TenHang, 
                xx.QuocGia, 
                tl.TenTheLoai, 
                sp.HinhAnh,
                sp.TrangThai,
                sp.SoLuong
            FROM 
                SanPham sp
            JOIN 
                NCC ncc ON sp.MaNCC = ncc.MaNCC
            JOIN 
                Hang hang ON sp.MaHang = hang.MaHang
            JOIN 
                XuatXu xx ON sp.MaXuatXu = xx.MaXuatXu
            JOIN 
                TheLoai tl ON sp.MaTheLoai = tl.MaTheLoai
            WHERE 
                {originalColumnName} LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable TimKiemNCC(string column, string keyword)
        {
            DataTable dt = new DataTable();

            // Ánh xạ tên cột
            var columnMapping = new Dictionary<string, string>
            {
                { "Mã NCC", "MaNCC" },
                { "Tên NCC", "TenNCC" },
                { "Mã số thuế", "MST" },
                { "Điện thoại", "DienThoai" },
                { "Email", "Email" },
                { "Địa chỉ", "DiaChi" },
                { "Ngày cập nhật", "NgayCapNhat" },
                { "Người tạo", "NguoiTao" },
                { "Trạng thái", "TrangThai" },
                { "Người cập nhật", "NguoiCapNhat" }
            };

            if (!columnMapping.TryGetValue(column, out string originalColumnName))
            {
                throw new ArgumentException("Tên cột không hợp lệ.");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $@"
            SELECT 
                ncc.MaNCC, 
                ncc.TenNCC, 
                ncc.MST,
                ncc.DienThoai, 
                ncc.Email, 
                ncc.DiaChi, 
                ncc.NguoiTao, 
                ncc.NgayCapNhat,
                ncc.TrangThai,
                ncc.NguoiCapNhat
            FROM 
                NCC ncc
            
            WHERE 
                {originalColumnName} LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable LayChiTietSanPham(int maSP)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            sp.MaSP, 
            sp.TenSP, 
            sp.MoTa,
            ncc.TenNCC, 
            hang.TenHang, 
            xx.QuocGia, 
            tl.TenTheLoai, 
            sp.HinhAnh,
            sp.GiaNhap,
            sp.GiaBan,
            sp.NgayNhap,
            ms.TenMauSac,
            kd.TenKieuDang,
            sp.TrangThai,
            sp.SoLuong
        FROM 
            SanPham sp
        JOIN 
            NCC ncc ON sp.MaNCC = ncc.MaNCC
        JOIN 
            Hang hang ON sp.MaHang = hang.MaHang
        JOIN 
            XuatXu xx ON sp.MaXuatXu = xx.MaXuatXu
        JOIN 
            TheLoai tl ON sp.MaTheLoai = tl.MaTheLoai
        JOIN 
            MauSac ms ON sp.MaMauSac = ms.MaMauSac
        JOIN 
            KieuDang kd ON sp.MaKieuDang = kd.MaKieuDang
        WHERE 
            sp.MaSP = @MaSP";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable LayChiTietNCC(int maNCC)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            ncc.MaNCC, 
            ncc.TenNCC, 
            ncc.MST,
            ncc.DienThoai, 
            ncc.Email, 
            ncc.DiaChi, 
            ncc.NguoiTao, 
            ncc.NgayCapNhat,
            ncc.NguoiCapNhat,
            ncc.NgayTao,
            ncc.TrangThai
        FROM 
            NCC ncc
        WHERE 
            ncc.MaNCC = @MaNCC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public int LayMaNCCTheoTen(string tenNCC)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNCC FROM NCC WHERE TenNCC = @TenNCC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenNCC", tenNCC);

                conn.Open();
                var result = cmd.ExecuteScalar();

                // Kiểm tra result có null không
                return result != null && result != DBNull.Value ? (int)result : -1;
            }
        }
        public int LayMaHangTheoTen(string tenHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaHang FROM Hang WHERE TenHang = @TenHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenHang", tenHang);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? (int)result : -1;
            }
        }


        public int LayMaTheLoaiTheoTen(string tenTheLoai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = @TenTheLoai";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? (int)result : -1;
            }
        }

        public int LayMaXuatXuTheoTen(string tenXuatXu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaXuatXu FROM XuatXu WHERE QuocGia = @QuocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@QuocGia", tenXuatXu);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? (int)result : -1;
            }
        }

        public int LayMaKieuDangTheoTen(string tenKieuDang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaKieuDang FROM KieuDang WHERE TenKieuDang = @TenKieuDang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKieuDang", tenKieuDang);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? (int)result : -1;
            }
        }

        public int LayMaMauSacTheoTen(string tenMauSac)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaMauSac FROM MauSac WHERE TenMauSac = @TenMauSac";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenMauSac", tenMauSac);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? (int)result : -1;
            }
        }

        public void UpdateSanPham(SanPham sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE SanPham
            SET TenSP = @TenSP,
                MoTa = @MoTa,
                GiaNhap = @GiaNhap,
                GiaBan = @GiaBan,
                NgayNhap = @NgayNhap,
                MaHang = @MaHang,
                MaNCC = @MaNCC,
                MaKieuDang = @MaKieuDang,
                MaTheLoai = @MaTheLoai,
                MaXuatXu = @MaXuatXu,
                HinhAnh = @HinhAnh,
                TrangThai = @TrangThai,
                SoLuong = @SoLuong
            WHERE MaSP = @MaSP";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@MoTa", sp.MoTa);
                cmd.Parameters.AddWithValue("@GiaNhap", sp.GiaNhap);
                cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                cmd.Parameters.AddWithValue("@NgayNhap", sp.NgayNhap);
                cmd.Parameters.AddWithValue("@MaHang", sp.MaHang);
                cmd.Parameters.AddWithValue("@MaNCC", sp.MaNCC);
                cmd.Parameters.AddWithValue("@MaKieuDang", sp.MaKieuDang);
                cmd.Parameters.AddWithValue("@MaTheLoai", sp.MaTheLoai);
                cmd.Parameters.AddWithValue("@MaXuatXu", sp.MaXuatXu);
                cmd.Parameters.AddWithValue("@HinhAnh", sp.HinhAnh);
                cmd.Parameters.AddWithValue("@TrangThai", sp.TrangThai);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaSanPham(int maSP)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void ThemSanPham(SanPham sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO SanPham (TenSP, MoTa, MaNCC, MaHang, MaTheLoai, MaXuatXu, TrangThai, SoLuong, HinhAnh, MaKieuDang, NgayNhap, GiaNhap, GiaBan, MaMauSac)
            VALUES (@TenSP, @MoTa, @MaNCC, @MaHang, @MaTheLoai, @MaXuatXu, @TrangThai, @SoLuong, @HinhAnh, @MaKieuDang, @NgayNhap, @GiaNhap, @GiaBan, @MaMauSac)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@MoTa", sp.MoTa);
                cmd.Parameters.AddWithValue("@MaNCC", sp.MaNCC);
                cmd.Parameters.AddWithValue("@MaHang", sp.MaHang);
                cmd.Parameters.AddWithValue("@MaTheLoai", sp.MaTheLoai);
                cmd.Parameters.AddWithValue("@MaXuatXu", sp.MaXuatXu);
                cmd.Parameters.AddWithValue("@TrangThai", sp.TrangThai);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@HinhAnh", (object)sp.HinhAnh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MaKieuDang", sp.MaKieuDang);
                cmd.Parameters.AddWithValue("@NgayNhap", sp.NgayNhap);
                cmd.Parameters.AddWithValue("@GiaNhap", sp.GiaNhap);
                cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                cmd.Parameters.AddWithValue("@MaMauSac", sp.MaMauSac);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public DataTable LayDanhSachSanPhamTheoTheLoai(int maTheLoai)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            sp.MaSP, 
            sp.TenSP, 
            sp.MoTa,
            ncc.TenNCC, 
            hang.TenHang, 
            xx.QuocGia, 
            tl.TenTheLoai, 
            sp.HinhAnh,
            sp.TrangThai,
            sp.SoLuong
        FROM 
            SanPham sp
        JOIN 
            NCC ncc ON sp.MaNCC = ncc.MaNCC
        JOIN 
            Hang hang ON sp.MaHang = hang.MaHang
        JOIN 
            XuatXu xx ON sp.MaXuatXu = xx.MaXuatXu
        JOIN 
            TheLoai tl ON sp.MaTheLoai = tl.MaTheLoai
        WHERE 
            sp.MaTheLoai = @MaTheLoai";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void ThemNCC(NCC ncc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        INSERT INTO NCC (TenNCC, MST, DienThoai, Email, DiaChi, NguoiTao, NgayTao, TrangThai, NgayCapNhat, NguoiCapNhat)
        VALUES (@TenNCC, @MST, @DienThoai, @Email, @DiaChi, @NguoiTao, @NgayTao, @TrangThai, @NgayCapNhat, @NguoiCapNhat)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
                cmd.Parameters.AddWithValue("@MST", ncc.MST);
                cmd.Parameters.AddWithValue("@DienThoai", ncc.DienThoai);
                cmd.Parameters.AddWithValue("@Email", ncc.Email);
                cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi);
                cmd.Parameters.AddWithValue("@NguoiTao", ncc.NguoiTao);
                cmd.Parameters.AddWithValue("@NgayTao", ncc.NgayTao);
                cmd.Parameters.AddWithValue("@TrangThai", ncc.TrangThai);
                cmd.Parameters.AddWithValue("@NgayCapNhat", ncc.NgayCapNhat);
                cmd.Parameters.AddWithValue("@NguoiCapNhat", ncc.NguoiCapNhat);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool XoaNCC(int maNCC)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string queryCheck = "SELECT TrangThai FROM NCC WHERE MaNCC = @MaNCC";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@MaNCC", maNCC);
                conn.Open();

                var trangThai = cmdCheck.ExecuteScalar()?.ToString();
                if (trangThai != "Ngừng hoạt động")
                {
                    return false; // Không xóa nếu trạng thái không phải 'Ngưng hoạt động'
                }

                string queryDelete = "DELETE FROM NCC WHERE MaNCC = @MaNCC";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, conn);
                cmdDelete.Parameters.AddWithValue("@MaNCC", maNCC);
                cmdDelete.ExecuteNonQuery();
                return true;
            }
        }

        public bool XoaCTNCC(int maNCC)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Kiểm tra trạng thái trước khi xóa
                string queryCheck = "SELECT TrangThai FROM NCC WHERE MaNCC = @MaNCC";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@MaNCC", maNCC);
                conn.Open();

                var trangThai = cmdCheck.ExecuteScalar()?.ToString();
                if (trangThai != "Ngừng hoạt động")
                {
                    return false; // Không xóa nếu trạng thái không phải 'Ngưng hoạt động'
                }

                // Nếu trạng thái là 'Ngưng hoạt động', thực hiện xóa
                string queryDelete = "DELETE FROM NCC WHERE MaNCC = @MaNCC";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, conn);
                cmdDelete.Parameters.AddWithValue("@MaNCC", maNCC);
                cmdDelete.ExecuteNonQuery();
                return true; // Xóa thành công
            }
        }

        public void CapNhatNCC(NCC ncc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        UPDATE NCC
        SET TenNCC = @TenNCC,
            MST = @MST,
            DienThoai = @DienThoai,
            Email = @Email,
            DiaChi = @DiaChi,
            NguoiTao = @NguoiTao,
            NguoiCapNhat = @NguoiCapNhat,
            NgayCapNhat = @NgayCapNhat,
            NgayTao = @NgayTao,
            TrangThai = @TrangThai
        WHERE MaNCC = @MaNCC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
                cmd.Parameters.AddWithValue("@MST", ncc.MST);
                cmd.Parameters.AddWithValue("@DienThoai", ncc.DienThoai);
                cmd.Parameters.AddWithValue("@Email", ncc.Email);
                cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi);
                cmd.Parameters.AddWithValue("@NguoiTao", ncc.NguoiTao);
                cmd.Parameters.AddWithValue("@NguoiCapNhat", ncc.NguoiCapNhat);
                cmd.Parameters.AddWithValue("@NgayCapNhat", ncc.NgayCapNhat);
                cmd.Parameters.AddWithValue("@NgayTao", ncc.NgayTao);
                cmd.Parameters.AddWithValue("@TrangThai", ncc.TrangThai);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable LayDanhSachHopDong()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            hd.MaHopDong,
            ncc.TenNCC AS 'Tên nhà cung cấp',
            hd.TenHopDong,
            hd.NgayKy,
            hd.NguoiKy,
            hd.MoTa,
            hd.NgayHieuLuc,
            hd.NgayHetHan,
            hd.GiaTri,
            hd.TrangThai
        FROM 
            HopDong hd
        JOIN 
            NCC ncc ON hd.MaNCC = ncc.MaNCC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable TimKiemHopDong(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT * FROM HopDong
                WHERE TenHopDong LIKE @keyword OR
                      MoTa LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public string LayTrangThaiHopDong(int maHopDong)
        {
            string trangThai = string.Empty;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TrangThai FROM HopDong WHERE MaHopDong = @MaHopDong";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        trangThai = result.ToString();
                    }
                }
            }
            return trangThai;
        }

        public void XoaHopDong(int maHopDong)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM HopDong WHERE MaHopDong = @MaHopDong";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable LayChiTietHopDong(int maHopDong)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    MaHopDong,
                    TenHopDong,
                    MoTa,
                    NgayKy,
                    NguoiKy,
                    NgayHieuLuc,
                    NgayHetHan,
                    GiaTri,
                    TrangThai,
                    (SELECT TenNCC FROM NCC WHERE MaNCC = HopDong.MaNCC) AS TenNCC
                FROM 
                    HopDong
                WHERE 
                    MaHopDong = @MaHopDong";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public void CapNhatHopDong(HopDong hopDong)
        {
            int maNCC = 1 ;//LayMaNCCTheoTen(int.Parse(hopDong.MaNCC); // Lấy mã NCC từ tên

            if (maNCC == -1)
            {
                throw new ArgumentException("Tên nhà cung cấp không hợp lệ."); // Kiểm tra nếu tên NCC không tồn tại
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE HopDong
            SET TenHopDong = @TenHopDong,
                MoTa = @MoTa,
                NgayKy = @NgayKy,
                NguoiKy = @NguoiKy,
                NgayHieuLuc = @NgayHieuLuc,
                NgayHetHan = @NgayHetHan,
                GiaTri = @GiaTri,
                TrangThai = @TrangThai,
                MaNCC = @MaNCC
            WHERE MaHopDong = @MaHopDong";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHopDong", hopDong.MaHopDong);
                cmd.Parameters.AddWithValue("@TenHopDong", hopDong.TenHopDong);
                cmd.Parameters.AddWithValue("@MoTa", hopDong.MoTa);
                cmd.Parameters.AddWithValue("@NgayKy", hopDong.NgayKy);
                cmd.Parameters.AddWithValue("@NguoiKy", hopDong.NguoiKy);
                cmd.Parameters.AddWithValue("@NgayHieuLuc", hopDong.NgayHieuLuc);
                cmd.Parameters.AddWithValue("@NgayHetHan", hopDong.NgayHetHan);
                cmd.Parameters.AddWithValue("@GiaTri", hopDong.GiaTri);
                cmd.Parameters.AddWithValue("@TrangThai", hopDong.TrangThai);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC); // Sử dụng mã NCC

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaCTHopDong(int maHopDong)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Kiểm tra trạng thái của hợp đồng trước khi xóa
                string queryCheck = "SELECT TrangThai FROM HopDong WHERE MaHopDong = @MaHopDong";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@MaHopDong", maHopDong);

                conn.Open();
                var trangThai = cmdCheck.ExecuteScalar();

                if (trangThai != null && trangThai.ToString() == "Ngừng hoạt động")
                {
                    string queryDelete = "DELETE FROM HopDong WHERE MaHopDong = @MaHopDong";
                    SqlCommand cmdDelete = new SqlCommand(queryDelete, conn);
                    cmdDelete.Parameters.AddWithValue("@MaHopDong", maHopDong);
                    cmdDelete.ExecuteNonQuery();
                }
                else
                {
                    throw new InvalidOperationException("Hợp đồng không thể xóa vì không ở trạng thái 'Ngừng hoạt động'.");
                }
            }
        }

    }
}
