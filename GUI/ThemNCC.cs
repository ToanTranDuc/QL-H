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

namespace GUI
{
    public partial class ThemNCC : Form

    {
        private bool isDataChanged = false;
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        public ThemNCC()
        {
            InitializeComponent();
            LoadComboBox_TrangThai();
        }

        private void btnTDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadComboBox_TrangThai()
        {
            try
            {
                var trangThais = sanPhamBLL.LayTrangThaiNCC();
                cmbTTrangThai.Items.Clear();

                // Sử dụng HashSet để lưu trạng thái độc nhất
                HashSet<string> uniqueStatuses = new HashSet<string>();

                foreach (var trangThai in trangThais)
                {
                    // Kiểm tra nếu trạng thái chưa tồn tại trong HashSet
                    if (uniqueStatuses.Add(trangThai.TrangThai))
                    {
                        cmbTTrangThai.Items.Add(trangThai.TrangThai);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load trạng thái: {ex.Message}");
            }
        }
        private void btnTLuu_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTTenNCC.Text.Trim();
            string mst = txtTMST.Text.Trim();
            string dienThoai = txtTDienThoai.Text.Trim();
            string email = txtTEmail.Text.Trim();
            string diaChi = txtTDiaChi.Text.Trim();
            string nguoiTao = txtTNguoiTao.Text.Trim();
            DateTime ngayCapNhat = dtpTNgayCapNhat.Value;
            string nguoiCapNhat = txtTNguoiCapNhat.Text.Trim();
            DateTime ngayTao = dtpTNgayTao.Value; 
            string trangThai = cmbTTrangThai.Text.Trim();

            if (string.IsNullOrEmpty(tenNCC) || string.IsNullOrEmpty(mst) ||
            string.IsNullOrEmpty(dienThoai) || string.IsNullOrEmpty(email) ||
            string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(nguoiTao))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            NCC ncc = new NCC
            {
                TenNCC = tenNCC,
                MST = mst,
                DienThoai = dienThoai,
                Email = email,
                DiaChi = diaChi,
                NguoiCapNhat = nguoiCapNhat,
                NgayCapNhat = ngayCapNhat,
                NguoiTao = nguoiTao,
                NgayTao = dtpTNgayTao.Value,
                TrangThai = trangThai
            };

            try
            {
                sanPhamBLL.ThemNCC(ncc);
                MessageBox.Show("Lưu thành công!");

                if (InforNCC.Instance != null)
                {
                    InforNCC.Instance.LoadNCCData();
                }

                isDataChanged = false; 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công: " + ex.Message);
            }
        }

        private void txtTTenNCC_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
        }

        private void txtTMST_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
        }

        private void dtpTNgayCapNhat_ValueChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
        }

        private void txtTNguoiCapNhat_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
        }

        private void txtTTrangThai_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
        }

        private void txtTDiaChi_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
        }

        private void txtTEmail_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
        }
    }
}
