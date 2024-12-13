
using GUI;
using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhapKho : Form
    {
        public NhapKho()
        {
            InitializeComponent();

        }
        void Form_Load()
        {

            dtpStart.Value = new DateTime(2023, 1, 1);
            dtpEnd.Value = DateTime.Now;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            fTaoChiTietNhap CTNKho = new fTaoChiTietNhap();
            CTNKho.Show();

        }
        private void NhapKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
        void LoadPhieuNhap()
        {
            DataTable dt = PhieuNhapDAO.Instance.GetPhieuNhap();
            dtgvPhieuNhap.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvPhieuNhap.Rows.Add
                        (
                        row["MaPhieuNhap"],
                        row["NgayLapPhieuNhap"],
                        row["MaNCC"],
                        row["GhiChu"]
                        );
                }
            }
        }
        void LoadNCC()
        {
            List<NCC> NCCList = NCCDAO.Instance.GetNCC();
            cbTenNCC.DataSource = NCCList;
            cbTenNCC.DisplayMember = "NCCName1";
            cbTenNCC.ValueMember = "Id";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            DateTime? Start = dtpStart.Value;
            DateTime? End = dtpEnd.Value;
            int MaNCC = (int)cbTenNCC.SelectedValue;


           dtgvPhieuNhap.Rows.Clear();
            DataTable dt = PhieuNhapDAO.Instance.GetPhieuNhapByNCC(MaNCC,Start,End);
            
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvPhieuNhap.Rows.Add
                        (
                        row["MaPhieuNhap"],
                        row["NgayLapPhieuNhap"],
                        row["MaNCC"],
                        row["GhiChu"]
                        );
                }
            }


        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            Form_Load();
            DataTable dt = PhieuNhapDAO.Instance.GetPhieuNhap();
            dtgvPhieuNhap.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvPhieuNhap.Rows.Add
                        (
                        row["MaPhieuNhap"],
                        row["NgayLapPhieuNhap"],
                        row["MaNCC"],
                        row["GhiChu"]
                        );
                }
            }
        }

        private void dtgvPhieuNhap_Choose(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvPhieuNhap.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["MaPhieuNhap"].Value);

              
                fChiTietNhapKho CTNKho = new fChiTietNhapKho(id);

                CTNKho.Show();
                

            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dtgvPhieuNhap.SelectedRows.Count > 0)
            {
                // Trigger the row selection event to navigate to the detail form
                dtgvPhieuNhap_Choose(sender, new DataGridViewCellEventArgs(0, dtgvPhieuNhap.SelectedRows[0].Index));
            }
            else if (dtgvPhieuNhap.SelectedCells.Count > 0)
            {
                dtgvPhieuNhap_Choose(sender, new DataGridViewCellEventArgs(0, dtgvPhieuNhap.SelectedCells[0].RowIndex));

            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có muốn xóa?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.No)
            {
                return;
            }

            if (dtgvPhieuNhap.SelectedRows.Count > 0)
            {
                DataGridViewRow rowToDelete = dtgvPhieuNhap.SelectedRows[0];
                int id = (int)rowToDelete.Cells["MaPhieuNhap"].Value;
                ChiTietPhieuNhapDAO.Instance.DeleteCTNKho(id);
                PhieuNhapDAO.Instance.DeletePN(id);
                btnRefresh_Click(sender, new EventArgs());
            }
            else if (dtgvPhieuNhap.SelectedCells.Count > 0)
            {
                DataGridViewCell cellToDelete = dtgvPhieuNhap.SelectedCells[0];
                int RowIndex = cellToDelete.RowIndex;
                DataGridViewRow rowToDelete = dtgvPhieuNhap.Rows[RowIndex];
                int id = (int)rowToDelete.Cells["MaPhieuNhap"].Value;
                ChiTietPhieuNhapDAO.Instance.DeleteCTNKho(id);
                PhieuNhapDAO.Instance.DeletePN(id);
                btnRefresh_Click(sender, new EventArgs());
            }
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            Form_Load();
            LoadPhieuNhap();
            LoadNCC();
        }
    }
}
