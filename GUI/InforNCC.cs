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
    public partial class InforNCC : Form
    {
        private bool isDataChanged = false;
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        public static InforNCC Instance { get; private set; }
        public InforNCC()
        {
            InitializeComponent();
            Instance = this;
            LoadComboBox_GTTim();
        }

        public void LoadNCCData()
        {
            //try
            //{
                // Lấy danh sách nhà cung cấp
                var danhSachThongTinNCC = sanPhamBLL.LayThongTinNCC();

                if (danhSachThongTinNCC == null || danhSachThongTinNCC.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhà cung cấp.");
                    return;
                }

                // Xóa cột cũ trước khi gán dữ liệu mới
                dgvDanhSachNCC.Columns.Clear();
                dgvDanhSachNCC.DataSource = danhSachThongTinNCC;
               

                // Đặt tên tiêu đề cho các cột
                dgvDanhSachNCC.Columns["MaNCC"].HeaderText = "Mã NCC";
                dgvDanhSachNCC.Columns["TenNCC"].HeaderText = "Tên NCC";
            dgvDanhSachNCC.Columns["MST"].HeaderText = "Mã số thuế";
            dgvDanhSachNCC.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvDanhSachNCC.Columns["Email"].HeaderText = "Email";
            dgvDanhSachNCC.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDanhSachNCC.Columns["NguoiTao"].HeaderText = "Người tạo";
            dgvDanhSachNCC.Columns["NgayCapNhat"].HeaderText = "Ngày cập nhật";
            dgvDanhSachNCC.Columns["NguoiCapNhat"].HeaderText = "Người cập nhật";
            dgvDanhSachNCC.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dgvDanhSachNCC.Columns["TrangThai"].HeaderText = "Trạng thái";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message);
            //}
        }


        private void InforNCC_Load(object sender, EventArgs e)
        {
           
            LoadNCCData();
        }

        private void btnInFoThem_Click(object sender, EventArgs e)
        {
            ThemNCC themNCC = new ThemNCC();
            themNCC.FormClosing += ThemNCC_FormClosing;
            themNCC.Show();

        }


        private void ThemNCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataChanged)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; 
                }
            }
        }

        private void txtTTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTTimKiem.Text == "Tìm kiếm")
            {
                txtTTimKiem.Text = "";
                txtTTimKiem.ForeColor = Color.Aqua;
            }
        }

        private void txtTTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTTimKiem.Text == "")
            {
                txtTTimKiem.Text = "Tìm kiếm";
                txtTTimKiem.ForeColor = Color.White;
            }
        }

        private void cmbTGTTim_Leave(object sender, EventArgs e)
        {
            if (txtTTimKiem.Text == "")
            {
                txtTTimKiem.Text = "Giá trị tìm";
                txtTTimKiem.ForeColor = Color.Aqua;
            }
        }

        private void cmbTGTTim_Enter(object sender, EventArgs e)
        {
            if (txtTTimKiem.Text == "Giá trị tìm")
            {
                txtTTimKiem.Text = "";
                txtTTimKiem.ForeColor = Color.Aqua;
            }
        }

        private void btnTTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTTimKiem.Text.Trim();
            string selectedColumn = cmbTGTTim.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(keyword) || string.IsNullOrEmpty(selectedColumn))
            {
                MessageBox.Show("Vui lòng nhập từ khóa và chọn cột để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                DataTable dt = sanPhamBLL.TimKiemNCC(selectedColumn, keyword);

                // Cập nhật DataGridView
                dgvDanhSachNCC.DataSource = dt;


                var columnNames = new Dictionary<string, string>
        {
            { "MaNCC", "Mã NCC" },
            { "TenNCC", "Tên NCC" },
            { "MST", "Mã số thuế" },
            { "DienThoai", "Điện thoại" },
            { "Email", "Email" },
            { "DiaChi", "Địa chỉ" },
            { "NguoiTao", "Người tạo" },
            { "NgayCapNhat", "NgayCapNhat" },
            { "NguoiCapNhat", "Người cập nhật" },
            { "NgayTao", "NgayTao" },
            { "TrangThai", "Trạng thái" },
            
        };

                foreach (var column in columnNames)
                {
                    if (dgvDanhSachNCC.Columns.Contains(column.Key))
                    {
                        dgvDanhSachNCC.Columns[column.Key].HeaderText = column.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBox_GTTim()
        {
            try
            {
                cmbTGTTim.Items.Clear();

                var predefinedColumns = new HashSet<string>
                {
                    "Mã NCC",
                    "Tên NCC",
                    "Mã số thuế",
                    "Điện thoại",
                    "Người tạo",
                    "Người cập nhật",
                    "Trạng thái"
                };

                cmbTGTTim.Items.AddRange(predefinedColumns.ToArray());

               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách cột: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInForReset_Click(object sender, EventArgs e)
        {
            LoadNCCData();  
        }

        private void btnInFoXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã NCC từ hàng đã chọn
            int maNCC = Convert.ToInt32(dgvDanhSachNCC.SelectedRows[0].Cells["MaNCC"].Value);
            string trangThai = dgvDanhSachNCC.SelectedRows[0].Cells["TrangThai"].Value.ToString(); // Lấy trạng thái từ hàng đã chọn

            if (trangThai != "Ngừng hoạt động")
            {
                MessageBox.Show("Chỉ có thể xóa nhà cung cấp có trạng thái 'Ngừng hoạt động'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = sanPhamBLL.XoaNCC(maNCC); // Gọi phương thức xóa từ BLL

                if (isDeleted)
                {
                    MessageBox.Show("Nhà cung cấp đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cập nhật lại danh sách nhà cung cấp
                    LoadNCCData(); 
                }
                else
                {
                    MessageBox.Show("Không thể xóa nhà cung cấp. Kiểm tra lại trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnInFoChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvDanhSachNCC.SelectedRows[0];
            int maNCC = (int)selectedRow.Cells["MaNCC"].Value;

            DataTable chiTietNCC = sanPhamBLL.LayChiTietNCC(maNCC);

            ChiTietNCC formChiTiet = new ChiTietNCC(chiTietNCC);
            formChiTiet.Show();
        }
    }
}
