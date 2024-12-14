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
    public partial class frmTaiKhoan : Form
    {
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private List<TaiKhoan> taiKhoanList;
        private TaiKhoan selectedTaiKhoan = new TaiKhoan();

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            txtID_DangNhap.ReadOnly = true;
            txtMatKhau.ReadOnly = true;
            txtTenDangNhap.ReadOnly = true;
            txtTenNguoiDung.ReadOnly = true;
            cbbTrangThai.Enabled = false;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;

        }
        private void LoadDataToGrid(List<TaiKhoan> taiKhoans)
        {
            dtgMain.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView
            foreach (var tk in taiKhoans)
            {
                dtgMain.Rows.Add(
                    tk.ID_DangNhap,
                    tk.TenDangNhap,
                    tk.NhanVien.ID_NhanVien,
                    tk.NhanVien.Ho_Ten,
                    tk.MatKhau,
                    tk.NhanVien.Trang_Thai
                );
            }
            lblTongSo.Text = "Tổng số: " + taiKhoans.Count + " bản ghi";
            LoadForm();
        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            taiKhoanList = taiKhoanBLL.GetAllAccounts();
            LoadDataToGrid(taiKhoanList);
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm
            var ketQuaTimKiem = taiKhoanList
                .Where(tk => tk.TenDangNhap.ToLower().Contains(tuKhoa) ||
                              tk.NhanVien.Ho_Ten.ToLower().Contains(tuKhoa) ||
                              tk.NhanVien.Trang_Thai.ToLower().Contains(tuKhoa) ||
                              tk.ID_DangNhap.ToString() == tuKhoa)
                .ToList(); // Tìm kiếm trong danh sách

            dtgMain.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView

            if (ketQuaTimKiem.Count > 0)
            {
                // Nếu có kết quả tìm kiếm, hiển thị chúng
                LoadDataToGrid(ketQuaTimKiem);
            }
            else
            {
                // Nếu không có kết quả tìm kiếm
                MessageBox.Show("Không tìm thấy tài khoản nào với từ khóa: " + txtTuKhoa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTongSo.Text = "Tổng số: 0 bản ghi"; // Cập nhật tổng số
            }
        }

        private void ClearFields()
        {
            txtID_DangNhap.Text = string.Empty;
            txtTenDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtTenNguoiDung.Text = string.Empty;
            cbbTrangThai.SelectedIndex = -1;
            ckbBanHang.Checked = false;
            ckbKho.Checked = false;
            ckbKhongGH.Checked = false;
            ckbSanPham.Checked = false;
            rdbNhanVien.Checked = false;
            rdbQuanLy.Checked = false;
        }
        private void dtgMain_SelectionChanged(object sender, EventArgs e)
        {
            selectedTaiKhoan = new TaiKhoan();
            LoadForm();
            if (dtgMain.SelectedRows.Count == 0 || dtgMain.CurrentRow == null || dtgMain.CurrentRow.Index < 0)
            {
                ClearFields();
                return;
            }

            //Mở chức khóa chưc năng sửa 
            btnSua.Enabled = true;
            var cellValue = Convert.ToInt32(dtgMain.CurrentRow.Cells["ID"].Value);

            TaiKhoan taiKhoan = taiKhoanList.FirstOrDefault(tk => tk.ID_DangNhap == cellValue);



            if (taiKhoan != null)
            {
                // Gán dữ liệu vào các ô
                txtID_DangNhap.Text = taiKhoan.ID_DangNhap.ToString();
                txtTenDangNhap.Text = taiKhoan.TenDangNhap;
                txtMatKhau.Text = taiKhoan.MatKhau;
                txtTenNguoiDung.Text = taiKhoan.NhanVien.Ho_Ten;
                cbbTrangThai.Text = taiKhoan.NhanVien.Trang_Thai;
                selectedTaiKhoan.NhanVien = new NhanVien();
                selectedTaiKhoan.NhanVien.ID_NhanVien = taiKhoan.NhanVien.ID_NhanVien; //chon id nhan vien
                taiKhoan.NhanVien.NhanVienQuyen = taiKhoanBLL.GetUserPermissions(selectedTaiKhoan.NhanVien.ID_NhanVien);
                selectedTaiKhoan.ID_DangNhap = taiKhoan.ID_DangNhap;
                if (taiKhoan.NhanVien.NhanVienQuyen != null)
                {
                    var danhSachQuyen = taiKhoan.NhanVien.NhanVienQuyen.Select(q => q.Quyen.TenQuyen).ToList();
                    if (danhSachQuyen.Contains("Quản trị tối cao"))
                    {
                        rdbQuanLy.Checked = true;
                        rdbQuanLy.Enabled = true;
                        rdbNhanVien.Enabled = false;
                        ckbKhongGH.Checked = true;
                        ckbKho.Checked = false;
                        ckbBanHang.Checked = false;
                        ckbSanPham.Checked = false;
                        ckbKho.Enabled = false;
                        ckbBanHang.Enabled = false;
                        ckbSanPham.Enabled = false;
                    }
                    else
                    {
                        rdbNhanVien.Checked = true;
                        rdbQuanLy.Enabled = false;
                        rdbNhanVien.Enabled = true;
                        ckbKhongGH.Checked = false;
                        ckbKhongGH.Enabled = false;
                        ckbKho.Enabled = false;
                        ckbBanHang.Enabled = false;
                        ckbSanPham.Enabled = false;

                        ckbKho.Checked = danhSachQuyen.Contains("Kho");
                        ckbBanHang.Checked = danhSachQuyen.Contains("Bán hàng");
                        ckbSanPham.Checked = danhSachQuyen.Contains("Sản phẩm");
                    }
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnGhi.Enabled = true;
            txtMatKhau.Enabled = true;
            txtTenDangNhap.Enabled = true;
            rdbNhanVien.Enabled = true;
            rdbQuanLy.Enabled = true;
            if (rdbNhanVien.Checked)
            {
                ckbBanHang.Enabled = true;
                ckbKho.Enabled = true;
                ckbSanPham.Enabled = true;
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private List<string> GetSelectedPermissions()
        {
            List<string> selectedPermissions = new List<string>();

            if (ckbKho.Checked)
                selectedPermissions.Add("Kho");
            if (ckbBanHang.Checked)
                selectedPermissions.Add("Bán hàng");
            if (ckbSanPham.Checked)
                selectedPermissions.Add("Sản phẩm");
            if (ckbKhongGH.Checked)
                selectedPermissions.Add("Không Ghi Nhận");

            // Thêm quyền từ radio button
            if (rdbQuanLy.Checked)
                selectedPermissions.Add("Quản trị tối cao");
            else if (rdbNhanVien.Checked)
                selectedPermissions.Add("Nhân viên");

            return selectedPermissions;
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            selectedTaiKhoan.TenDangNhap = txtTenDangNhap.Text;
            selectedTaiKhoan.MatKhau = txtMatKhau.Text;
            taiKhoanBLL.UpdateTaiKhoan(selectedTaiKhoan);

            //Update quyền
            NhanVienBLL nv = new NhanVienBLL();
            NhanVien nhanVien = new NhanVien();
            nhanVien.NhanVienQuyen = new List<NhanVien_Quyen>();
            nhanVien.ID_NhanVien = selectedTaiKhoan.NhanVien.ID_NhanVien;
            if (rdbQuanLy.Checked)
            {
                nhanVien.NhanVienQuyen.Add(new NhanVien_Quyen { ID_Quyen = 1 }); // Quản trị tối cao
            }
            else if (rdbNhanVien.Checked)
            {
                if (ckbKho.Checked)
                    nhanVien.NhanVienQuyen.Add(new NhanVien_Quyen { ID_Quyen = 2 });
                if (ckbBanHang.Checked)
                    nhanVien.NhanVienQuyen.Add(new NhanVien_Quyen { ID_Quyen = 3 });
                if (ckbSanPham.Checked)
                    nhanVien.NhanVienQuyen.Add(new NhanVien_Quyen { ID_Quyen = 4 });

                // Kiểm tra xem có quyền nào được chọn không
                if (!nhanVien.NhanVienQuyen.Any())
                {
                    MessageBox.Show("Yêu cầu phần quyền cho nhân viên!", "Thông báo");
                    return;
                }
            }

            try
            {
                // Gọi phương thức cập nhật
                if (nv.UpdatePermissions(nhanVien.ID_NhanVien, nhanVien.NhanVienQuyen))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    taiKhoanList = taiKhoanBLL.GetAllAccounts();
                    LoadDataToGrid(taiKhoanList);
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

        private void rdbQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            ckbBanHang.Checked = false;
            ckbKho.Checked = false;
            ckbSanPham.Checked = false;
            ckbKhongGH.Checked = true;
            ckbBanHang.Enabled = false;
            ckbKho.Enabled = false;
            ckbSanPham.Enabled = false;
        }

        private void rdbNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            ckbKhongGH.Checked = false;
            ckbSanPham.Enabled = true;
            ckbBanHang.Enabled = true;
            ckbKho.Enabled = true;

        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            frmTaiKhoanCaNhan frm = new frmTaiKhoanCaNhan(CurrentUser.User.NhanVien.ID_NhanVien);
            frm.ShowDialog();

        }
    }
}
