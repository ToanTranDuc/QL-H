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
    public partial class fHoaDonBan : Form
    {
        public fHoaDonBan()
        {
            InitializeComponent();
            Form_Load();
            LoadHoaDon();

        }
        void Form_Load()
        {

            dtpStart.Value = new DateTime(2023, 1, 1);
            dtpEnd.Value = DateTime.Now;
        }
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            fTaoChiTietHoaDon CTHD = new fTaoChiTietHoaDon();
            CTHD.Show();

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có muốn xóa?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.No)
            {
                return;
            }

            if (dtgvHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow rowToDelete = dtgvHoaDon.SelectedRows[0];
                int id = (int)rowToDelete.Cells["MaHoaDon"].Value;
                ChiTietHoaDonDAO.Instance.DeleteCTHDB(id);
                HoaDonBanDAO.Instance.DeleteHDB(id);
                btnRefresh_Click(sender, new EventArgs());
            }
            else if (dtgvHoaDon.SelectedCells.Count > 0)
            {
                DataGridViewCell cellToDelete = dtgvHoaDon.SelectedCells[0];
                int RowIndex = cellToDelete.RowIndex;
                DataGridViewRow rowToDelete = dtgvHoaDon.Rows[RowIndex];
                int id = (int)rowToDelete.Cells["MaHoaDon"].Value;
                ChiTietHoaDonDAO.Instance.DeleteCTHDB(id);
                HoaDonBanDAO.Instance.DeleteHDB(id);
                btnRefresh_Click(sender, new EventArgs());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form_Load();
            DataTable dt = HoaDonBanDAO.Instance.GetHoaDonBan();
            dtgvHoaDon.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvHoaDon.Rows.Add
                        (
                            row["MaHoaDon"],
                        row["NgayLapHoaDon"],
                        row["TongTien"],
                        row["GhiChu"]
                        );
                }
            }

        }
        void LoadHoaDon()
        {
            DataTable dt = HoaDonBanDAO.Instance.GetHoaDonBan();
            dtgvHoaDon.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvHoaDon.Rows.Add
                        (
                        row["MaHoaDon"],
                        row["NgayLapHoaDon"],
                        row["TongTien"],
                        row["GhiChu"]
                        );
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime? Start = dtpStart.Value;
            DateTime? End = dtpEnd.Value;

            DataTable dt = HoaDonBanDAO.Instance.GetHoaDonByDate(Start, End);
            dtgvHoaDon.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                {
                    dtgvHoaDon.Rows.Add
                        (
                        row["MaHoaDon"],
                        row["NgayLapHoaDon"],
                        row["TongTien"],
                        row["GhiChu"]
                        );
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dtgvHoaDon.SelectedRows.Count > 0)
            {
                dtgvHoaDon_Choose(sender, new DataGridViewCellEventArgs(0, dtgvHoaDon.SelectedRows[0].Index));
            }
            else if (dtgvHoaDon.SelectedCells.Count > 0)
            {
                dtgvHoaDon_Choose(sender, new DataGridViewCellEventArgs(0, dtgvHoaDon.SelectedCells[0].RowIndex));

            }
        }



        private void dtgvHoaDon_Choose(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvHoaDon.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["MaHoaDon"].Value);

                // Create a new form and pass the data
                fChiTietHoaDon CTXKho = new fChiTietHoaDon(id);
                CTXKho.Show();
            }
        }

    }
}
