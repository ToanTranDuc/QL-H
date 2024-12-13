using BLL;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDanhSachNhanVien : Form
    {
        private NhanVienBLL nhanVienBLL = new NhanVienBLL();
        private List<NhanVien> nhanVienList;
        private NhanVien selectedNhanVien = null;

        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void LoadDataToGrid(List<NhanVien> nhanViens)
        {
            dtgMain.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView
            foreach (var nhanVien in nhanViens)
            {
                dtgMain.Rows.Add(
                    nhanVien.ID_NhanVien,
                    nhanVien.Ho_Ten,
                    nhanVien.Ngay_Sinh.ToShortDateString(),
                    nhanVien.Gioi_Tinh,
                    nhanVien.Dia_Chi,
                    nhanVien.So_Dien_Thoai,
                    nhanVien.ChucVu.Ten_ChucVu,
                    nhanVien.Trang_Thai
                );
            }
            lblTongSo.Text = "Tổng số: " + nhanViens.Count + " bản ghi";
        }

        private void frmHoSoNhanVien_Load(object sender, EventArgs e)
        {
            LoadEmployeeData(); // Tải dữ liệu nhân viên
        }

        private void LoadEmployeeData()
        {
            nhanVienList = nhanVienBLL.GetAllEmployees();
            LoadDataToGrid(nhanVienList);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (selectedNhanVien != null)
            {
                frmChiTietNV formChiTiet = new frmChiTietNV(selectedNhanVien);
                formChiTiet.EmployeeUpdated += (updatedEmployee) =>
                {
                    LoadEmployeeData();
                };
                formChiTiet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên trước!", "Thông báo");
            }
        }

        private void dtgMain_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgMain.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgMain.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID_NhanVien"].Value);
                selectedNhanVien = nhanVienList.FirstOrDefault(nv => nv.ID_NhanVien == id);
                btnXemChiTiet.Enabled = true;
            }
            else
            {
                // Nếu không có hàng nào được chọn, đặt selectedNhanVien về null
                selectedNhanVien = null;

                // Vô hiệu hóa nút Xem Chi Tiết
                btnXemChiTiet.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm
            var ketQuaTimKiem = nhanVienList
                .Where(nv => nv.Ho_Ten.ToLower().Contains(tuKhoa) ||
                              nv.Dia_Chi.ToLower().Contains(tuKhoa) ||
                              nv.So_Dien_Thoai.Contains(tuKhoa) ||
                              nv.Trang_Thai.Contains(tuKhoa) ||
                              nv.ID_NhanVien.ToString() == tuKhoa)
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
                MessageBox.Show("Không tìm thấy nhân viên nào với từ khóa: " + txtTuKhoa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTongSo.Text = "Tổng số: 0 bản ghi"; // Cập nhật tổng số
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}