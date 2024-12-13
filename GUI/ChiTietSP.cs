using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietSP : Form
    {
        //private int maSP;
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        private bool isEditing = false;
        public ChiTietSP(DataTable chiTietSP)
        {
            InitializeComponent();
            HienThiThongTin(chiTietSP);
        }
        private void HienThiThongTin(DataTable chiTietSP)
        {
            if (chiTietSP.Rows.Count > 0)
            {
                var row = chiTietSP.Rows[0];
                txtCTMaSP.Text = row["MaSP"].ToString();
                txtCTTenSP.Text = row["TenSP"].ToString();
                txtCTMoTa.Text = row["MoTa"].ToString();
                txtCTNCC.Text = row["TenNCC"].ToString();
                txtCTHang.Text = row["TenHang"].ToString();
                txtCTTheLoai.Text = row["TenTheLoai"].ToString();
                txtCTXuatXu.Text = row["QuocGia"].ToString();
                txtCTGiaBan.Text = row["GiaBan"].ToString();
                txtCTGiaNhap.Text = row["GiaNhap"].ToString();
                txtCTMauSac.Text = row["TenMauSac"].ToString();
                txtCTKieuDang.Text = row["TenKieuDang"].ToString();
                dtpCTNgayNhap.Value = Convert.ToDateTime(row["NgayNhap"]);
                txtCTTrangThai.Text = row["TrangThai"].ToString();
                txtCTSoLuong.Text = row["SoLuong"].ToString();


                // Hiển thị hình ảnh nếu có
                if (row["HinhAnh"] != DBNull.Value)
                {
                    byte[] hinhAnh = (byte[])row["HinhAnh"];
                    using (MemoryStream ms = new MemoryStream(hinhAnh))
                    {
                        ptbCTAnh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbCTAnh.Image = null;
                }
            }
        }

         void ChiTietSP_Load(object sender, EventArgs e)
        {

        }

        private void btnCTDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCTSua_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
               
                UpdateSanPham();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCTSua.Text = "Sửa";
            }
            else
            {
                
                btnCTSua.Text = "Cập nhật";
                EnableTextBoxes(true);
            }
            isEditing = !isEditing; 
        }

        private void EnableTextBoxes(bool enable)
        {
            txtCTTenSP.Enabled = enable;
            txtCTMoTa.Enabled = enable;
            txtCTGiaBan.Enabled = enable;
            txtCTGiaNhap.Enabled = enable;
            txtCTMauSac.Enabled = enable;
            txtCTKieuDang.Enabled = enable;
            dtpCTNgayNhap.Enabled = enable;
            txtCTHang.Enabled = enable;
            txtCTNCC.Enabled = enable;
            txtCTXuatXu.Enabled = enable;
            txtCTTheLoai.Enabled = enable;  
        }

        private void UpdateSanPham()
        {
            
            int maHang = sanPhamBLL.LayMaHangTheoTen(txtCTHang.Text);
            int maNCC = sanPhamBLL.LayMaNCCTheoTen(txtCTNCC.Text);
            int maTheLoai = sanPhamBLL.LayMaTheLoaiTheoTen(txtCTTheLoai.Text);
            int maXuatXu = sanPhamBLL.LayMaXuatXuTheoTen(txtCTXuatXu.Text);
            int maKieuDang = sanPhamBLL.LayMaKieuDangTheoTen(txtCTKieuDang.Text);
            int maMauSac = sanPhamBLL.LayMaMauSacTheoTen(txtCTMauSac.Text);
            byte[] hinhAnhBytes = ConvertImageToByteArray(txtCTPath.Text);
            var updatedSP = new SanPham
            {
                MaSP = int.Parse(txtCTMaSP.Text),
                TenSP = txtCTTenSP.Text,
                MoTa = txtCTMoTa.Text,
                GiaNhap = float.Parse(txtCTGiaNhap.Text),
                GiaBan = float.Parse(txtCTGiaBan.Text),
                NgayNhap = dtpCTNgayNhap.Value,
                MaHang = maHang, 
                MaNCC = maNCC,   
                MaKieuDang = maKieuDang,
                MaTheLoai = maTheLoai,
                MaXuatXu = maXuatXu,
                MaMauSac = maMauSac,
                HinhAnh = hinhAnhBytes,
                TrangThai = txtCTTrangThai.Text,
                SoLuong = int.Parse (txtCTSoLuong.Text),
            };

            sanPhamBLL.UpdateSanPham(updatedSP); 
        }

        private void btnCTChonTep_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; 

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                   
                    if (string.IsNullOrEmpty(dialog.FileName) || !File.Exists(dialog.FileName))
                    {
                        MessageBox.Show("Đường dẫn hình ảnh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string filePath = dialog.FileName;
                    txtCTPath.Text = filePath;
                    Image img = Image.FromFile(dialog.FileName);
                    Image resized = new Bitmap(img, new Size(100, 100)); 
                    ptbCTAnh.Image = resized; 
                }
            }
        }

        private byte[] ConvertImageToByteArray(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath))
                return null;

            using (var ms = new MemoryStream())
            {
                using (var image = Image.FromFile(imagePath))
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Bạn có thể thay đổi định dạng nếu cần
                }
                return ms.ToArray();
            }
        }

        private void btnCTXoa_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(txtCTMaSP.Text);
            string trangThai = txtCTTrangThai.Text;

            if (trangThai == "Đang bán")
            {
                // Thay đổi trạng thái thành "Ngừng bán"
                SanPham sp = new SanPham { MaSP = maSP, TrangThai = "Ngưng bán" };
                sanPhamBLL.UpdateSanPham(sp);
                MessageBox.Show("Sản phẩm đã được ẩn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                sanPhamBLL.XoaSanPham(maSP);
                MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close(); 
        }

        private void txtCTMaSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
