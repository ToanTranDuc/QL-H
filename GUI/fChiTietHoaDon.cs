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
    public partial class fChiTietHoaDon : Form
    {
        public fChiTietHoaDon(int id)
        {
            InitializeComponent();
            LoadChiTietHoaDon(id);
        }
        void LoadChiTietHoaDon(int id)
        {
            HoaDonBan HDB = HoaDonBanDAO.Instance.GetHoaDonBan(id);
            txtMaDonMua.Text = HDB.MaHD1.ToString();
            DtpDateCreate.Value = (DateTime)HDB.DateNhap1;
            txtGhiChu.Text = HDB.GhiChu1;
            List<ChiTietHoaDon> CTNKhoList = ChiTietHoaDonDAO.Instance.GetChiTietHoaDonByID(id);
            float Thanhtien = 0;
            foreach (ChiTietHoaDon CTNKho in CTNKhoList)
            {
                SanPham SP = SanPhamDAO.Instance.GetSanPham(CTNKho.MaSP1);
                ListViewItem lsvItem = new ListViewItem(CTNKho.MaSP1.ToString());
                lsvItem.SubItems.Add(SP.TenSP1.ToString());
                lsvItem.SubItems.Add(CTNKho.SL1.ToString());
                lsvItem.SubItems.Add(CTNKho.DG1.ToString());
                Thanhtien += float.Parse(CTNKho.DG1.ToString()) * float.Parse(CTNKho.SL1.ToString());

                lvSanPham.Items.Add(lsvItem);
            }

            CultureInfo Culture = new CultureInfo("vi-VN");
            txtThanhTien.Text = Thanhtien.ToString("c", Culture);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("In hóa đơn?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
