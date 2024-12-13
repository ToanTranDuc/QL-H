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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            TaiKhoanBLL bll = new TaiKhoanBLL();
            try
            {
                TaiKhoan user = bll.CheckLogin(username, password);
                if (user != null)
                {
                    MessageBox.Show($"Đăng nhập thành công! Chào mừng, {user.NhanVien.Ho_Ten}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CurrentUser.User = user; // Lưu thông tin người dùng vào CurrentUser
                    CurrentUser.TenChucVu = user.NhanVien.ChucVu.Ten_ChucVu; // Lưu thông tin chức vụ
                    frmTrangChu frm = new frmTrangChu();
                    frm.ShowDialog();
                    this.Close();
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
            this.Close();
        }
    }
}
