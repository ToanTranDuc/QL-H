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
    public partial class ChiTietNCC : Form
    {
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        private bool isEditing = false;
        private string originalTenNCC;
        private string originalMST;
        private string originalDienThoai;
        private string originalEmail;
        private string originalDiaChi;
        private string originalNguoiCapNhat;
        public ChiTietNCC(DataTable chiTietNCC)
        {
            InitializeComponent();
            HienThiThongTin(chiTietNCC);
            LoadComboBox_TrangThai();

            originalTenNCC = txtCTTenNCC.Text;
            originalMST = txtCTMST.Text;
            originalDienThoai = txtCTDienThoai.Text;
            originalEmail = txtCTEmail.Text;
            originalDiaChi = txtCTDiaChi.Text;
            originalNguoiCapNhat = txtCTNguoiCapNhat.Text;
        }

        private void btnCTXoa_Click(object sender, EventArgs e)
        {
            string trangThai = cmbCTTrangThai.Text; // Lấy trạng thái từ combo box

            if (trangThai != "Ngừng hoạt động")
            {
                MessageBox.Show("Chỉ có thể xóa nhà cung cấp có trạng thái 'Ngừng hoạt động'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int maNCC = int.Parse(txtCTMaNCC.Text); // Lấy mã NCC từ textbox
                bool isDeleted = sanPhamBLL.XoaCTNCC(maNCC); // Gọi phương thức xóa từ BLL

                if (isDeleted)
                {
                    MessageBox.Show("Nhà cung cấp đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form
                }
                else
                {
                    MessageBox.Show("Không thể xóa nhà cung cấp. Kiểm tra lại trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void HienThiThongTin(DataTable chiTietNCC)
        {
            if (chiTietNCC.Rows.Count > 0)
            {
                var row = chiTietNCC.Rows[0];
                txtCTMaNCC.Text = row["MaNCC"].ToString();
                txtCTTenNCC.Text = row["TenNCC"].ToString();
                txtCTMST.Text = row["MST"].ToString();
                txtCTDienThoai.Text = row["DienThoai"].ToString();
                txtCTEmail.Text = row["Email"].ToString();
                txtCTDiaChi.Text = row["DiaChi"].ToString();
                txtCTNguoiTao.Text = row["NguoiTao"].ToString();
                dtpCTNgayCapNhat.Value = Convert.ToDateTime(row["NgayCapNhat"]);
                txtCTNguoiCapNhat.Text = row["NguoiCapNhat"].ToString();
                dtpCTNgayTao.Value = Convert.ToDateTime(row["NgayTao"]);
                cmbCTTrangThai.Text = row["TrangThai"].ToString();

                SetFieldsEnabled(false);
            }
        }

        private void btnCTSua_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Bật chế độ sửa
                isEditing = true;
                txtCTMaNCC.Enabled = false; // Không cho sửa mã NCC
                txtCTTenNCC.Enabled = true;
                txtCTMST.Enabled = true;
                txtCTDienThoai.Enabled = true;
                txtCTEmail.Enabled = true;
                txtCTDiaChi.Enabled = true;
                txtCTNguoiCapNhat.Enabled = true;
                cmbCTTrangThai.Enabled = true;
                dtpCTNgayTao.Enabled = true;
                dtpCTNgayCapNhat.Enabled = true;
                txtCTNguoiTao.Enabled = true;
                // Thay đổi tên nút
                btnCTSua.Text = "Cập nhật";
            }
            else
            {

                try
                {
                    NCC updatedNCC = new NCC
                    {
                        MaNCC = int.Parse(txtCTMaNCC.Text),
                        TenNCC = txtCTTenNCC.Text,
                        MST = txtCTMST.Text,
                        DienThoai = txtCTDienThoai.Text,
                        Email = txtCTEmail.Text,
                        DiaChi = txtCTDiaChi.Text,
                        NguoiTao = txtCTNguoiTao.Text,
                        NguoiCapNhat = txtCTNguoiCapNhat.Text,
                        NgayTao = dtpCTNgayTao.Value,
                        TrangThai = cmbCTTrangThai.Text,
                        NgayCapNhat = dtpCTNgayCapNhat.Value
                    };


                    sanPhamBLL.CapNhatNCC(updatedNCC);

                    MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void LoadComboBox_TrangThai()
        {
            try
            {
                var trangThais = sanPhamBLL.LayTrangThaiNCC();
                cmbCTTrangThai.Items.Clear();

                // Sử dụng HashSet để lưu trạng thái độc nhất
                HashSet<string> uniqueStatuses = new HashSet<string>();

                foreach (var trangThai in trangThais)
                {
                    // Kiểm tra nếu trạng thái chưa tồn tại trong HashSet
                    if (uniqueStatuses.Add(trangThai.TrangThai))
                    {
                        cmbCTTrangThai.Items.Add(trangThai.TrangThai);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load trạng thái: {ex.Message}");
            }
        }

        private void btnCTDong_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void SetFieldsEnabled(bool isEnabled)
        {
            txtCTTenNCC.Enabled = isEnabled;
            txtCTMST.Enabled = isEnabled;
            txtCTDienThoai.Enabled = isEnabled;
            txtCTEmail.Enabled = isEnabled;
            txtCTDiaChi.Enabled = isEnabled;
            txtCTNguoiCapNhat.Enabled = isEnabled;
            cmbCTTrangThai.Enabled = isEnabled;
            txtCTNguoiTao.Enabled = isEnabled;
            dtpCTNgayCapNhat.Enabled = isEnabled;
            dtpCTNgayTao.Enabled = isEnabled;
        }

        private void btnCTHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Khôi phục lại các giá trị ban đầu
                txtCTTenNCC.Text = originalTenNCC;
                txtCTMST.Text = originalMST;
                txtCTDienThoai.Text = originalDienThoai;
                txtCTEmail.Text = originalEmail;
                txtCTDiaChi.Text = originalDiaChi;
                txtCTNguoiCapNhat.Text = originalNguoiCapNhat;

                this.Close();
            }
        }
    }
}
