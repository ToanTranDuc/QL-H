using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmThemNhanVien : Form
    {
        ChucVuBLL chucVuBLL = new ChucVuBLL();
        NhanVien nhanVien = new NhanVien();
        TaiKhoan taiKhoan = new TaiKhoan();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();



        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            ckbBanHang.Enabled = false;
            ckbKhongGH.Enabled = false;
            ckbSanPham.Enabled = false;
            ckbKho.Enabled = false;
            pnlThongTin.Enabled = false;

            nhanVien.Duong_Dan_Anh = null;
        }

        private void btnXacNhanTK_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length < 5 || txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu quá ngắn! Tên đăng nhập > 4 ký tự, Mật khẩu > 5 ký tự !", "Thông báo");
                return;
            }
            if (txtMatKhau.Text != txtXacThucMK.Text)
            {
                MessageBox.Show("Xác thực tài khoản không đúng!", "Thông báo");
                return;
            }

            TaiKhoanBLL tkBLL = new TaiKhoanBLL();
            if (tkBLL.CheckAccountExists(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                return;
            }
            taiKhoan.TenDangNhap = txtTenDangNhap.Text;
            taiKhoan.MatKhau = txtMatKhau.Text;
            pnlThongTin.Enabled = true; // Kích hoạt phần thông tin nhân viên
            pnlTaiKhoan.Enabled = false;

        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu cho combobox Chức vụ
            cbbChucVu.DataSource = chucVuBLL.GetAllChucVu();
            cbbChucVu.DisplayMember = "Ten_ChucVu"; // Tên hiển thị
            cbbChucVu.ValueMember = "ID_ChucVu"; // Giá trị thực tế
            cbbChucVu.SelectedValue = -1;

            // Thêm lựa chọn cho combobox Giới tính và đặt lựa chọn mặc định
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            LoadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các thông tin nhân viên
            if (string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtSoDienThoai.Text) ||
                string.IsNullOrEmpty(txtCCCD.Text) ||
                string.IsNullOrEmpty(dtpNgayCap.Text) ||
                string.IsNullOrEmpty(txtNoiCap.Text) ||
                string.IsNullOrEmpty(dtpNgaySinh.Text) ||
                string.IsNullOrEmpty(cbbChucVu.Text) ||
                string.IsNullOrEmpty(cbbGioiTinh.Text) ||
                string.IsNullOrEmpty(txtQueQuan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên!", "Thông báo");
                return;
            }

            if (nhanVien.Duong_Dan_Anh == null)
            {
                MessageBox.Show("Yêu cầu tải ảnh của nhân viên", "Thông báo");
                return;
            }

            // Điền thông tin cho nhân viên
            nhanVien.Ho_Ten = txtHoTen.Text;
            nhanVien.CCCD = txtCCCD.Text;
            nhanVien.Ngay_Cap = dtpNgayCap.Value;
            nhanVien.Ngay_Sinh = dtpNgaySinh.Value;
            nhanVien.Dia_Chi = txtDiaChi.Text;
            nhanVien.So_Dien_Thoai = txtSoDienThoai.Text;
            nhanVien.Email = txtEmail.Text;
            nhanVien.Gioi_Tinh = cbbGioiTinh.SelectedItem.ToString();
            nhanVien.Que_Quan = txtQueQuan.Text;
            nhanVien.ID_ChucVu = (int)cbbChucVu.SelectedValue;
            nhanVien.Nguoi_Tao = CurrentUser.User.NhanVien.Ho_Ten;
            nhanVien.Ngay_Tao = DateTime.Now;
            nhanVien.Nguoi_Cap_Nhat = CurrentUser.User.NhanVien.Ho_Ten;
            nhanVien.Ngay_Cap_Nhat = DateTime.Now;
            nhanVien.Noi_Cap = txtNoiCap.Text;
            nhanVien.Trang_Thai = "Hoạt động";

            // Phân quyền cho nhân viên
            nhanVien.NhanVienQuyen = new List<NhanVien_Quyen>();
            // Kiểm tra quyền
            if (!rdbNhanVien.Checked && !rdbQuanLy.Checked)
            {
                MessageBox.Show("Yêu cầu chọn quyền cho nhân viên!", "Thông báo");
                return;
            }
            if (rdbQuanLy.Checked)
            {
                nhanVien.NhanVienQuyen.Add(new NhanVien_Quyen { ID_Quyen = 0 }); // Quản trị tối cao
            }
            else if (rdbNhanVien.Checked)
            {
                if (ckbKho.Checked)
                    nhanVien.NhanVienQuyen.Add(new NhanVien_Quyen { ID_Quyen = 1 });
                if (ckbBanHang.Checked)
                    nhanVien.NhanVienQuyen.Add(new NhanVien_Quyen { ID_Quyen = 2 });
                if (ckbSanPham.Checked)
                    nhanVien.NhanVienQuyen.Add(new NhanVien_Quyen { ID_Quyen = 3 });
                if (!nhanVien.NhanVienQuyen.Any())
                {
                    MessageBox.Show("Yêu cầu phần quyền cho nhân viên!", "Thông báo");
                    return;
                }
            }

            try
            {
                NhanVienBLL nvBLL = new NhanVienBLL();
                TaiKhoanBLL tkBLL = new TaiKhoanBLL();
                if (!tkBLL.CheckAccountExists(taiKhoan.TenDangNhap))
                {
                    nhanVien.ID_DangNhap = tkBLL.InsertAccount(taiKhoan); // tao tk mới trả về ID
                }
                int ID_NV = nvBLL.InsertEmployee(nhanVien); // Thêm nhân viên
                MessageBox.Show(ID_NV.ToString());
                if (ID_NV != -1)
                {
                    nhanVienBLL.UpdatePermissions(ID_NV, nhanVien.NhanVienQuyen); //Cấp quyền
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh đã chọn
                    ptbAnh.Image = Image.FromFile(openFileDialog.FileName);
                    // Cập nhật đường dẫn ảnh cho nhân viên
                    nhanVien.Duong_Dan_Anh = File.ReadAllBytes(openFileDialog.FileName);
                }
            }
        }

        private void rdbQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            ckbKhongGH.Checked = true;
            ckbKho.Checked = false;
            ckbBanHang.Checked = false;
            ckbSanPham.Checked = false;
            ckbKho.Enabled = false;
            ckbBanHang.Enabled = false;
            ckbSanPham.Enabled = false;
        }

        private void rdbNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            ckbKhongGH.Checked = false;
            ckbKho.Enabled = true;
            ckbBanHang.Enabled = true;
            ckbSanPham.Enabled = true;
        }
    }
}