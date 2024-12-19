
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
    public partial class fPhieuNhapChiTiet : Form
    {
        public fPhieuNhapChiTiet(int id)
        {
            InitializeComponent();
            Form_Load(id);
        }
        void Form_Load(int id)
        {
            LoadChiTietNhapKho(id);
            PhieuNhap HDM = PhieuNhapDAO.Instance.GetPhieuNhap(id);
            NCC NCC = NCCDAO.Instance.GetNCCByID(id);

            txtTenNhaCungCap.Text = NCC.NCCName1.ToString();
            txtMaPhieuNhap.Text = id.ToString();
            DtpDateCreate.Value = (DateTime)HDM.DateNhap1;


        }
        void LoadChiTietNhapKho(int id)
        {
            List<ChiTietPhieuNhap> CTNKhoList = ChiTietPhieuNhapDAO.Instance.GetChiTietPhieuNhapByID(id);
            float Thanhtien = 0;
            foreach (ChiTietPhieuNhap CTNKho in CTNKhoList)
            {
                SanPham SP = SanPhamDAO.Instance.GetSanPham(CTNKho.MaPN1);
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
