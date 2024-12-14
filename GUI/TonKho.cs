using GUI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class TonKho : Form
    {
        public TonKho()
        {
            InitializeComponent();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = TonKhoDAO.Instance.GetTonkho();
            dtgMain.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    if (row["TenSP"].ToString().ToLower().Contains(txtTuKhoa.Text.ToLower()))
                    {


                        dtgMain.Rows.Add
                            (
                            row["MaSP"],
                            row["TenSP"],
                            row["SoLuong"]
                            );
                    }
                }
            }

        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dtgMain.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();

              

            }
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
        
            DataTable dt = TonKhoDAO.Instance.GetTonkho();
            dtgMain.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgMain.Rows.Add
                        (
                        row["MaSP"],
                        row["TenSP"],
                        row["SoLuong"]
                        );
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int MaSP = int.Parse(txtMaSP.Text);
                int SoLuong = int.Parse(txtSoLuong.Text);
                TonKhoDAO.Instance.UpdateTK(MaSP, SoLuong);
                TonKho_Load(sender, e);

            }
            catch
            {
                MessageBox.Show("Sai dữ liệu");
            }
        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     }
   }
