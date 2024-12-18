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
        bool sidebarExpand;
        bool sanPhamCollap;
        bool nhanVienCollap;
        bool khoCollap;
        bool nccCollap;
        private Form currentFormChild;
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private TaiKhoan User = new TaiKhoan();



        public frmTrangChu()
        {
            InitializeComponent();
            CurrentUser.User.NhanVien.NhanVienQuyen = taiKhoanBLL.GetUserPermissions(CurrentUser.User.NhanVien.ID_NhanVien);    
        }

        private void OpenChildForm(Form childForm)
        {
            btnDanhMucSanPham.Enabled = false;
            btnDanhSachSanPham.Enabled = false;
            btnDMChucVu.Enabled = false;
            btnDSNhanVien.Enabled = false;

            btnTaiKhoan.Enabled = false;
            btnTonKho.Enabled = false;
            btnBanHang.Enabled = false;
            btnNhapKho.Enabled = false;
            btnDonDatHang.Enabled = false;
            btnXuatKho.Enabled = false;
            btnNCC.Enabled = false;
            btnHopDong.Enabled = false;

            if (currentFormChild != null)
            {
                currentFormChild.Close(); // Đóng form hiện tại nếu có
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnDanhMucSanPham.Enabled = true;
            btnDanhSachSanPham.Enabled = true;
            btnDMChucVu.Enabled = true;
            btnDSNhanVien.Enabled = true;
            btnTaiKhoan.Enabled = true;
            btnTonKho.Enabled = true;
            btnBanHang.Enabled = true;
            btnNhapKho.Enabled = true;
            btnDonDatHang.Enabled = true;
            btnXuatKho.Enabled = true;
            btnNCC.Enabled = true;
            btnHopDong.Enabled = true;
            LoadQuyen();

        }


        private void LoadQuyen()
        {
            if (User.NhanVien.NhanVienQuyen != null)
            {
                var danhSachQuyen = User.NhanVien.NhanVienQuyen.Select(q => q.Quyen.ID_Quyen).ToList();
                if (danhSachQuyen.Contains(1))//Quan ly
                {
                    pnlBanHang.Visible = true;
                    NCCContainer.Visible = true;
                    SanPhamContainer.Visible = true;
                    NhanVienContainer.Visible = true;
                    KhoContainer.Visible = true;

                    btnDSNhanVien.Enabled = true;
                    btnTaiKhoan.Enabled = true;
                    btnDMChucVu.Enabled = true;

                    btnDanhMucSanPham.Enabled = true;
                    btnDanhSachSanPham.Enabled = true;

                    btnNhapKho.Enabled= true;
                    btnXuatKho.Enabled = true;
                    btnDonDatHang.Enabled = true;
                    btnTonKho.Enabled = true;

                    btnNCC.Enabled = true;
                    btnHopDong.Enabled = true;
                }
                else
                {
                    pnlBanHang.Visible = false;
                    NCCContainer.Visible = false;
                    SanPhamContainer.Visible = false;
                    KhoContainer.Visible = false;

                    NhanVienContainer.Visible = true;
                    btnDSNhanVien.Enabled = false;
                    btnTaiKhoan.Enabled = true;
                    btnDMChucVu.Enabled = false;

                    btnDanhMucSanPham.Enabled = false;
                    btnDanhSachSanPham.Enabled = false;
                    btnDMChucVu.Enabled = false;
                    btnDSNhanVien.Enabled = false;
                    btnTonKho.Enabled = false;
                    btnXuatKho.Enabled = false;
                    btnNhapKho.Enabled = false;
                    btnDonDatHang.Enabled = false;
                }
                if (danhSachQuyen.Contains(2))//Kho
                {
                    btnTonKho.Enabled = true;
                    btnXuatKho.Enabled = true;
                    btnNhapKho.Enabled = true;
                    btnDonDatHang.Enabled = true;
                }
                if (danhSachQuyen.Contains(3))//Ban Hang
                {
                    pnlBanHang.Visible = true;
                }
                if (danhSachQuyen.Contains(4))//SanPham
                {
                    SanPhamContainer.Visible = true;

                    btnDanhMucSanPham.Enabled = true;
                    btnDanhSachSanPham.Enabled = true;
                }
            }
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            User = CurrentUser.User;
            //Phan quyen
            //lblChaoMung.Text = $"Xin chào: {User.NhanVien.Ho_Ten}\nChức vụ: {CurrentUser.TenChucVu}";
            LoadQuyen();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                }
            }
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void SanPhamTimer_Tick(object sender, EventArgs e)
        {
            if (sanPhamCollap)
            {
                SanPhamContainer.Height += 10;
                if (SanPhamContainer.Height == SanPhamContainer.MaximumSize.Height)
                {
                    sanPhamCollap = false;
                    SanPhamTimer.Stop();
                }

            }
            else
            {
                SanPhamContainer.Height -= 10;
                if (SanPhamContainer.Height == SanPhamContainer.MinimumSize.Height)
                {
                    sanPhamCollap = true;
                    SanPhamTimer.Stop();
                }
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SanPhamTimer.Start();

        }

        private void NhanVienTimer_Tick(object sender, EventArgs e)
        {
            if (nhanVienCollap)
            {
                NhanVienContainer.Height += 10;
                if (NhanVienContainer.Height == NhanVienContainer.MaximumSize.Height)
                {
                    nhanVienCollap = false;
                    NhanVienTimer.Stop();
                }

            }
            else
            {
                NhanVienContainer.Height -= 10;
                if (NhanVienContainer.Height == NhanVienContainer.MinimumSize.Height)
                {
                    nhanVienCollap = true;
                    NhanVienTimer.Stop();
                }
            }
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            NhanVienTimer.Start();

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            KhoTimer.Start();

        }
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            NCCTimer.Start();
        }
        private void KhoTimer_Tick(object sender, EventArgs e)
        {
            if (khoCollap)
            {
                KhoContainer.Height += 10;
                if (KhoContainer.Height == KhoContainer.MaximumSize.Height)
                {
                    khoCollap = false;
                    KhoTimer.Stop();
                }
            }
            else
            {
                KhoContainer.Height -= 10;
                if (KhoContainer.Height == KhoContainer.MinimumSize.Height)
                {
                    khoCollap = true;
                    KhoTimer.Stop();
                }
            }
        }
        private void NCCTimer_Tick(object sender, EventArgs e)
        {
            if (nccCollap)
            {
                NCCContainer.Height += 10;
                if(NCCContainer.Height == NCCContainer.MaximumSize.Height)
                {
                    nccCollap = false;
                    NCCTimer.Stop();
                }
            }
            else
            {
                NCCContainer.Height -= 10;
                if(NCCContainer.Height == NCCContainer.MinimumSize.Height)
                {
                    nccCollap= true;
                    NCCTimer.Stop();
                }
            }
        }
        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            CurrentUser.User = null;
            this.Hide();
            frmDangNhap loginForm = Application.OpenForms.OfType<frmDangNhap>().FirstOrDefault();

            if (loginForm == null)
            {
                loginForm = new frmDangNhap();
            }
            else
            {
                loginForm.ResetFields();
            }
            loginForm.Show();
            loginForm.BringToFront(); 
            this.Close();
        }

        private void btnDanhMucSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhMucSP());
            lblTitle.Text = btnDanhMucSanPham.Text;
        }

        private void btnDanhSachSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DSSanPham());
            lblTitle.Text = btnDanhSachSanPham.Text;
        }

        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhSachNhanVien());
            lblTitle.Text = btnDSNhanVien.Text;
        }

        private void btnDMChucVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChucVu());
            lblTitle.Text = btnDMChucVu.Text;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            var danhSachQuyen = User.NhanVien.NhanVienQuyen.Select(q => q.Quyen.TenQuyen).ToList();
            if (danhSachQuyen.Contains("Quản trị tối cao"))
            {
                OpenChildForm(new frmTaiKhoan());
                lblTitle.Text = btnTaiKhoan.Text;
                return;
            }
            else
            {
                OpenChildForm(new frmTaiKhoanCaNhan(CurrentUser.User.NhanVien.ID_NhanVien));
                lblTitle.Text = "Trang tài khoản cá nhân";
                return;
            }

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhapKho());
            lblTitle.Text = btnNhapKho.Text;
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XuatKho());
            lblTitle.Text = btnXuatKho.Text;
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TonKho());
            lblTitle.Text = btnTonKho.Text;
        }

        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonDatHang());
            lblTitle.Text = btnDonDatHang.Text;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fHoaDonBan());
            lblTitle.Text = btnBanHang.Text;
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InforNCC());
            lblTitle.Text = btnNCC.Text;
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Contract());
            lblTitle.Text = btnHopDong.Text;
        }

        private void lblMENU_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                lblTitle.Text = "Trang chủ";
            }
        }
    }
}
