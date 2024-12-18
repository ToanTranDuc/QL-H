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
            LoadComboBox_NCC();

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

                cmbTTenNCC.Items.Clear();

                foreach (var ncc in nccs)
                {
                    cmbTTenNCC.Items.Add(new ComboBoxItem { Text = ncc.TenNCC, Value = ncc.MaNCC });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load danh sách NCC: {ex.Message}");
            }
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
                cmbTTrangThai.Text = originalNCC;
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
            // Lấy thông tin từ các trường nhập liệu
            string tenHopDong = txtCTHDTenHD.Text;
            string moTa = txtCTHDMoTa.Text;
            DateTime ngayKy = dtpCTHDNgayKy.Value;
            string nguoiKy = txtCTHDNguoiKy.Text;
            DateTime ngayHieuLuc = dtpCTHDNHL.Value;
            DateTime ngayHetHan = dtpCTHDNHH.Value;
            string tenNCC = cmbTTenNCC.Text.Trim();

            if (!decimal.TryParse(txtCTHDGiaTri.Text, out decimal giaTri))
            {
                MessageBox.Show("Giá trị không hợp lệ.");
                return;
            }

            // Kiểm tra nếu ComboBox có giá trị được chọn
            if (cmbTTenNCC.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.");
                return;
            }
            int maNCC = sanPhamBLL.LayMaNCCTheoTen(tenNCC);
            

            // Tạo đối tượng hợp đồng
            HopDong hopDong = new HopDong
            {
                TenHopDong = tenHopDong,
                MoTa = moTa,
                NgayKy = ngayKy,
                NguoiKy = nguoiKy,
                NgayHieuLuc = ngayHieuLuc,
                NgayHetHan = ngayHetHan,
                GiaTri = giaTri,
                TrangThai = "Đang hoạt động", // Giá trị mặc định hoặc tùy chỉnh
                MaNCC = maNCC
            };

            try
            {
                // Gọi phương thức BLL để lưu hợp đồng
                bll.ThemHopDong(hopDong);

                // Thông báo cho người dùng
                MessageBox.Show("Hợp đồng đã được lưu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
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
