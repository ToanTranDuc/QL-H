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
    public partial class frmTaiKhoanCaNhan : Form
    {
        private NhanVien nhanVien = new NhanVien();
        private NhanVienBLL nvBLL = new NhanVienBLL();
        public frmTaiKhoanCaNhan(int ID)
        {
            InitializeComponent();
            nhanVien.ID_NhanVien = ID;
        }

        private void LoadForm()
        {
            nhanVien = nvBLL.GetNhanVien(nhanVien.ID_NhanVien);
            //Cài form xem
            txtIDNhanVien.Enabled = false;
            txtHoTen.Enabled = false;
            txtCCCD.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            txtQueQuan.Enabled = false;
            txtNguoiCapNhat.Enabled = false;
            dtpNgayCap.Enabled = false;
            txtNoiCap.Enabled = false;
            dtpNgayTao.Enabled = false;
            txtNguoiTao.Enabled = false;
            cbbChucVu.Enabled = false;
            cbbGioiTinh.Enabled = false;
            dtpNgayCapNhat.Enabled = false;
            pnlDoiMK.Enabled = false;
            pnlNgay.Enabled = true;
            pnlThongTin.Enabled = true;

            txtMatKhauXacNhan.Text = "";
            txtMatKhauMoi.Text = "";
            txtMatKhauCu.Text = "";
            btnDoiMatKhau.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = false;
            btnTaiAnh.Enabled = false;

            cbbGioiTinh.SelectedIndex = 0; // Chọn "Nam" là mặc định
            if (nhanVien != null)
            {
                txtIDNhanVien.Text = nhanVien.ID_NhanVien.ToString();
                txtHoTen.Text = nhanVien.Ho_Ten;
                txtCCCD.Text = nhanVien.CCCD;
                txtDiaChi.Text = nhanVien.Dia_Chi;
                dtpNgaySinh.Value = nhanVien.Ngay_Sinh;
                txtTaiKhoan.Text = nhanVien.TaiKhoan.TenDangNhap;
                txtSoDienThoai.Text = nhanVien.So_Dien_Thoai;
                txtEmail.Text = nhanVien.Email;
                txtQueQuan.Text = nhanVien.Que_Quan;
                txtNguoiCapNhat.Text = nhanVien.Nguoi_Cap_Nhat;
                dtpNgayCap.Value = nhanVien.Ngay_Cap;
                txtNoiCap.Text = nhanVien.Noi_Cap;
                dtpNgayTao.Value = nhanVien.Ngay_Tao;
                txtNguoiTao.Text = nhanVien.Nguoi_Tao;
                dtpNgayCapNhat.Value = nhanVien.Ngay_Cap_Nhat;
                cbbGioiTinh.SelectedItem = nhanVien.Gioi_Tinh;
                cbbChucVu.SelectedValue = nhanVien.ID_ChucVu;

                if (nhanVien.Duong_Dan_Anh != null && nhanVien.Duong_Dan_Anh.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(nhanVien.Duong_Dan_Anh))
                    {
                        ptbAnh.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        private void frmTaiKhoanCaNhan_Load(object sender, EventArgs e)
        {
            ChucVuBLL chucVuBLL = new ChucVuBLL();
            cbbChucVu.DataSource = chucVuBLL.GetAllChucVu();
            cbbChucVu.DisplayMember = "Ten_ChucVu";
            cbbChucVu.ValueMember = "ID_ChucVu";

            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            LoadForm();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin nhân viên từ các trường nhập liệu
            nhanVien.Ho_Ten = txtHoTen.Text;
            nhanVien.CCCD = txtCCCD.Text;
            nhanVien.Ngay_Sinh = dtpNgaySinh.Value;
            nhanVien.Dia_Chi = txtDiaChi.Text;
            nhanVien.So_Dien_Thoai = txtSoDienThoai.Text;
            nhanVien.Email = txtEmail.Text;
            nhanVien.Que_Quan = txtQueQuan.Text;
            nhanVien.Nguoi_Cap_Nhat = CurrentUser.User.NhanVien.Ho_Ten;
            nhanVien.Ngay_Cap_Nhat = DateTime.Now;
            nhanVien.Noi_Cap = txtNoiCap.Text;
            nhanVien.Gioi_Tinh = cbbGioiTinh.SelectedItem.ToString();

            try
            {
                // Gọi phương thức cập nhật
                if (nvBLL.UpdateEmployee(nhanVien))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cài form sửa
            txtHoTen.Enabled = true;
            txtCCCD.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtQueQuan.Enabled = true;
            dtpNgayCap.Enabled = true;
            txtNoiCap.Enabled = true;
            cbbGioiTinh.Enabled = true;

            btnDoiMatKhau.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = true;
            btnTaiAnh.Enabled = true;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            pnlThongTin.Enabled = false;
            pnlNgay.Enabled = false;
            pnlDoiMK.Enabled = true;
            btnDoiMatKhau.Enabled = false;
            btnSua.Enabled = false;
            txtMatKhauCu.Focus();

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

        private void btnHuyDMK_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnXacNhanDoiMK_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            TaiKhoanBLL tkBLL = new TaiKhoanBLL();
            tk.ID_DangNhap = CurrentUser.User.ID_DangNhap;
            tk.TenDangNhap = CurrentUser.User.TenDangNhap;
            if (nhanVien.TaiKhoan.MatKhau == txtMatKhauCu.Text)
            {
                tk.MatKhau = txtMatKhauXacNhan.Text;
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo!");
                return;
            }
            if (txtMatKhauMoi.Text != txtMatKhauXacNhan.Text)
            {
                MessageBox.Show("Xác nhận mật không không trùng khớp!", "Thông báo!");
                return;
            }

            if (tkBLL.UpdateTaiKhoan(tk))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!");
                LoadForm();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo!");
            }
        }
    }
}
