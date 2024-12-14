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
        private Form currentFormChild;
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private TaiKhoan User = new TaiKhoan();

        public frmTrangChu()
        {
            InitializeComponent();
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
            btnNhapKho.Enabled=false;
            btnDonDatHang.Enabled = false;
            btnXuatKho.Enabled = false;

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
        }
        
       

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            CurrentUser.User.NhanVien.NhanVienQuyen = taiKhoanBLL.GetUserPermissions(CurrentUser.User.NhanVien.ID_NhanVien);
            User = CurrentUser.User;
            //Phan quyen
            lblChaoMung.Text = $"Xin chào: {User.NhanVien.Ho_Ten}\nChức vụ: {CurrentUser.TenChucVu}";
            if (User.NhanVien.NhanVienQuyen != null)
            {
                var danhSachQuyen = User.NhanVien.NhanVienQuyen.Select(q => q.Quyen.TenQuyen).ToList();
                if (danhSachQuyen.Contains("Quản trị tối cao"))
                {
                    return;
                }
                else
                {
                    btnDanhMucSanPham.Enabled = false;
                    btnDanhSachSanPham.Enabled = false ;
                    btnDMChucVu.Enabled = false ;
                    btnDSNhanVien.Enabled = false ;
                    btnTonKho.Enabled = false ;
                    btnXuatKho.Enabled = false;
                    btnNhapKho.Enabled = false ;
                    btnDonDatHang.Enabled = false ;
                    btnBanHang.Enabled = false ;
                    btnThongKe.Enabled = false ;
                }
                if (danhSachQuyen.Contains("Kho"))
                {
                    btnTonKho.Enabled = true ;
                    btnXuatKho.Enabled=true ;
                    btnNhapKho.Enabled=true;
                    btnDonDatHang.Enabled=true ;
                }
                if (danhSachQuyen.Contains("Bán hàng"))
                {
                    btnBanHang.Enabled = true ;
                }
                if (danhSachQuyen.Contains("Sản phẩm"))
                {
                    btnDanhMucSanPham.Enabled = true;
                    btnDanhSachSanPham.Enabled = true;
                }
            }
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
            if(sanPhamCollap)
            {
                SanPhamContainer.Height += 10;
                if(SanPhamContainer.Height == SanPhamContainer.MaximumSize.Height)
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

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            CurrentUser.User = null;
            this.Hide();
            frmDangNhap loginForm = new frmDangNhap();
            loginForm.ShowDialog(); 
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
            lblTitle.Text=btnDSNhanVien.Text;
        }

        private void btnDMChucVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChucVu());
            lblTitle.Text=btnDMChucVu.Text;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiKhoan());
            lblTitle.Text = btnTaiKhoan.Text;
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

        private void btnNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InforNCC());
            lblTitle.Text = btnNCC.Text;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fHoaDonBan());
            lblTitle.Text = btnBanHang.Text;
        }
    }
}
