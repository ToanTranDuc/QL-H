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
           

        }
        void Form_Load(int id)
        {
            LoadChiTietNhapKho(id);
            LoadSanPhamByNCCID(id);
            HoaDonMua HDM = HoaDonMuaDAO.Instance.GetHoaDonMua(id);
            NCC NCC = NCCDAO.Instance.GetNCCByID(id);

            txtTenNhaCungCap.Text = NCC.NCCName1.ToString();
            
            txtMaPhieuNhap.Text = id.ToString();
            DtpDateCreate.Value = (DateTime)HDM.DateNhap1;


        }
        void LoadChiTietNhapKho(int id)
        {
            List<ChiTietHoaDonMua> CTNKhoList = ChiTietHoaDonMuaDAO.Instance.GetChiTietHoaDonMuaByID(id);
            float Thanhtien = 0;
            foreach (ChiTietHoaDonMua CTNKho in CTNKhoList)
            {
                SanPham SP = SanPhamDAO.Instance.GetSanPham(CTNKho.MaSP1);
                ListViewItem lsvItem = new ListViewItem(CTNKho.MaSP1.ToString());
                lsvItem.SubItems.Add(SP.TenSP1.ToString());
                lsvItem.SubItems.Add(CTNKho.SL1.ToString());
                lsvItem.SubItems.Add(CTNKho.DG1.ToString());
                Thanhtien += float.Parse(CTNKho.DG1.ToString()) * float.Parse(CTNKho.SL1.ToString());

                lvDonDatHang.Items.Add(lsvItem);
            }

            CultureInfo Culture = new CultureInfo("vi-VN");
            txtThanhTien.Text = Thanhtien.ToString("c", Culture);

        }
        void LoadSanPhamByNCCID(int id)
        {
            HoaDonMua HDM = HoaDonMuaDAO.Instance.GetHoaDonMua(id);
            txtGhiChu.Text = HDM.GhiChu1;
            List<SanPham> SPList = SanPhamDAO.Instance.GetSanPhamByNCCID(HDM.MaNCC1);
            cbTenSP.DataSource = SPList;
            cbTenSP.DisplayMember = "TenSP1";
            cbTenSP.ValueMember = "Id";

        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            SanPham selected = cb.SelectedItem as SanPham;
            txtTenSP.Text = selected.TenSP1.ToString();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ComboBox cb = cbTenSP;
            if (cb.SelectedItem == null)
                return;
            //SanPham selected = cb.SelectedItem as SanPham;
            SanPham selected = cb.SelectedItem as SanPham;

            ChiTietHoaDonMua CT = ChiTietHoaDonMuaDAO.Instance.GetCTHDMByHDAndSP(int.Parse(txtMaPhieuNhap.Text), selected.Id);


            string SoLuong = (nudSoLuong.Text);

            int id = selected.Id;

            double thanhtien = 0;


            bool added = false;
            try
            {
                foreach (ListViewItem item in lvNhapHang.Items)
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
                foreach (ListViewItem item in lvNhapHang.Items)
                {
                    if (int.Parse(item.SubItems[2].Text) > 0)
                        thanhtien += Double.Parse(item.SubItems[2].Text) * Double.Parse(item.SubItems[3].Text);
                }

                CultureInfo Culture = new CultureInfo("vi-VN");
                txtThanhTien1.Text = thanhtien.ToString("c", Culture);


                if (!added)
                {
                    if (int.Parse(SoLuong) < 1) return;

                    ListViewItem lsvItem = new ListViewItem(selected.Id.ToString());
                    lsvItem.SubItems.Add(selected.TenSP1.ToString());
                    lsvItem.SubItems.Add(SoLuong.ToString());
                    lsvItem.SubItems.Add(CT.DG1.ToString());

                    lvNhapHang.Items.Add(lsvItem);

                    thanhtien += float.Parse(CT.DG1.ToString()) * float.Parse(SoLuong);
                    txtThanhTien1.Text = thanhtien.ToString("c", Culture);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvNhapHang.Items.Count == 0)
            {
                MessageBox.Show("Lỗi");
                return;
            }
            if (lvNhapHang.Items.Count == 1)
            {
                ListViewItem item = lvDonDatHang.Items[0];
                if (int.Parse(item.SubItems[2].Text) == 0)
                {
                    MessageBox.Show("Lỗi");
                    return;
                }
            }
            HoaDonMuaDAO.Instance.UpdateHoaDonMuaTrangThai("'Hoàn thành'", int.Parse(txtMaPhieuNhap.Text));
            NCC NCC = NCCDAO.Instance.GetNCCByID(int.Parse(txtMaPhieuNhap.Text));
            DateTime now = DateTime.Now;
            PhieuNhapDAO.Instance.InsertPN(NCC.Id,now,"");

           
            foreach (ListViewItem item in lvNhapHang.Items)
            {
                int idSP = int.Parse(item.SubItems[0].Text);
                int idPN = PhieuNhapDAO.Instance.GetMaxIDPN();
           
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
         
        }
    }
}
