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
    public partial class frmTaoDonDatHang : Form
    {
        private NCCBLL nccBLL = new NCCBLL();
        private SanPhamBLL spBLL = new SanPhamBLL();
        public frmTaoDonDatHang()
        {
            InitializeComponent();
        }
        public void LoadForm()
        {
            txtSoLuong.Text = "";
            txtGia.Text = "";
            txtGhiChu.Text = "";
            dtgMain.Rows.Clear();
        }
        private void InitializeDataGridView()
        {
            dtgMain.Columns.Clear();

            dtgMain.Columns.Add("ID", "ID chi tiết đơn");
            dtgMain.Columns.Add("MaSP", "Mã sản phẩm");
            dtgMain.Columns.Add("TenSP", "Tên sản phẩm");
            dtgMain.Columns.Add("SoLuong", "Số lượng");
            dtgMain.Columns.Add("GiaNhap", "Giá nhập");
            dtgMain.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";
        }
        private void frmTaoDonDatHang_Load(object sender, EventArgs e)
        {
            LoadForm();
            InitializeDataGridView();
            cbbNCC.DataSource = nccBLL.GetListNCC();
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";

        }
        private void LoadSanPham(int maNCC)
        {
            var products = spBLL.GetProductsBySupplier(maNCC);
            cbbSanPham.DataSource = products;
            cbbSanPham.DisplayMember = "TenSP";
            cbbSanPham.ValueMember = "MaSP";
        }
        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNCC.SelectedValue != null && int.TryParse(cbbNCC.SelectedValue.ToString(), out int maNCC))
            {
                LoadSanPham(maNCC);
            }
        }

        private void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue != null && int.TryParse(cbbSanPham.SelectedValue.ToString(), out int maSP))
            {
                var selectedProduct = spBLL.GetProductById(maSP);

                if (selectedProduct != null)
                {
                    txtGia.Text = selectedProduct.GiaNhap.ToString("N0") + " VND"; // Định dạng số
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue != null
                && int.TryParse(cbbSanPham.SelectedValue.ToString(), out int maSP)
                && !string.IsNullOrWhiteSpace(txtSoLuong.Text)
                && int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                var selectedProduct = spBLL.GetProductById(maSP);

                if (selectedProduct != null)
                {
                    float giaNhap = selectedProduct.GiaNhap;
                    float tongGia = soLuong * giaNhap;

                    dtgMain.Rows.Add(new object[]
                    {
                dtgMain.Rows.Count + 1,
                selectedProduct.MaSP,
                selectedProduct.TenSP,
                soLuong,
                giaNhap.ToString("N0") + " VND"
                    });

                    // Cập nhật tổng giá trị đơn đặt hàng
                    float tongDonDat = 0;
                    foreach (DataGridViewRow row in dtgMain.Rows)
                    {
                        int sl = int.Parse(row.Cells["SoLuong"].Value.ToString());
                        float gia = float.Parse(row.Cells["GiaNhap"].Value.ToString().Replace(" VND", "").Replace(",", ""));
                        tongDonDat += sl * gia;
                    }

                    lblTongGia.Text = "Tổng giá trị đơn đặt: " + tongDonDat.ToString("N0") + " VND";
                    LoadForm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ!");
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (dtgMain.Rows.Count > 0)
            {
                if (float.TryParse(lblTongGia.Text.Replace("Tổng giá trị đơn đặt: ", "").Replace(" VND", "").Replace(",", ""), out float tongGia))
                {
                    DonDatHang donDatHang = new DonDatHang
                    {
                        MaNCC = (int)cbbNCC.SelectedValue,
                        NgayDat = DateTime.Now,
                        TongGia = tongGia,
                        TrangThai = "Chờ xử lý"
                    };

                    List<ChiTietDonDatHang> chiTietDonDatHangs = new List<ChiTietDonDatHang>();
                    foreach (DataGridViewRow row in dtgMain.Rows)
                    {
                        chiTietDonDatHangs.Add(new ChiTietDonDatHang
                        {
                            MaSP = (int)row.Cells["MaSP"].Value,
                            SoLuong = (int)row.Cells["SoLuong"].Value
                        });
                    }

                    DonDatHangBLL donDatHangBLL = new DonDatHangBLL();
                    donDatHangBLL.SaveDonDatHang(donDatHang, chiTietDonDatHangs);

                    MessageBox.Show("Đặt hàng thành công!");
                    LoadForm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào đơn đặt hàng trước!");
            }
        }

    }
}

