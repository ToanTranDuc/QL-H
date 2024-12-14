using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Contract : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        public Contract()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = bll.LayDanhSachHopDong(); // Gọi từ BLL
            dgvHDDSNCC.DataSource = dt;



            var columnNames = new Dictionary<string, string>
             {
                { "MaHopDong", "Mã hợp đồng" },
                { "TenHopDong", "Tên hợp đồng" },
                { "MoTa", "Mô tả" },
                { "NgayKy", "Ngày ký" },
                { "NguoiKy", "Người ký" },
                { "NgayHieuLuc", "Ngày hiệu lực" },
                { "NgayHetHan", "Ngày hết hạn" },
                { "TrangThai", "Trạng thái" },
                { "GiaTri", "Giá trị" },
                {"MaNCC", "Tên nhà cung cấp"  }
             };


            foreach (var column in columnNames)
            {
                if (dgvHDDSNCC.Columns.Contains(column.Key))
                {
                    dgvHDDSNCC.Columns[column.Key].HeaderText = column.Value;
                    dgvHDDSNCC.Columns[column.Key].DisplayIndex = Array.IndexOf(columnNames.Keys.ToArray(), column.Key);
                    //   dgvHDDSNCC.Columns[column.Key].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            // Ẩn cột MaNCC nếu cần
            if (dgvHDDSNCC.Columns.Contains("MaNCC"))
            {
                dgvHDDSNCC.Columns["MaNCC"].Visible = false; // Ẩn cột MaNCC nếu cần
            }
        }

        private void dgvHDDSNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu người dùng nhấn vào dòng hợp lệ
            {
                DataGridViewRow row = dgvHDDSNCC.Rows[e.RowIndex];

                // Gán giá trị từ các cột vào các textbox
                txtHDMHD.Text = row.Cells["MaHopDong"].Value.ToString();
                txtHDTenHD.Text = row.Cells["TenHopDong"].Value.ToString();
                txtHDNgayKy.Text = row.Cells["NgayKy"].Value.ToString();
                txtHDNguoiKy.Text = row.Cells["NguoiKy"].Value.ToString();
            }
        }

        private void btnHDTim_Click(object sender, EventArgs e)
        {
            string keyword = txtHDTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                DataTable dt = bll.TimKiemHopDong(keyword);
                dgvHDDSNCC.DataSource = dt;
            }
            else
            {
                // Hiển thị thông báo nếu không có từ khóa
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
            }
        }

        private void btnHDReset_Click(object sender, EventArgs e)
        {
            txtHDMHD.ResetText();
            txtHDNgayKy.ResetText();
            txtHDNguoiKy.ResetText();
            txtHDTenHD.ResetText();
            txtHDTimKiem.ResetText();
            LoadData();
        }

        private void btnHDXoa_Click(object sender, EventArgs e)
        {

            if (dgvHDDSNCC.CurrentRow != null)
            {
                int maHopDong = Convert.ToInt32(dgvHDDSNCC.CurrentRow.Cells["MaHopDong"].Value);
                string trangThai = bll.LayTrangThaiHopDong(maHopDong);

                if (trangThai == "Ngừng hoạt động")
                {
                    // Thực hiện xóa hợp đồng
                    bll.XoaHopDong(maHopDong);
                    MessageBox.Show("Hợp đồng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Tải lại dữ liệu
                }
                else
                {
                    MessageBox.Show("Không thể xóa hợp đồng. Trạng thái không phải là 'Ngừng hoạt động'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHDChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvHDDSNCC.CurrentRow != null)
            {
                int maHopDong = Convert.ToInt32(dgvHDDSNCC.CurrentRow.Cells["MaHopDong"].Value);
                ChiTietHopDong formCTHD = new ChiTietHopDong(maHopDong);
                formCTHD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Contract_Load(object sender, EventArgs e)
        {

        }
    }
}
