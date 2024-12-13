using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DSSanPham : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        public DSSanPham()
        {

            InitializeComponent();
            sanPhamBLL = new SanPhamBLL();
            LoadData();
            LoadComboBox_NCC();
            LoadComboBox_Hang();
            LoadComboBox_Loai();
            LoadComboBox_XuatSu();
            LoadComboBox_GTTim();
            
            dgvDanhSachSP.CellClick += dgvDanhSachSP_CellClick;
            btnTim.Click += btnTim_Click;
        }

        

        private void LoadData()
        {

            if (dgvDanhSachSP.Columns.Contains("HinhAnh"))
            {
                dgvDanhSachSP.Columns.Remove("HinhAnh");
            }


            DataTable dt = sanPhamBLL.LayDanhSachSanPham();
            dgvDanhSachSP.DataSource = dt;

            if (dt.Columns.Contains("HinhAnh"))
            {
                dt.Columns.Remove("HinhAnh");
            }


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
                {"HinhAnh", "Hình ảnh"  }
             };

        
            foreach (var column in columnNames)
            {
                if (dgvDanhSachSP.Columns.Contains(column.Key))
                {
                    dgvDanhSachSP.Columns[column.Key].HeaderText = column.Value;
                }
            }

        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString() => Text; 
        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachSP.Rows[e.RowIndex];

                int maSP = (int)row.Cells["MaSP"].Value;
                string tenSP = row.Cells["TenSP"].Value.ToString();
                string tenNCC = row.Cells["TenNCC"].Value.ToString();
                string tenHang = row.Cells["TenHang"].Value.ToString();
                string tenTheLoai = row.Cells["TenTheLoai"].Value.ToString();
                string quocGia = row.Cells["QuocGia"].Value.ToString();
                string trangThai = row.Cells["TrangThai"].Value.ToString();
                int soLuong = (int)row.Cells["SoLuong"].Value;

                txtMSP.Text = maSP.ToString();
                txtTenSP.Text = tenSP;
                txtTrangThai.Text = trangThai;
                txtSoLuong.Text = soLuong.ToString();

                var nccItem = cmbNCC.Items.OfType<ComboBoxItem>().FirstOrDefault(x => x.Text == tenNCC);
                if (nccItem != null) cmbNCC.SelectedItem = nccItem;

                var hangItem = cmbHang.Items.OfType<ComboBoxItem>().FirstOrDefault(x => x.Text == tenHang);
                if (hangItem != null) cmbHang.SelectedItem = hangItem;

                var theLoaiItem = cmbTheLoai.Items.OfType<ComboBoxItem>().FirstOrDefault(x => x.Text == tenTheLoai);
                if (theLoaiItem != null) cmbTheLoai.SelectedItem = theLoaiItem;

                var xuatXuItem = cmbXuatXu.Items.OfType<ComboBoxItem>().FirstOrDefault(x => x.Text == quocGia);
                if (xuatXuItem != null) cmbXuatXu.SelectedItem = xuatXuItem;

               
                byte[] hinhAnh = sanPhamBLL.LayHinhAnh(maSP);
                if (hinhAnh != null && hinhAnh.Length > 0)
                {
                    
                    string validFileName = string.Join("_", tenSP.Split(Path.GetInvalidFileNameChars()));
                    string path = $@"C:\AnhSP\{validFileName}.jpg";

                   
                    string directory = Path.GetDirectoryName(path);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    
                    File.WriteAllBytes(path, hinhAnh);

                   
                    txtAnhLoad.Text = path;

                    using (MemoryStream ms = new MemoryStream(hinhAnh))
                    {
                        ptbAnhSP.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm chưa có hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ptbAnhSP.Image = null;
                    txtAnhLoad.Text = "Không có hình ảnh";
                }
            }
        }
        private void LoadComboBoxes()
        {
            
            cmbNCC.DataSource = sanPhamBLL.LayTatCaNCC();
            cmbNCC.DisplayMember = "TenNCC"; 
            cmbNCC.ValueMember = "MaNCC"; 

            cmbHang.DataSource = sanPhamBLL.LayTatCaHang();
            cmbHang.DisplayMember = "TenHang";
            cmbHang.ValueMember = "MaHang";

            cmbTheLoai.DataSource = sanPhamBLL.LayTatCaTheLoai();
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";

            cmbXuatXu.DataSource = sanPhamBLL.LayTatCaXuatXu();
            cmbXuatXu.DisplayMember = "QuocGia"; 
            cmbXuatXu.ValueMember = "MaXuatXu"; 
        }

        void LoadComboBox_Hang()
        {
            try
            {
                var hangs = sanPhamBLL.LayTatCaHang();

                cmbHang.Items.Clear();

                foreach (var hang in hangs)
                {
                    cmbHang.Items.Add(new ComboBoxItem { Text = hang.TenHang, Value = hang.MaHang });
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

                cmbNCC.Items.Clear();

                foreach (var ncc in nccs)
                {
                    cmbNCC.Items.Add(new ComboBoxItem { Text = ncc.TenNCC, Value = ncc.MaNCC });
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
                cmbTheLoai.Items.Clear();

                foreach (var theLoai in theLoais)
                {
                    cmbTheLoai.Items.Add(new ComboBoxItem { Text = theLoai.TenTheLoai, Value = theLoai.MaTheLoai });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách thể loại: {ex.Message}");
            }
        }
        void LoadComboBox_XuatSu()
        {
            try
            {
                var xuatXus = sanPhamBLL.LayTatCaXuatXu();

                cmbXuatXu.Items.Clear();

                foreach (var xuatXu in xuatXus)
                {
                    cmbXuatXu.Items.Add(new ComboBoxItem { Text = xuatXu.QuocGia, Value = xuatXu.MaXuatXu });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load xuất xứ: {ex.Message}");
            }
        }
        private void LoadComboBox_GTTim()
        {
            try
            {
                cmbGTTim.Items.Clear();

                var predefinedColumns = new HashSet<string>
                {
                    "Mã sản phẩm",
                    "Tên sản phẩm",
                    "Mô tả",
                    "NCC",
                    "Hãng",
                    "Xuất Xứ",
                    "Thể loại"
                };

                cmbGTTim.Items.AddRange(predefinedColumns.ToArray());

                foreach (DataGridViewColumn column in dgvDanhSachSP.Columns)
                {
                    if (column.Name != "HinhAnh" && !predefinedColumns.Contains(column.HeaderText))
                    {
                        cmbGTTim.Items.Add(column.HeaderText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách cột: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa các trường nhập liệu
                txtMSP.ResetText();
                txtTenSP.ResetText();
                txtTimKiem.ResetText();
                cmbHang.ResetText();
                cmbNCC.ResetText();
                cmbTheLoai.ResetText();
                cmbXuatXu.ResetText();
                cmbGTTim.ResetText();
                txtTrangThai.ResetText();
                txtSoLuong.ResetText();
                ptbAnhSP.Image = null;

                MessageBox.Show("Dữ liệu đã được làm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbGTTim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Aqua;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.White;
            }
        }

        private void cmbGTTim_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Giá trị tìm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Aqua;
            }
        }

        private void cmbGTTim_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Giá trị tìm";
                txtTimKiem.ForeColor = Color.Aqua;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string selectedColumn = cmbGTTim.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(keyword) || string.IsNullOrEmpty(selectedColumn))
            {
                MessageBox.Show("Vui lòng nhập từ khóa và chọn cột để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnChiTiet_Click(object sender, EventArgs e)
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

        private void txtAnhLoad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSP.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDanhSachSP.SelectedRows[0];
                int maSP = (int)row.Cells["MaSP"].Value;
                string trangThai = row.Cells["TrangThai"].Value.ToString();

                if (trangThai == "Đang bán")
                {
                   
                    SanPham sp = new SanPham { MaSP = maSP, TrangThai = "Ngưng bán" };
                    sanPhamBLL.UpdateSanPham(sp);
                    MessageBox.Show("Sản phẩm đã được ẩn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    sanPhamBLL.XoaSanPham(maSP);
                    MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData(); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSP formThemSP = new ThemSP();
            formThemSP.FormClosing += FormThemSP_FormClosing; 
            formThemSP.Show();
        }

        private void FormThemSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("Bạn có chắc chắn muốn hủy lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true; 
            }
            else
            {
                LoadData();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
