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
    public partial class frmChiTietDonDatHang : Form
    {
        int  idDonDatHang = -1;
        private List<ChiTietDonDatHang> chiTiets = new List<ChiTietDonDatHang>();
        private ChiTietDonDatHangBLL chiTietBLL = new ChiTietDonDatHangBLL();
        public frmChiTietDonDatHang(int id)
        {
            InitializeComponent();
            idDonDatHang = id;
        }

        public void LoadForm()
        {

        }
        private void LoadDataToGrid(List<ChiTietDonDatHang> cts)
        {
            dtgMain.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView
            foreach (var ct in cts)
            {
                dtgMain.Rows.Add(
                    ct.ID_ChiTiet,
                    ct.MaSP,
                    ct.TenSP,
                    ct.SoLuong,
                    ct.GiaNhap.ToString("N0") + " VND",
                    ct.ThanhTien.ToString("N0") + " VND"
                );
            }
            lblTongSo.Text = "Tổng số: " + cts.Count + " bản ghi";
            LoadForm();
        }
        private void frmChiTietDonDatHang_Load(object sender, EventArgs e)
        {
            chiTiets = chiTietBLL.GetChiTietDonDatHang(idDonDatHang);
            LoadDataToGrid(chiTiets);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm
            var ketQuaTimKiem = chiTiets
                .Where(ct => ct.ID_ChiTiet.ToString() == tuKhoa||
                             ct.TenSP.Contains(tuKhoa) ||
                             ct.ThanhTien.ToString() == tuKhoa)
                .ToList();

            dtgMain.Rows.Clear(); 

            if (ketQuaTimKiem.Count > 0)
            {
                LoadDataToGrid(ketQuaTimKiem);
            }
            else
            {
                // Nếu không có kết quả tìm kiếm
                MessageBox.Show("Không tìm thấy chi tiết đơn nào với từ khóa: " + txtTuKhoa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTongSo.Text = "Tổng số: 0 bản ghi"; // Cập nhật tổng số
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
