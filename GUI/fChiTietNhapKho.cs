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
    public partial class fChiTietNhapKho : Form
    {
        public fChiTietNhapKho(int id)
        {
            InitializeComponent();
            Form_Load(id);
            LoadChiTietNhapKho(id);
            LoadSanPhamByNCCID(id);

        }
        void Form_Load(int id)
        {
            PhieuNhap PN = PhieuNhapDAO.Instance.GetPhieuNhap(id);
            NCC NCC = NCCDAO.Instance.GetNCCByID(id);
            txtTenNhaCungCap.Text = NCC.NCCName1.ToString();
            txtMaPhieuNhap.Text = id.ToString();
            DtpDateCreate.Value = (DateTime)PN.DateNhap1;


        }
        void LoadChiTietNhapKho(int id)
        {
            List<ChiTietPhieuNhap> CTNKhoList = ChiTietPhieuNhapDAO.Instance.GetChiTietPhieuNhapByID(id);
            float Thanhtien = 0;
            foreach (ChiTietPhieuNhap CTNKho in CTNKhoList)
            {
                SanPham SP = SanPhamDAO.Instance.GetSanPham(CTNKho.MaSP2);
                ListViewItem lsvItem = new ListViewItem(CTNKho.MaSP2.ToString());
                lsvItem.SubItems.Add(SP.TenSP1.ToString());
                lsvItem.SubItems.Add(CTNKho.SL1.ToString());
                lsvItem.SubItems.Add(CTNKho.DG1.ToString());
                Thanhtien += float.Parse(CTNKho.DG1.ToString()) * float.Parse(CTNKho.SL1.ToString());

                lvSanPham.Items.Add(lsvItem);
            }

            CultureInfo Culture = new CultureInfo("vi-VN");
            txtThanhTien.Text = Thanhtien.ToString("c", Culture);

        }
        void LoadSanPhamByNCCID(int id)
        {
            PhieuNhap PN = PhieuNhapDAO.Instance.GetPhieuNhap(id);
            List<SanPham> SPList = SanPhamDAO.Instance.GetSanPhamByNCCID(PN.MaNCC1);
            cbTenSP.DataSource = SPList;
            cbTenSP.DisplayMember = "TenSP1";

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

            string SidPN = txtMaPhieuNhap.Text;
            foreach (ListViewItem item in lvSanPham.Items)
            {
                int idSP = int.Parse(item.SubItems[0].Text);
                int idPN;
                int.TryParse(SidPN, out idPN);
                int SoLuong = int.Parse(item.SubItems[2].Text);
                double DonGia = double.Parse(item.SubItems[3].Text);

                ChiTietPhieuNhapDAO.Instance.InsertCTNKho(idSP, idPN, SoLuong, DonGia);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChiTietNhapKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn hủy?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
