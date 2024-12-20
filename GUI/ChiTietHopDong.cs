﻿using BLL;
using DTO;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class ChiTietHopDong : Form
    {
        private SanPhamBLL bll = new SanPhamBLL();
        private int maHopDong;
        private bool isEditing = false;
        public ChiTietHopDong(int maHopDong)
        {
            InitializeComponent();
            this.maHopDong = maHopDong;
            LoadChiTietHopDong();
            LoadComboBox_TrangThai();
            LoadComboBox_NCC();
            SetFieldsEnabled(isEditing);
        }

        private void btnCTDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetFieldsEnabled(bool isEnabled)
        {
            txtCTHDMHD.Enabled = isEnabled;
            txtCTHDTenHD.Enabled = isEnabled;
            txtCTHDMoTa.Enabled = isEnabled;
            dtpCTHDNHL.Enabled = isEnabled;
            dtpCTHDNHH.Enabled = isEnabled;
            dtpCTHDNgayKy.Enabled = isEnabled;
            txtCTHDNguoiKy.Enabled = isEnabled;
            txtCTHDGiaTri.Enabled = isEnabled;
            cmbCTTrangThai.Enabled = isEnabled;
            cmbCTTenNCC.Enabled = isEnabled;
        }
        private void btnCTHDSua_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                SetFieldsEnabled(true); // Kích hoạt các trường để sửa
                btnCTHDSua.Text = "Cập nhật"; // Thay đổi nút thành "Cập nhật"
                isEditing = true; // Đánh dấu là đang sửa
            }
            else
            {
                // Lấy mã nhà cung cấp từ ComboBox
                int maNCC = ((ComboBoxItem)cmbCTTenNCC.SelectedItem)?.Value ?? 0;

                // Kiểm tra mã NCC có hợp lệ không
                if (maNCC <= 0)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Thoát khỏi phương thức nếu mã NCC không hợp lệ
                }

                // Cập nhật thông tin mà không kiểm tra điều kiện
                HopDong hopDong = new HopDong
                {
                    MaHopDong = maHopDong, // Sử dụng giá trị MaHopDong hiện tại
                    TenHopDong = txtCTHDTenHD.Text,
                    MoTa = txtCTHDMoTa.Text,
                    NgayHieuLuc = dtpCTHDNHL.Value,
                    NgayHetHan = dtpCTHDNHH.Value,
                    NgayKy = dtpCTHDNgayKy.Value,
                    NguoiKy = txtCTHDNguoiKy.Text,
                    GiaTri = decimal.TryParse(txtCTHDGiaTri.Text, out decimal giaTri) ? giaTri : 0,
                    TrangThai = cmbCTTrangThai.Text,
                    MaNCC = maNCC // Sử dụng mã NCC đã kiểm tra
                };

                // Gọi phương thức cập nhật
                bll.CapNhatHopDong(hopDong);

                // Hiển thị thông báo thành công
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đặt lại trạng thái form
                SetFieldsEnabled(false);
                btnCTHDSua.Text = "Sửa"; // Đổi lại nút thành "Sửa"
                isEditing = false; // Đánh dấu là không còn sửa
            }
        }
        private void LoadChiTietHopDong()
        {
            DataTable dt = bll.LayChiTietHopDong(maHopDong);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtCTHDMHD.Text = row["MaHopDong"].ToString();
                txtCTHDTenHD.Text = row["TenHopDong"].ToString();
                txtCTHDMoTa.Text = row["MoTa"].ToString();
                dtpCTHDNHL.Value = Convert.ToDateTime(row["NgayHieuLuc"]);
                dtpCTHDNHH.Value = Convert.ToDateTime(row["NgayHetHan"]);
                dtpCTHDNgayKy.Text = row["NgayKy"].ToString();
                txtCTHDNguoiKy.Text = row["NguoiKy"].ToString();
                txtCTHDGiaTri.Text = row["GiaTri"].ToString();
                cmbCTTrangThai.Text = row["TrangThai"].ToString();
                cmbCTTenNCC.Text = row["TenNCC"].ToString();
                cmbCTTrangThai.Items.Add(row["TrangThai"].ToString());
            }
        }

        private void btnCTHDXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bll.XoaHopDong(maHopDong);
                MessageBox.Show("Hợp đồng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCTHDHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Khôi phục lại các giá trị ban đầu
                LoadChiTietHopDong(); // Gọi lại phương thức để tải lại thông tin hợp đồng từ cơ sở dữ liệu

                this.Close();
            }
        }

        void LoadComboBox_TrangThai()
        {
            try
            {
                cmbCTTrangThai.Items.Clear();

                // Thêm các trạng thái cố định vào ComboBox
                cmbCTTrangThai.Items.Add("Đang hoạt động");
                cmbCTTrangThai.Items.Add("Ngừng hoạt động");

                // Chọn trạng thái đầu tiên mặc định
                if (cmbCTTrangThai.Items.Count > 0)
                {
                    cmbCTTrangThai.SelectedIndex = 0; // Chọn "Đang hoạt động" là trạng thái mặc định
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load trạng thái: {ex.Message}");
            }
        }

        private void txtCTHDNCC_TextChanged(object sender, EventArgs e)
        {

        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString() => Text;
        }
        void LoadComboBox_NCC()
        {
            try
            {
                var nccs = bll.LayTatCaNCC();

                cmbCTTenNCC.Items.Clear();

                foreach (var ncc in nccs)
                {
                    cmbCTTenNCC.Items.Add(new ComboBoxItem { Text = ncc.TenNCC, Value = ncc.MaNCC });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách NCC: {ex.Message}");
            }
        }
    }
}
