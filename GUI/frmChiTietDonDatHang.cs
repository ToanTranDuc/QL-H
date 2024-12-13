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
        private DonDatHang donDatHang = new DonDatHang();
        public frmChiTietDonDatHang(DonDatHang ddh)
        {
            InitializeComponent();
            donDatHang = ddh;
        }

        private void frmChiTietDonDatHang_Load(object sender, EventArgs e)
        {

        }
    }
}
