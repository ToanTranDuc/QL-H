using GUI.DAO;
using GUI.DTO;
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

namespace GUI
{
    public partial class fChiTietPhieuXuat : Form
    {
        public fChiTietPhieuXuat(int id)
        {
            InitializeComponent();
            Form_Load(id);
            LoadChiTietXuatKho(id);
            LoadNCC();

        }
        void Form_Load(int id)
        {
            PhieuXuat PN = PhieuXuatDAO.Instance.GetPhieuXuat(id);
            txtMaPhieuXuat.Text = id.ToString();
            DtpDateCreate.Value = (DateTime)PN.DateXuat1;


        }
        void LoadChiTietXuatKho(int id)
        {
            List<ChiTietPhieuXuat> CTXKhoList = ChiTietPhieuXuatDAO.Instance.GetChiTietPhieuXuatByID(id);
            float Thanhtien = 0;
            foreach (ChiTietPhieuXuat CTXKho in CTXKhoList)
            {
                SanPham SP = SanPhamDAO.Instance.GetSanPham(CTXKho.MaSP2);
                ListViewItem lsvItem = new ListViewItem(CTXKho.MaSP2.ToString());
                lsvItem.SubItems.Add(SP.TenSP1.ToString());
                lsvItem.SubItems.Add(CTXKho.SL1.ToString());
                lsvItem.SubItems.Add(CTXKho.DG1.ToString());
                Thanhtien += float.Parse(CTXKho.TT1.ToString());

                lvSanPham.Items.Add(lsvItem);
            }

            CultureInfo Culture = new CultureInfo("vi-VN");
            txtThanhTien.Text = Thanhtien.ToString("c", Culture);

        }


        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            SanPham selected = cb.SelectedItem as SanPham;
            txtDonGia.Text = (selected.GiaNhap1).ToString();
            txtTenSP.Text = selected.TenSP1.ToString();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ComboBox cb = cbTenSP;
            if (cb.SelectedItem == null)
                return;
            SanPham selected = cb.SelectedItem as SanPham;


            string SoLuong = (txtSoLuong.Text);

            int id = selected.Id;

            double thanhtien = 0;


            bool added = false;
            try
            {
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

                    ListViewItem lsvItem = new ListViewItem(selected.Id.ToString());
                    lsvItem.SubItems.Add(selected.TenSP1.ToString());
                    lsvItem.SubItems.Add(SoLuong.ToString());
                    lsvItem.SubItems.Add(selected.GiaNhap1.ToString());

                    lvSanPham.Items.Add(lsvItem);

                    thanhtien += float.Parse(selected.GiaNhap1.ToString()) * float.Parse(SoLuong);
                    txtThanhTien.Text = thanhtien.ToString("c", Culture);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvSanPham.Items.Count == 0)
            {
                MessageBox.Show("Lỗi");
                return;
            }
            if (lvSanPham.Items.Count == 1)
            {
                ListViewItem item = lvSanPham.Items[0];
                if (int.Parse(item.SubItems[2].Text) == 0)
                {
                    MessageBox.Show("Lỗi");
                    return;
                }
            }

            string SidPN = txtMaPhieuXuat.Text;
            foreach (ListViewItem item in lvSanPham.Items)
            {
                int idSP = int.Parse(item.SubItems[0].Text);
                int idPN;
                int.TryParse(SidPN, out idPN);
                int SoLuong = int.Parse(item.SubItems[2].Text);
                double DonGia = double.Parse(item.SubItems[3].Text);

                ChiTietPhieuXuatDAO.Instance.InsertCTXKho(idSP, idPN, SoLuong, DonGia);
 
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChiTietPhieuXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn hủy?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void cbTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            NCC selected = cb.SelectedItem as NCC;

            LoadSPByNCCID(selected.Id);
        }

        void LoadNCC()
        {
            List<NCC> NCCList = NCCDAO.Instance.GetNCC();
            cbTenNCC.DataSource = NCCList;
            cbTenNCC.DisplayMember = "NCCName1";
        }
        void LoadSPByNCCID(int id)
        {
            List<SanPham> SPList = SanPhamDAO.Instance.GetSanPhamByNCCID(id);
            cbTenSP.DataSource = SPList;
            cbTenSP.DisplayMember = "TenSP1";
        }
    }
}
