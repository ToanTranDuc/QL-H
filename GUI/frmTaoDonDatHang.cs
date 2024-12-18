using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTaoDonDatHang : Form
    {
        private NCCBLL nccBLL = new NCCBLL();
        private SanPhamBLL spBLL = new SanPhamBLL();
        private List<ChiTietDonDatHang> chiTietDonDatHangs = new List<ChiTietDonDatHang>();
        private List<SanPham> sanPhams = new List<SanPham>();

        public frmTaoDonDatHang()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            
            txtGia.Clear();
            txtSoLuong.Clear();
            txtGia.Clear();
            txtGhiChu.Clear();
            dtgMain.Rows.Clear();
            chiTietDonDatHangs.Clear();
            LoadNCC(); // Tải danh sách nhà cung cấp
            cbbNCC.SelectedValue = -1;
            cbbSanPham.SelectedValue = -1;
            txtGia.Text = "";
        }

        private void LoadNCC()
        {
            cbbNCC.DataSource = nccBLL.GetListNCC();
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";
        }

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNCC.SelectedValue != null && int.TryParse(cbbNCC.SelectedValue.ToString(), out int maNCC))
            {
                cbbSanPham.SelectedValue = -1;
                txtGia.Text = "";
                LoadSanPham(maNCC);
            }
        }

        private void LoadSanPham(int maNCC)
        {
            sanPhams = nccBLL.GetProductsBySupplier(maNCC);
            cbbSanPham.DataSource = sanPhams;
            cbbSanPham.DisplayMember = "TenSP";
            cbbSanPham.ValueMember = "MaSP";
        }

        private void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue != null)
            {
                if (int.TryParse(cbbSanPham.SelectedValue.ToString(), out int maSP))
                {
                    var selectedProduct = spBLL.GetProductById(maSP);
                    if (selectedProduct != null)
                    {
                        txtGia.Text = selectedProduct.GiaNhap.ToString("N0") + " VND"; // Hiển thị giá nhập
                    }
                }
                
            }
        }


        private void UpdateTongGia()
        {
            float tongDonDat = 0;
            foreach (DataGridViewRow row in dtgMain.Rows)
            {
                // Kiểm tra giá trị ô trước khi truy cập
                if (row.Cells["SoLuong"].Value != null && row.Cells["Gia"].Value != null)
                {
                    int soLuong = (int)row.Cells["SoLuong"].Value;
                    float donGia = float.Parse(row.Cells["Gia"].Value.ToString().Replace(" VND", "").Replace(",", ""));
                    tongDonDat += soLuong * donGia; // Cộng dồn số lượng nhân với giá nhập
                }
            }

            lblTongGia.Text = "Tổng giá trị đơn đặt: " + tongDonDat.ToString("N0") + " VND"; // Hiển thị tổng
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtgMain.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để lưu.");
                return;
            }

            // Lưu thông tin đơn đặt hàng vào cơ sở dữ liệu
            foreach (DataGridViewRow row in dtgMain.Rows)
            {
                int maSP = (int)row.Cells["MaSP"].Value; // Giả sử cột "MaSP" tồn tại
                int soLuong = (int)row.Cells["SoLuong"].Value; // Giả sử cột "SoLuong" tồn tại
                float donGia = float.Parse(row.Cells["Gia"].Value.ToString().Replace(" VND", "").Replace(",", ""));

                // Thực hiện lưu vào cơ sở dữ liệu
                // ChiTietDonDatHangDAO.Instance.Insert(...);
            }

            MessageBox.Show("Đơn đặt hàng đã được lưu thành công.");
            LoadForm(); // Reset form sau khi lưu
        }

        private int currentDetailId = 1; // Biến để theo dõi ID chi tiết đơn

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có nhà cung cấp nào đã được chọn không
            if (cbbNCC.SelectedValue == null || cbbNCC.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp trước!");
                return;
            }

            // Kiểm tra điều kiện chọn sản phẩm và số lượng
            if (cbbSanPham.SelectedValue != null &&
                int.TryParse(cbbSanPham.SelectedValue.ToString(), out int maSP) &&
                int.TryParse(txtSoLuong.Text, out int soLuong) &&
                soLuong > 0)
            {
                var selectedProduct = spBLL.GetProductById(maSP);
                if (selectedProduct != null)
                {
                    // Kiểm tra xem sản phẩm đã tồn tại trong dtgMain chưa
                    bool productExists = false;
                    foreach (DataGridViewRow row in dtgMain.Rows)
                    {
                        // Kiểm tra giá trị ô "MaSP" có tồn tại không
                        if (row.Cells["MaSP"].Value != null && (int)row.Cells["MaSP"].Value == maSP)
                        {
                            // Kiểm tra giá trị ô "SoLuong" có tồn tại không
                            if (row.Cells["SoLuong"].Value != null)
                            {
                                int existingQuantity = (int)row.Cells["SoLuong"].Value;
                                existingQuantity += soLuong; // Tăng số lượng
                                row.Cells["SoLuong"].Value = existingQuantity;

                                float giaNhap = selectedProduct.GiaNhap;
                                float tongGia = existingQuantity * giaNhap; // Tính lại tổng giá cho sản phẩm này

                                // Cập nhật tổng giá
                                row.Cells["TongGia"].Value = tongGia.ToString("N0") + " VND"; // Cập nhật tổng giá
                            }

                            productExists = true;
                            break;
                        }
                    }

                    // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới vào dtgMain
                    if (!productExists)
                    {
                        float giaNhap = selectedProduct.GiaNhap;
                        float tongGia = soLuong * giaNhap;
                        dtgMain.Rows.Add(new object[]
                        {
                    currentDetailId++, // Tăng ID chi tiết đơn
                    selectedProduct.MaSP,
                    selectedProduct.TenSP,
                    soLuong,
                    giaNhap.ToString("N0") + " VND", // Định dạng giá
                    tongGia.ToString("N0") + " VND" // Tổng giá cho sản phẩm này
                        });
                    }

                    UpdateTongGia(); // Cập nhật tổng giá đơn hàng
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (dtgMain.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để đặt hàng.");
                return;
            }

            // Tạo đối tượng đơn đặt hàng
            DonDatHang donDatHang = new DonDatHang
            {
                NgayDat = DateTime.Now,
                MaNCC = (int)cbbNCC.SelectedValue,
                GhiChu = txtGhiChu.Text,
                TongGia = CalculateTotalPrice(),
                TrangThai = "Chờ xử lý"
            };
            float totalPrice = CalculateTotalPrice();
            MessageBox.Show($"Tổng giá: {totalPrice}"); // Kiểm tra giá trị tổng giá trước khi lưu
            donDatHang.TongGia = totalPrice;

            // Tạo danh sách chi tiết đơn đặt hàng
            List<ChiTietDonDatHang> chiTietDonDatHangs = new List<ChiTietDonDatHang>();

            foreach (DataGridViewRow row in dtgMain.Rows)
            {
                // Kiểm tra xem ô "MaSP", "SoLuong" và "Gia" có phải là null hay không
                if (row.Cells["MaSP"].Value != null && row.Cells["SoLuong"].Value != null && row.Cells["Gia"].Value != null)
                {
                    // Khai báo biến để lưu giá trị
                    int maSP;
                    int soLuong;
                    float gia;

                    bool isMaSPValid = int.TryParse(row.Cells["MaSP"].Value.ToString(), out maSP);
                    bool isSoLuongValid = int.TryParse(row.Cells["SoLuong"].Value.ToString(), out soLuong);
                    bool isGiaValid = float.TryParse(row.Cells["Gia"].Value.ToString().Replace(" VND", "").Replace(",", ""), out gia);

                    if (isMaSPValid && isSoLuongValid && isGiaValid)
                    {
                        ChiTietDonDatHang chiTiet = new ChiTietDonDatHang
                        {
                            MaSP = maSP,
                            SoLuong = soLuong,
                            GiaNhap = gia // Lưu giá vào chi tiết đơn đặt hàng
                        };
                        chiTietDonDatHangs.Add(chiTiet);
                    }
                }
            }

            try
            {
                DonDatHangBLL donDatHangBLL = new DonDatHangBLL();
                donDatHangBLL.SaveDonDatHang(donDatHang, chiTietDonDatHangs);

                MessageBox.Show("Đơn đặt hàng đã được lưu thành công.");
                LoadForm(); // Reset form sau khi lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private float CalculateTotalPrice()
        {
            float total = 0;
            foreach (DataGridViewRow row in dtgMain.Rows)
            {
                if (row.Cells["Gia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    // Chuyển đổi giá trị từ chuỗi sang số
                    if (float.TryParse(row.Cells["Gia"].Value.ToString().Replace(" VND", "").Replace(",", ""), out float gia) &&
                        int.TryParse(row.Cells["SoLuong"].Value.ToString(), out int soLuong))
                    {
                        total += gia * soLuong;
                    }
                }
            }
            return total;
        }
    }
}