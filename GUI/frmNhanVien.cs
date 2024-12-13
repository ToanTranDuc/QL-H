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
    public partial class frmNhanVien : Form
    {
        private Form currentFormChild;
        List<int> danhSachQuyen = CurrentUser.User.NhanVien.NhanVienQuyen.Select(q => q.Quyen.ID_Quyen).ToList();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            btnNhanVien.Enabled = false;
            btnChucVu.Enabled = false;
            btnTaiKhoan.Enabled = false;

            if (currentFormChild != null)
            {
                currentFormChild.Close(); // Đóng form hiện tại nếu có
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnNhanVien.Enabled = true;
            btnChucVu.Enabled = true;
            btnTaiKhoan.Enabled = true;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhSachNhanVien());
            lblTitle.Text = btnNhanVien.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhSachNhanVien());
            lblTitle.Text = btnNhanVien.Text;
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChucVu());
            lblTitle.Text = btnChucVu.Text;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (danhSachQuyen.Contains(0))
            {
                OpenChildForm(new frmTaiKhoan());
                lblTitle.Text = btnTaiKhoan.Text;
            }
            else
            {
                OpenChildForm(new frmTaiKhoanCaNhan(CurrentUser.User.NhanVien.ID_NhanVien));
                lblTitle.Text = "Thông tin tài khoản cá nhân";
            }

        }
    }
}
