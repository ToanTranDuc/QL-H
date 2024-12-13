using BLL;
using DTO;
using GUI;
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
    public partial class frmTrangChu : Form
    {
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private TaiKhoan User = new TaiKhoan();

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien form = new frmNhanVien();
            form.Show();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            CurrentUser.User.NhanVien.NhanVienQuyen = taiKhoanBLL.GetUserPermissions(CurrentUser.User.NhanVien.ID_NhanVien);
            User = CurrentUser.User;
            lblChaoNguoiDung.Text = $"Xin chào: {User.NhanVien.Ho_Ten}\nChức vụ: {CurrentUser.TenChucVu}";
            if (User.NhanVien.NhanVienQuyen != null)
            {
                var danhSachQuyen = User.NhanVien.NhanVienQuyen.Select(q => q.Quyen.TenQuyen).ToList();
                if (danhSachQuyen.Contains("Quản trị tối cao"))
                {
                    return;
                }
                else
                {
                    //Phan quyen han nhan vien
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            CurrentUser.User = null;

            frmDangNhap loginForm = new frmDangNhap();
            loginForm.Show();
            this.Close();
        }
    }
}
