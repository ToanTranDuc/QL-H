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
    public partial class frmChiTietNV : Form
    {
        private NhanVien nhanVien;
        private ChucVuBLL chucVuBLL = new ChucVuBLL();
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        // Sự kiện để thông báo cập nhật thành công
        public event Action<NhanVien> EmployeeUpdated;
        public frmChiTietNV(NhanVien nv)
        {
            InitializeComponent();
            nhanVien = nv;
        }

        private void LoadForm()
        {
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
            rdbHoatDong.Enabled = false;
            rdbNghiViec.Enabled = false;


            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = false;
            btnTaiAnh.Enabled = false;

            ckbKhongGH.Enabled = false;
            if (rdbQuanLy.Checked == true)
            {
                ckbKho.Checked = false;
                ckbBanHang.Checked = false;
                ckbSanPham.Checked = false;
                ckbKho.Enabled = false;
                ckbBanHang.Enabled = false;
                ckbSanPham.Enabled = false;

            }
            if (rdbNhanVien.Checked == true)
            {
                ckbKhongGH.Checked = false;
                ckbKho.Enabled = true;
                ckbBanHang.Enabled = true;
                ckbSanPham.Enabled = true;
            }


            cbbGioiTinh.SelectedIndex = 0; // Chọn "Nam" là mặc định
            if (nhanVien != null)
            {
                ckbKhongGH.Checked = false;
                ckbKho.Checked = false;
                ckbBanHang.Checked = false;
                ckbSanPham.Checked = false;

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

                if (nhanVien.Trang_Thai == "Hoạt động")
                {
                    rdbHoatDong.Checked = true;

                    rdbHoatDong.Enabled = true;
                    rdbNghiViec.Enabled = false;
                }
                if (nhanVien.Trang_Thai == "Đã nghỉ việc")
                {
                    rdbNghiViec.Checked = true;

                    rdbNghiViec.Enabled = true;
                    rdbHoatDong.Enabled = false;
                }

                if (nhanVien.NhanVienQuyen != null)
                {
                    var danhSachQuyen = nhanVien.NhanVienQuyen.Select(q => q.Quyen.TenQuyen).ToList();
                    if (danhSachQuyen.Contains("Quản trị tối cao"))
                    {
                        rdbQuanLy.Checked = true;
                        rdbQuanLy.Enabled = true;
                        rdbNhanVien.Enabled = false;
                    }
                    else
                    {
                        rdbNhanVien.Checked = true;
                        rdbQuanLy.Enabled = false;
                        rdbNhanVien.Enabled = true;
                        ckbKho.Checked = danhSachQuyen.Contains("Kho");
                        ckbBanHang.Checked = danhSachQuyen.Contains("Bán hàng");
                        ckbSanPham.Checked = danhSachQuyen.Contains("Sản phẩm");
                    }
                }

                if (nhanVien.Duong_Dan_Anh != null && nhanVien.Duong_Dan_Anh.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(nhanVien.Duong_Dan_Anh))
                    {
                        ptbAnh.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        private void frmChiTietNV_Load(object sender, EventArgs e)
        {
            // Gán dữ liệu cho combobox Chức vụ
            cbbChucVu.DataSource = chucVuBLL.GetAllChucVu();
            cbbChucVu.DisplayMember = "Ten_ChucVu"; // Tên hiển thị
            cbbChucVu.ValueMember = "ID_ChucVu"; // Giá trị thực tế

            // Thêm lựa chọn cho combobox Giới tính và đặt lựa chọn mặc định
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            LoadForm();
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
            cbbChucVu.Enabled = true;
            cbbGioiTinh.Enabled = true;
            rdbNghiViec.Enabled = true;
            rdbHoatDong.Enabled = true;


            dtpNgayCapNhat.Enabled = false;
            txtNguoiCapNhat.Enabled = false;
            dtpNgayTao.Enabled = false;
            txtNguoiTao.Enabled = false;

            grbQuyen.Enabled = true;


            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = true;
            btnTaiAnh.Enabled = true;

            rdbHoatDong.Enabled = true;
            rdbNghiViec.Enabled = true;

            rdbNhanVien.Enabled = true;
            rdbQuanLy.Enabled = true;





        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadForm();
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
            nhanVien.Trang_Thai = rdbHoatDong.Checked ? "Hoạt động" : "Đã nghỉ việc";

            // Cập nhật giới tính
            nhanVien.Gioi_Tinh = cbbGioiTinh.SelectedItem.ToString();

            // Cập nhật ID chức vụ từ ComboBox
            nhanVien.ID_ChucVu = (int)cbbChucVu.SelectedValue;

            // Cập nhật quyền
            nhanVien.NhanVienQuyen = new List<NhanVien_Quyen>();

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
                if (nhanVienBLL.UpdateEmployee(nhanVien))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    EmployeeUpdated?.Invoke(nhanVien);
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
    }
}