using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.DAO;
using GUI.DTO;



namespace GUI
{
    public partial class fTaoChiTietHoaDon : Form
    {
        public fTaoChiTietHoaDon()
        {
            InitializeComponent();
        }
        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            SanPham selected = cb.SelectedItem as SanPham;
            txtDonGia.Text = (selected.GiaNhap1).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            ComboBox cb = cbTenSP;
            if (cb.SelectedItem == null)
                return;
            SanPham selectedSP = cb.SelectedItem as SanPham;

            ListViewItem items = new ListViewItem();
            items = null;
            if (lvSanPham.Items.Count != 0)
            {
                items = lvSanPham.Items[0];
            }
            try
            {


                string SoLuong = (txtSoLuong.Text);
                int id = selectedSP.Id;

                double thanhtien = 0;


                bool added = false;
                foreach (ListViewItem item in lvSanPham.Items)
                {
                    if (item.SubItems[0].Text == id.ToString())
                    {
                        int TotalCount = int.Parse(SoLuong) + int.Parse(item.SubItems[2].Text);


                        if (TotalCount > 0)
                        {
                            item.SubItems[2].Text = TotalCount.ToString();
                            added = true;
                        }
                        else
                        {
                            item.SubItems[2].Text = "0";
                            added = true;
                        }
                    }
                }

                foreach (ListViewItem item in lvSanPham.Items)
                {
                    if (int.Parse(item.SubItems[2].Text) > 0)
                        thanhtien += Double.Parse(item.SubItems[2].Text) * Double.Parse(item.SubItems[3].Text);
                }

                CultureInfo Culture = new CultureInfo("vi-VN");
                txtThanhTien.Text = thanhtien.ToString("c", Culture);


                if (!added)
                {
                    if (int.Parse(SoLuong) < 1) return;

                    ListViewItem lsvItem = new ListViewItem(selectedSP.Id.ToString());
                    lsvItem.SubItems.Add(selectedSP.TenSP1.ToString());
                    lsvItem.SubItems.Add(SoLuong.ToString());
                    lsvItem.SubItems.Add(selectedSP.GiaNhap1.ToString());

                    lvSanPham.Items.Add(lsvItem);

                    thanhtien += float.Parse(selectedSP.GiaNhap1.ToString()) * float.Parse(SoLuong);
                    txtThanhTien.Text = thanhtien.ToString("c", Culture);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSanPham.Items)
            {
                if (int.Parse(item.SubItems[2].Text) == 0)
                {
                    lvSanPham.Items.Remove(item);
                }
            }
            if (lvSanPham.Items.Count == 0)
            {
                MessageBox.Show("Lỗi");
                return;
            }

            ListViewItem items = new ListViewItem();
            items = null;
            items = lvSanPham.Items[0];
            SanPham SP = SanPhamDAO.Instance.GetSanPham(int.Parse(items.SubItems[0].Text));

            string ThanhTien = txtThanhTien.Text.Replace(".", "").Replace(",", "").Replace("₫", "");
            double ThanhTiend = double.Parse(ThanhTien);
            ThanhTiend /= 100;
            HoaDonBanDAO.Instance.InsertHDB( ThanhTiend,DtpDateCreate.Value, txtGhiChu.Text);


            foreach (ListViewItem item in lvSanPham.Items)
            {
                int idSP = int.Parse(item.SubItems[0].Text);
                int idPN = HoaDonBanDAO.Instance.GetMaxIDHDB();
                int SoLuong = int.Parse(item.SubItems[2].Text);
                double DonGia = double.Parse(item.SubItems[3].Text);

                ChiTietHoaDonDAO.Instance.InsertCTHDB(idSP, idPN, SoLuong, DonGia);
                this.Close();
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            LoadSP(txtTenSP.Text);
        }
        private void LoadSP(string TenSP)
        {
            cbTenSP.DataSource = SanPhamDAO.Instance.GetSanPhamByName(TenSP);
            cbTenSP.DisplayMember = "TenSP1";
        }
    }
}
