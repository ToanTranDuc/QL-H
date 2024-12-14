using DAL;
using DTO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        private LoadSP loadsp = new LoadSP();



        // Phương thức lấy tất cả xuất xứ
        public List<XuatXu> LayTatCaXuatXu()
        {
            return loadsp.LayTatCaXuatXu(); // Gọi phương thức từ DAL
        }

        // Phương thức lấy tất cả Hãng
        public List<Hang> LayTatCaHang()
        {
            return loadsp.LayTatCaHang();
        }

        //Phương thức lấy tất cả thể loại
        public List<TheLoai> LayTatCaTheLoai()
        {
            return loadsp.LayTatCaTheLoai();
        }

        //Phương thức lấy tất cả NCC
        public List<NCC> LayTatCaNCC()
        {
            return loadsp.LayTatCaNCC();
        }

        public List<NCC> LayThongTinNCC()
        {
            return loadsp.LayThongTinNCC();
        }

        public List<NCC> LayTrangThaiNCC()
        {
            return loadsp.LayTrangThaiNCC();
        }

        public List<KieuDang> LayTatCaKieuDang()
        {
            return loadsp.LayTatCaKieuDang();
        }

        public List<MauSac> LayTatCaMauSac()
        {
            return loadsp.LayTatCaMauSac();
        }

        public List<SanPham> LayTatCaTrangThai()
        {
            return loadsp.LayTatTrangThai();
        }

        //Phương thức lấy ảnh
        public byte[] LayHinhAnh(int maSP)
        {
            return loadsp.LayHinhAnh(maSP);
        }

        //Phương thức lấy các sản phẩm
        public DataTable LayDanhSachSanPham()
        {
            return loadsp.LayDanhSachSanPham();
        }


        public DataTable TimKiemSanPham(string column, string keyword)
        {
            return loadsp.TimKiemSanPham(column, keyword);

        }
        public DataTable TimKiemNCC(string column, string keyword)
        {
            return loadsp.TimKiemNCC(column, keyword);

        }
        public DataTable LayChiTietSanPham(int maSP)
        {
            return loadsp.LayChiTietSanPham(maSP);
        }
        public DataTable LayChiTietNCC(int maNCC)
        {
            return loadsp.LayChiTietNCC(maNCC);
        }

        public void UpdateSanPham(SanPham sp)
        {
            loadsp.UpdateSanPham(sp); // Gọi phương thức từ DAL
        }

        public int LayMaNCCTheoTen(string tenNCC)
        {
            return loadsp.LayMaNCCTheoTen(tenNCC);
        }

        public int LayMaTheLoaiTheoTen(string tenTheLoai)
        {
            return loadsp.LayMaTheLoaiTheoTen(tenTheLoai);
        }

        public int LayMaXuatXuTheoTen(string tenXuatXu)
        {
            return loadsp.LayMaXuatXuTheoTen(tenXuatXu);
        }

        public int LayMaKieuDangTheoTen(string tenKieuDang)
        {
            return loadsp.LayMaKieuDangTheoTen(tenKieuDang);
        }

        public int LayMaMauSacTheoTen(string tenMauSac)
        {
            return loadsp.LayMaMauSacTheoTen(tenMauSac);
        }
        public int LayMaHangTheoTen(string tenHang)
        {
            return loadsp.LayMaHangTheoTen(tenHang);
        }

        public void XoaSanPham(int maSP)
        {
            loadsp.XoaSanPham(maSP);
        }

        public void ThemSanPham(SanPham sp, string pathToImage)
        {
            if (!string.IsNullOrEmpty(pathToImage))
            {
                sp.HinhAnh = System.IO.File.ReadAllBytes(pathToImage);
            }
            else
            {
                sp.HinhAnh = null;
            }

            loadsp.ThemSanPham(sp);
        }

        public DataTable LayDanhSachSanPhamTheoTheLoai(int maTheLoai)
        {
            return loadsp.LayDanhSachSanPhamTheoTheLoai(maTheLoai);
        }
        public void ThemNCC(NCC ncc)
        {
            loadsp.ThemNCC(ncc); // Gọi phương thức từ DAL
        }

        public bool XoaNCC(int maNCC)
        {
            return loadsp.XoaNCC(maNCC); // Gọi phương thức từ DAL
        }

        public bool XoaCTNCC(int maNCC)
        {
            return loadsp.XoaCTNCC(maNCC);
        }

        public void CapNhatNCC(NCC ncc)
        {
            // Gọi phương thức cập nhật từ DAL
            var dal = new LoadSP(); // Hoặc sử dụng Dependency Injection
            dal.CapNhatNCC(ncc);
        }

        public DataTable LayDanhSachHopDong()
        {
            return loadsp.LayDanhSachHopDong(); // Gọi phương thức từ DAL
        }
        public DataTable TimKiemHopDong(string keyword)
        {
            // Gọi tới DAL để lấy danh sách hợp đồng dựa trên từ khóa
            return new LoadSP().TimKiemHopDong(keyword);
        }
        public string LayTrangThaiHopDong(int maHopDong)
        {
            return loadsp.LayTrangThaiHopDong(maHopDong);
        }

        public void XoaHopDong(int maHopDong)
        {
            loadsp.XoaHopDong(maHopDong);
        }
        public DataTable LayChiTietHopDong(int maHopDong)
        {
            return loadsp.LayChiTietHopDong(maHopDong);
        }
        public void CapNhatHopDong(HopDong hopDong)
        {
            loadsp.CapNhatHopDong(hopDong);
        }
        public void XoaCTHopDong(int maHopDong)
        {
            loadsp.XoaCTHopDong(maHopDong);
        }

    }
}
