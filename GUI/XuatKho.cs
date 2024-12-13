using GUI.DAO;
using GUI;
using DTO;
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
using System.Runtime.Remoting.Channels;

namespace GUI
{
    public partial class XuatKho : Form
    {
        public XuatKho()
        {
            InitializeComponent();
            Form_Load();
            LoadPhieuXuat();

        }
        void Form_Load()
        {

            dtpStart.Value = new DateTime(2023, 1, 1);
            dtpEnd.Value = DateTime.Now;
        }
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            fTaoChiTietXuat CTNKho = new fTaoChiTietXuat();
            CTNKho.ShowDialog();
        
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có muốn xóa?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.No)
            {
                return;
            }

            if (dtgvPhieuXuat.SelectedRows.Count > 0)
            {
                DataGridViewRow rowToDelete = dtgvPhieuXuat.SelectedRows[0];
                int id = (int)rowToDelete.Cells["MaPhieuXuat"].Value;
                ChiTietPhieuXuatDAO.Instance.DeleteCTXKho(id);
                PhieuXuatDAO.Instance.DeletePX(id);
                btnRefresh_Click(sender, new EventArgs());
            }
            else if (dtgvPhieuXuat.SelectedCells.Count > 0)
            {
                DataGridViewCell cellToDelete = dtgvPhieuXuat.SelectedCells[0];
                int RowIndex = cellToDelete.RowIndex;
                DataGridViewRow rowToDelete = dtgvPhieuXuat.Rows[RowIndex];
                int id = (int)rowToDelete.Cells["MaPhieuXuat"].Value;
                ChiTietPhieuXuatDAO.Instance.DeleteCTXKho(id);
                PhieuXuatDAO.Instance.DeletePX(id);
                btnRefresh_Click(sender, new EventArgs());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form_Load();
            DataTable dt = PhieuXuatDAO.Instance.GetPhieuXuat();
            dtgvPhieuXuat.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvPhieuXuat.Rows.Add
                        (
                        row["MaPhieuXuat"],
                        row["NgayLapPhieuXuat"],
                        row["LyDoXuat"]
                        );
                }
            }

        }
        void LoadPhieuXuat()
        {
            DataTable dt = PhieuXuatDAO.Instance.GetPhieuXuat();
            dtgvPhieuXuat.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvPhieuXuat.Rows.Add
                        (
                        row["MaPhieuXuat"],
                        row["NgayLapPhieuXuat"],
                        row["LyDoXuat"]
                        );
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime? Start = dtpStart.Value;
            DateTime? End = dtpEnd.Value;

            DataTable dt = PhieuXuatDAO.Instance.GetPhieuXuatByDate(Start,End);
            dtgvPhieuXuat.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvPhieuXuat.Rows.Add
                        (
                        row["MaPhieuXuat"],
                        row["NgayLapPhieuXuat"],
                        row["LyDoXuat"]
                        );
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dtgvPhieuXuat.SelectedRows.Count > 0)
            {

                dtgvPhieuXuat_Choose(sender, new DataGridViewCellEventArgs(0, dtgvPhieuXuat.SelectedRows[0].Index));
            }
            else if (dtgvPhieuXuat.SelectedCells.Count > 0)
            {
                dtgvPhieuXuat_Choose(sender, new DataGridViewCellEventArgs(0, dtgvPhieuXuat.SelectedCells[0].RowIndex));

            }
        }



        private void dtgvPhieuXuat_Choose(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvPhieuXuat.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["MaPhieuXuat"].Value);

                // Create a new form and pass the data
                fChiTietPhieuXuat CTXKho = new fChiTietPhieuXuat(id);
                CTXKho.Show();
            }
        }
     
    }
}
