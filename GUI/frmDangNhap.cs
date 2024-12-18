using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public void ResetFields()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Thực hiện quá trình đăng nhập
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            TaiKhoanBLL bll = new TaiKhoanBLL();
            try
            {
                TaiKhoan user = bll.CheckLogin(username, password);
                if (user != null)
                {
                    MessageBox.Show($"Đăng nhập thành công! Chào mừng, {user.NhanVien.Ho_Ten}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CurrentUser.User = user;
                    CurrentUser.TenChucVu = user.NhanVien.ChucVu.Ten_ChucVu;

                    frmTrangChu frm = new frmTrangChu();
                    frm.Show(); // Hiển thị form chính
                    this.Hide(); // Ẩn form đăng nhập
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void lblEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                // Hiện mật khẩu
                txtPassword.UseSystemPasswordChar = false;
                lblEye.Text = "Ẩn"; // Thay đổi văn bản nút
            }
            else
            {
                // Ẩn mật khẩu
                txtPassword.UseSystemPasswordChar = true;
                lblEye.Text = "Hiện"; // Thay đổi văn bản nút
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            ResetFields();
        }
    }
}
