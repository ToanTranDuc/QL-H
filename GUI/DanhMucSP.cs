using BLL;
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
    public partial class DanhMucSP : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        public DanhMucSP()
        {
            InitializeComponent();
            LoadComboBox_Loai();
            dgvDanhSachSP.CellClick += dgvDanhSachSP_CellClick;
            btnDMReset.Click += btnDMReset_Click;
        }

        private void cmbDMTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDMTheLoai.SelectedItem is ComboBoxItem selectedItem)
            {
                int maTheLoai = selectedItem.Value; // Lấy mã thể loại đã chọn

                try
                {
                    // Lấy danh sách sản phẩm theo mã thể loại
                    DataTable dt = sanPhamBLL.LayDanhSachSanPhamTheoTheLoai(maTheLoai);

                    // Cập nhật DataGridView
                    dgvDanhSachSP.DataSource = dt;

                    // Ẩn cột hình ảnh
                    if (dgvDanhSachSP.Columns.Contains("HinhAnh"))
                    {
                        dgvDanhSachSP.Columns["HinhAnh"].Visible = false; // Ẩn cột hình ảnh
                    }

                    // Đặt tên cột cho DataGridView
                    var columnNames = new Dictionary<string, string>
            {
                { "MaSP", "Mã sản phẩm" },
                { "TenSP", "Tên sản phẩm" },
                { "MoTa", "Mô tả" },
                { "TenNCC", "NCC" },
                { "TenHang", "Hãng" },
                { "TenTheLoai", "Thể loại" },
                { "QuocGia", "Xuất Xứ" },
                { "TrangThai", "Trạng thái" },
                { "SoLuong", "Số lượng" },
            };

                    foreach (var column in columnNames)
                    {
                        if (dgvDanhSachSP.Columns.Contains(column.Key))
                        {
                            dgvDanhSachSP.Columns[column.Key].HeaderText = column.Value;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString() => Text;
        }

        void LoadComboBox_Loai()
        {
            try
            {
                var theLoais = sanPhamBLL.LayTatCaTheLoai();
                cmbDMTheLoai.Items.Clear();

                foreach (var theLoai in theLoais)
                {
                    cmbDMTheLoai.Items.Add(new ComboBoxItem { Text = theLoai.TenTheLoai, Value = theLoai.MaTheLoai });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách thể loại: {ex.Message}");
            }
        }

        private void btnDMChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvDanhSachSP.SelectedRows[0];
            int maSP = (int)selectedRow.Cells["MaSP"].Value;
            DataTable chiTietSP = sanPhamBLL.LayChiTietSanPham(maSP);

            ChiTietSP formChiTiet = new ChiTietSP(chiTietSP);
            formChiTiet.Show();
        }

        private void btnDMTim_Click(object sender, EventArgs e)
        {
            string keyword = txtDMTimKiem.Text.Trim();
            string selectedColumn = cmbDMTheLoai.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                DataTable dt = sanPhamBLL.TimKiemSanPham(selectedColumn, keyword);

                // Cập nhật DataGridView
                dgvDanhSachSP.DataSource = dt;


                var columnNames = new Dictionary<string, string>
        {
            { "MaSP", "Mã sản phẩm" },
            { "TenSP", "Tên sản phẩm" },
            { "MoTa", "Mô tả" },
            { "TenNCC", "NCC" },
            { "TenHang", "Hãng" },
            { "TenTheLoai", "Thể loại" },
            { "QuocGia", "Xuất Xứ" },
            { "TrangThai", "Trạng thái" },
            { "Số lượng", "Số lượng" },
        };

                foreach (var column in columnNames)
                {
                    if (dgvDanhSachSP.Columns.Contains(column.Key))
                    {
                        dgvDanhSachSP.Columns[column.Key].HeaderText = column.Value;
                    }
                }

                // Xử lý cột hình ảnh
                if (!dgvDanhSachSP.Columns.Contains("HinhAnh"))
                {
                    DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
                    {
                        Name = "HinhAnh",
                        HeaderText = "Hình Ảnh",
                        ImageLayout = DataGridViewImageCellLayout.Zoom
                    };
                    dgvDanhSachSP.Columns.Insert(0, imgColumn);
                }

                foreach (DataGridViewRow row in dgvDanhSachSP.Rows)
                {
                    if (row.Cells["MaSP"].Value != null)
                    {
                        int maSP = (int)row.Cells["MaSP"].Value;
                        byte[] hinhAnh = sanPhamBLL.LayHinhAnh(maSP);
                        if (hinhAnh != null)
                        {
                            using (MemoryStream ms = new MemoryStream(hinhAnh))
                            {
                                row.Cells["HinhAnh"].Value = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            row.Cells["HinhAnh"].Value = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtDMTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtDMTimKiem.Text == "")
            {
                txtDMTimKiem.Text = "Tìm kiếm";
                txtDMTimKiem.ForeColor = Color.White;
            }
        }

        private void txtDMTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtDMTimKiem.Text == "Tìm kiếm")
            {
                txtDMTimKiem.Text = "";
                txtDMTimKiem.ForeColor = Color.Aqua;
            }
        }

        private void dgvDanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0) // Kiểm tra nếu nhấp vào hàng hợp lệ
                {
                    DataGridViewRow selectedRow = dgvDanhSachSP.Rows[e.RowIndex];
                    
                    dgvDanhSachSP.ClearSelection();
                    dgvDanhSachSP.CurrentCell = null;
                    int maSP = (int)selectedRow.Cells["MaSP"].Value; // Lấy mã sản phẩm

                    // Lấy hình ảnh từ sản phẩm
                    byte[] hinhAnh = sanPhamBLL.LayHinhAnh(maSP);

                    if (hinhAnh != null)
                    {
                        using (MemoryStream ms = new MemoryStream(hinhAnh))
                        {
                            ptbDMAnhSP.Image = Image.FromStream(ms); // Hiển thị ảnh lên PictureBox
                        }
                    }
                    else
                    {
                        ptbDMAnhSP.Image = null; // Nếu không có ảnh, đặt là null
                    }

                    // Hiển thị đường dẫn ảnh nếu có (nếu cần)
                    string pathToImage = Path.Combine("Anh/", $"{maSP}.jpg"); // Giả sử ảnh được lưu ở đường dẫn này
                    txtDMAnhLoad.Text = pathToImage; // Cập nhật đường dẫn vào TextBox
                }
            }

        private void btnDMThem_Click(object sender, EventArgs e)
        {
            if (cmbDMTheLoai.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn 1 danh mục để thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã thể loại đã chọn
            ComboBoxItem selectedItem = (ComboBoxItem)cmbDMTheLoai.SelectedItem;
            int maTheLoai = selectedItem.Value;

            // Mở form ThemSP và truyền mã thể loại
            ThemSP formThemSP = new ThemSP();
            formThemSP.SetTheLoai(maTheLoai); // Giả sử bạn đã tạo phương thức SetTheLoai trong ThemSP
            formThemSP.Show();
        }

        private void LoadDataGridView(int maTheLoai)
        {
            try
            {
                // Lấy danh sách sản phẩm theo mã thể loại
                DataTable dt = sanPhamBLL.LayDanhSachSanPhamTheoTheLoai(maTheLoai);

                // Cập nhật DataGridView
                dgvDanhSachSP.DataSource = dt;

                // Đặt tên cột cho DataGridView
                var columnNames = new Dictionary<string, string>
                {
                    { "MaSP", "Mã sản phẩm" },
                    { "TenSP", "Tên sản phẩm" },
                    { "MoTa", "Mô tả" },
                    { "TenNCC", "NCC" },
                    { "TenHang", "Hãng" },
                    { "TenTheLoai", "Thể loại" },
                    { "QuocGia", "Xuất Xứ" },
                    { "TrangThai", "Trạng thái" },
                    { "SoLuong", "Số lượng" },
                };

                foreach (var column in columnNames)
                {
                    if (dgvDanhSachSP.Columns.Contains(column.Key))
                    {
                        dgvDanhSachSP.Columns[column.Key].HeaderText = column.Value;
                    }
                }

                // Ẩn cột hình ảnh nếu cần
                if (dgvDanhSachSP.Columns.Contains("HinhAnh"))
                {
                    dgvDanhSachSP.Columns["HinhAnh"].Visible = false; // Ẩn cột hình ảnh
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nạp lại danh sách sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDMReset_Click(object sender, EventArgs e)
        {
            if (cmbDMTheLoai.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn một danh mục trước khi reset.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã thể loại đã chọn
            ComboBoxItem selectedItem = (ComboBoxItem)cmbDMTheLoai.SelectedItem;
            int maTheLoai = selectedItem.Value;

            // Gọi lại phương thức để nạp lại dữ liệu cho DataGridView với thể loại đã chọn
            LoadDataGridView(maTheLoai);
        }
    }
}
