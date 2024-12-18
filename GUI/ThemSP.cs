using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using static GUI.DSSanPham;

namespace GUI
{
    public partial class ThemSP : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        public ThemSP()
        {
            InitializeComponent();
            LoadComboBox_NCC();
            LoadComboBox_Hang();
            LoadComboBox_Loai();
            LoadComboBox_XuatSu();
            LoadComboBox_KieuDang();
            LoadComboBox_Loai1();
            LoadComboBox_MauSac();
            LoadComboBox_TrangThai();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString() => Text;
        }
        private void LoadComboBoxes()
        {

            cmbTMNCC.DataSource = sanPhamBLL.LayTatCaNCC();
            cmbTMNCC.DisplayMember = "TenNCC";
            cmbTMNCC.ValueMember = "MaNCC";

            cmbTMHang.DataSource = sanPhamBLL.LayTatCaHang();
            cmbTMHang.DisplayMember = "TenHang";
            cmbTMHang.ValueMember = "MaHang";

            cmbTMTheLoai.DataSource = sanPhamBLL.LayTatCaTheLoai();
            cmbTMTheLoai.DisplayMember = "TenTheLoai";
            cmbTMTheLoai.ValueMember = "MaTheLoai";

            cmbTMXuatXu.DataSource = sanPhamBLL.LayTatCaXuatXu();
            cmbTMXuatXu.DisplayMember = "QuocGia";
            cmbTMXuatXu.ValueMember = "MaXuatXu";
        }

        void LoadComboBox_Hang()
        {
            try
            {
                var hangs = sanPhamBLL.LayTatCaHang();

                cmbTMHang.Items.Clear();

                foreach (var hang in hangs)
                {
                    cmbTMHang.Items.Add(new ComboBoxItem { Text = hang.TenHang, Value = hang.MaHang });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách hãng: {ex.Message}");
            }
        }
        void LoadComboBox_NCC()
        {
            try
            {
                var nccs = sanPhamBLL.LayTatCaNCC();

                cmbTMNCC.Items.Clear();

                foreach (var ncc in nccs)
                {
                    cmbTMNCC.Items.Add(new ComboBoxItem { Text = ncc.TenNCC, Value = ncc.MaNCC });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách NCC: {ex.Message}");
            }
        }
        void LoadComboBox_Loai()
        {
            try
            {
                var theLoais = sanPhamBLL.LayTatCaTheLoai();
                cmbTMTheLoai.Items.Clear();
                foreach (var theLoai in theLoais)
                {
                    cmbTMTheLoai.Items.Add(new ComboBoxItem { Text = theLoai.TenTheLoai, Value = theLoai.MaTheLoai });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách thể loại: {ex.Message}");
            }
        }

        private void LoadComboBox_Loai1()
        {
            var theLoais = sanPhamBLL.LayTatCaTheLoai(); // Lấy tất cả thể loại từ BLL
            cmbTMTheLoai.DataSource = theLoais;
            cmbTMTheLoai.DisplayMember = "TenTheLoai";
            cmbTMTheLoai.ValueMember = "MaTheLoai";
        }
        void LoadComboBox_XuatSu()
        {
            try
            {
                var xuatXus = sanPhamBLL.LayTatCaXuatXu();

                cmbTMXuatXu.Items.Clear();

                foreach (var xuatXu in xuatXus)
                {
                    cmbTMXuatXu.Items.Add(new ComboBoxItem { Text = xuatXu.QuocGia, Value = xuatXu.MaXuatXu });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load xuất xứ: {ex.Message}");
            }
        }

        void LoadComboBox_KieuDang()
        {
            try
            {
                var kieuDangs = sanPhamBLL.LayTatCaKieuDang();

                cmbTMKieuDang.Items.Clear();

                foreach (var kieuDang in kieuDangs)
                {
                    cmbTMKieuDang.Items.Add(new ComboBoxItem { Text = kieuDang.TenKieuDang, Value = kieuDang.MaKieuDang });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load kiểu dáng: {ex.Message}");
            }
        }
        void LoadComboBox_MauSac()
        {
            try
            {
                var mauSacs = sanPhamBLL.LayTatCaMauSac();

                cmbTMMauSac.Items.Clear();

                foreach (var mauSac in mauSacs)
                {
                    cmbTMMauSac.Items.Add(new ComboBoxItem { Text = mauSac.TenMauSac, Value = mauSac.MaMauSac });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load màu sắc: {ex.Message}");
            }
        }

        void LoadComboBox_TrangThai()
        {
            try
            {
                var trangThais = sanPhamBLL.LayTatCaTrangThai();
                cmbTMTrangThai.Items.Clear();

                // Sử dụng HashSet để lưu trạng thái độc nhất
                HashSet<string> uniqueStatuses = new HashSet<string>();

                foreach (var trangThai in trangThais)
                {
                    // Kiểm tra nếu trạng thái chưa tồn tại trong HashSet
                    if (uniqueStatuses.Add(trangThai.TrangThai))
                    {
                        cmbTMTrangThai.Items.Add(trangThai.TrangThai);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load trạng thái: {ex.Message}");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTMLuu_Click(object sender, EventArgs e)
        {
            string tenSP = txtTMTenSP.Text.Trim();
            string moTa = txtTMMoTa.Text.Trim();
            string tenNCC = cmbTMNCC.Text.Trim(); 
            string tenHang = cmbTMHang.Text.Trim(); 
            string tenTheLoai = cmbTMTheLoai.Text.Trim(); 
            string tenXuatXu = cmbTMXuatXu.Text.Trim(); 
            string tenKieuDang = cmbTMKieuDang.Text.Trim();
            string tenMauSac = cmbTMMauSac.Text.Trim();
            int maNCC = sanPhamBLL.LayMaNCCTheoTen(tenNCC);
            int maHang = sanPhamBLL.LayMaHangTheoTen(tenHang);
            int maTheLoai = sanPhamBLL.LayMaTheLoaiTheoTen(tenTheLoai);
            int maXuatXu = sanPhamBLL.LayMaXuatXuTheoTen(tenXuatXu);
            int maKieuDang = sanPhamBLL.LayMaKieuDangTheoTen(tenKieuDang);
            int maMauSac = sanPhamBLL.LayMaMauSacTheoTen(tenMauSac);

            if (maNCC == -1 || maHang == -1 || maTheLoai == -1 || maXuatXu == -1 || maKieuDang == -1)
            {
                MessageBox.Show("Một trong những tên nhập không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float giaNhap = float.Parse(txtTMGiaNhap.Text.Trim());
            float giaBan = float.Parse(txtTMGiaBan.Text.Trim());
            DateTime ngayNhap = dtpTMNgayNhap.Value;
            string trangThai = cmbTMTrangThai.Text.Trim();
            // int maMauSac = int.Parse(cmbTMMauSac.Text.Trim());
            if (string.IsNullOrEmpty(txtTMSoLuong.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

      

            string imagePath = txtTMPath.Text.Trim();
            byte[] hinhAnh = ConvertImageToByteArray(imagePath);

            SanPham sp = new SanPham
            {
                TenSP = tenSP,
                MoTa = moTa,
                MaNCC = maNCC,
                MaHang = maHang,
                MaTheLoai = maTheLoai,
                MaXuatXu = maXuatXu,
                TrangThai = trangThai,
                SoLuong = int.Parse(txtTMSoLuong.Text.Trim()),
                MaKieuDang = maKieuDang,
                GiaBan = giaBan,
                GiaNhap = giaNhap,
                NgayNhap = ngayNhap,
                MaMauSac = maMauSac,
                HinhAnh = hinhAnh
            };

            sanPhamBLL.ThemSanPham(sp, imagePath);

            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void grbTMTT_Enter(object sender, EventArgs e)
        {

        }

        private void btnTMChonTep_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;

                    // Kiểm tra nếu file tồn tại
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("Đường dẫn hình ảnh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Hiển thị đường dẫn file vào TextBox
                    txtTMPath.Text = filePath;

                    try
                    {
                        // Tải và điều chỉnh kích thước hình ảnh
                        Image img = Image.FromFile(filePath);
                        Image resized = new Bitmap(img, new Size(100, 100));
                        ptbTMAnh.Image = resized;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); 
                }
                return ms.ToArray();
            }
        }

        public void SetTheLoai(int maTheLoai)
        {
            // Giả sử bạn có một ComboBox cho thể loại
            cmbTMTheLoai.SelectedValue = maTheLoai; // Thiết lập giá trị cho ComboBox

            // Vô hiệu hóa ComboBox để không cho phép thay đổi
            cmbTMTheLoai.Enabled = false;
        }

        private void cmbTMTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
