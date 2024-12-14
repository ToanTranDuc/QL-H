using BLL;
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
        public frmTaoDonDatHang()
        {
            InitializeComponent();
        }
        public void LoadForm()
        {
            txtSoLuong.Text = "";
            txtGia.Text = "";
            txtGhiChu.Text = "";
            cbbNCC.SelectedValue = -1;
            cbbSanPham.SelectedValue = -1;
        }
        private void frmTaoDonDatHang_Load(object sender, EventArgs e)
        {
            cbbNCC.DataSource = nccBLL.GetListNCC();
            cbbNCC.DisplayMember = "TenNCC";
            cbbNCC.ValueMember = "MaNCC";
        }
    }
}
