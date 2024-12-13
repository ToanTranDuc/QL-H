using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace GUI
{
    public partial class frmChucVu : Form
    {
        private ChucVuBLL chucVuBLL = new ChucVuBLL();
        private List<ChucVu> chucVuList = new List<ChucVu>();
        private string State;
        public frmChucVu()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            txtID.Enabled = false;
            txtGhiChu.Enabled = false;
            txtMaChucVu.Enabled = false;
            txtMaChucVu.Enabled = false;
            txtTenChucVu.Enabled = false;
            State = "Reset";
            txtGhiChu.Text = "";
            txtID.Text = "";
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        private void LoadDataToGrid(List<ChucVu> chucVus)
        {
            dtgMain.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView
            foreach (var cv in chucVus)
            {
                dtgMain.Rows.Add(
                    cv.ID_ChucVu,
                    cv.Ten_ChucVu,
                    cv.Ma_ChucVu,
                    cv.Ghi_Chu

                );
            }
            lblTongSo.Text = "Tổng số: " + chucVus.Count + " bản ghi";
            LoadForm();
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            chucVuList = chucVuBLL.GetAllChucVu();
            LoadDataToGrid(chucVuList);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm
            var ketQuaTimKiem = chucVuList
                .Where(cv => cv.ID_ChucVu.ToString() == tuKhoa ||
                              cv.Ten_ChucVu.ToLower().Contains(tuKhoa) ||
                              cv.Ma_ChucVu.ToLower().Contains(tuKhoa))
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
                MessageBox.Show("Không tìm thấy chức vụ nào với từ khóa: " + txtTuKhoa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTongSo.Text = "Tổng số: 0 bản ghi"; // Cập nhật tổng số
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            txtMaChucVu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            txtGhiChu.Enabled = true;
            txtTenChucVu.Enabled = true;
            txtGhiChu.Text = "";
            txtID.Text = "";
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            State = "Insert";
            txtMaChucVu.Focus();
        }

        private void dtgMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                LoadForm();
                return;
            }

            DataGridViewRow selectedRow = dtgMain.Rows[e.RowIndex];

            // Kiểm tra và gán giá trị vào các ô với điều kiện không phải null
            txtID.Text = selectedRow.Cells["ID"].Value?.ToString() ?? string.Empty;
            txtMaChucVu.Text = selectedRow.Cells["Ma_ChucVu"].Value?.ToString() ?? string.Empty;
            txtTenChucVu.Text = selectedRow.Cells["Ten_ChucVu"].Value?.ToString() ?? string.Empty;
            txtGhiChu.Text = selectedRow.Cells["Ghi_Chu"].Value?.ToString() ?? string.Empty;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            txtGhiChu.Enabled = true;
            txtTenChucVu.Enabled = true;
            txtMaChucVu.Enabled = true;
            State = "Update";
            txtMaChucVu.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMaChucVu.Text == "") { MessageBox.Show("Chưa nhập thông tin mã chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaChucVu.Focus(); return; }
            if (txtTenChucVu.Text == "") { MessageBox.Show("Chưa nhập thông tin tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenChucVu.Focus(); return; }
            bool result = false;
            if (State == "Insert")
            {
                //Thực hiện ghi dữ liệu
                ChucVu chucVu = new ChucVu();
                chucVu.Ten_ChucVu = txtTenChucVu.Text;
                chucVu.Ma_ChucVu = txtMaChucVu.Text;
                chucVu.Ghi_Chu = txtGhiChu.Text;
                result = chucVuBLL.InsertChucVu(chucVu);

            }
            if (State == "Update")
            {
                ChucVu chucVu = new ChucVu();
                chucVu.ID_ChucVu = int.Parse(txtID.Text.Trim());
                chucVu.Ten_ChucVu = txtTenChucVu.Text;
                chucVu.Ma_ChucVu = txtMaChucVu.Text;
                chucVu.Ghi_Chu = txtGhiChu.Text;
                result = chucVuBLL.UpdateChucVu(chucVu);

            }
            if (result)
            {
                MessageBox.Show("Thao tác thành công", "Thông báo");
                chucVuList = chucVuBLL.GetAllChucVu();
                LoadDataToGrid(chucVuList);
            }
            else
            {
                MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChucVu chucVu = new ChucVu();
            string idChucVu = txtID.Text.Trim();
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa bản ghi có ID_ChucVu = {idChucVu}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                chucVu.ID_ChucVu = int.Parse(txtID.Text.Trim());
                if (chucVuBLL.DeleteChucVu(chucVu.ID_ChucVu))
                {
                    MessageBox.Show("Xóa chức vụ thành công!", "Thông báo!");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa chức vụ thất bại!", "Thông báo!");
                    return;
                }
            }
        }
    }
}
