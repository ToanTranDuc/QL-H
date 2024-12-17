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
    public partial class ThemHopDong : Form
    {
        private string originalGiaTri;
        private string originalMHD;
        private string originalNCC;
        private string originalMoTa;
        private string originalNguoiKy;
        private string originalTenHD;
        private string originalTrangThai;
        private string originalDNHL;
        private string originalDNHH;
        private string originalNgayKy;
        private SanPhamBLL sanPhamBLL = new SanPhamBLL();
        private SanPhamBLL bll = new SanPhamBLL();
        private int maHopDong;
        public ThemHopDong()
        {
            InitializeComponent();
            LoadComboBox_TrangThai();
        }

        private void btnCTDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCTHDHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Khôi phục lại các giá trị ban đầu
                txtCTHDGiaTri.Text = originalGiaTri;
                txtCTHDMHD.Text = originalMHD;
                txtCTHDMoTa.Text = originalMoTa;
                txtCTHDNCC.Text = originalNCC;
                txtCTHDNguoiKy.Text = originalNguoiKy;
                txtCTHDTenHD.Text = originalTenHD;
                cmbTTrangThai.Text = originalTrangThai;
                dtpCTHDNHL.Text = originalDNHL;
                dtpCTHDNHH.Text = originalDNHH;
                dtpCTHDNgayKy.Text = originalNgayKy;
                
                this.Close();
            }
        }

        private void btnTHD_Click(object sender, EventArgs e)
        {
            // Lấy mã hợp đồng từ textbox
            int maHopDong;
            if (!int.TryParse(txtCTHDMHD.Text, out maHopDong) || maHopDong <= 0)
            {
                MessageBox.Show("Mã hợp đồng không hợp lệ.");
                return;
            }

            // Các thông tin khác
            string tenHopDong = txtCTHDTenHD.Text;
            string moTa = txtCTHDMoTa.Text;
            DateTime ngayKy = dtpCTHDNgayKy.Value;
            string nguoiKy = txtCTHDNguoiKy.Text;
            DateTime ngayHieuLuc = dtpCTHDNHL.Value;
            DateTime ngayHetHan = dtpCTHDNHH.Value;
            decimal giaTri = decimal.Parse(txtCTHDGiaTri.Text);
            string trangThai = cmbTTrangThai.Text;
            string tenNhaCungCap = txtCTHDNCC.Text;

            // Tạo đối tượng hợp đồng
            HopDong hopDong = new HopDong
            {
                MaHopDong = maHopDong, // Gán mã hợp đồng
                TenHopDong = tenHopDong,
                MoTa = moTa,
                NgayKy = ngayKy,
                NguoiKy = nguoiKy,
                NgayHieuLuc = ngayHieuLuc,
                NgayHetHan = ngayHetHan,
                GiaTri = giaTri,
                TrangThai = trangThai
            };

            try
            {
                // Gọi phương thức BLL để lưu hợp đồng
                bll.ThemHopDong(hopDong, tenNhaCungCap);

                // Thông báo cho người dùng
                MessageBox.Show("Hợp đồng đã được lưu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                // Thông báo lỗi cho người dùng
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        void LoadComboBox_TrangThai()
        {
            try
            {
                cmbTTrangThai.Items.Clear();

                // Thêm các trạng thái cố định vào ComboBox
                cmbTTrangThai.Items.Add("Đang hoạt động");
                cmbTTrangThai.Items.Add("Ngừng hoạt động");

                // Chọn trạng thái đầu tiên mặc định
                if (cmbTTrangThai.Items.Count > 0)
                {
                    cmbTTrangThai.SelectedIndex = 0; // Chọn "Đang hoạt động" là trạng thái mặc định
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load trạng thái: {ex.Message}");
            }
        }
    }
}
