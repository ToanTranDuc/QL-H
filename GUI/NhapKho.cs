
using GUI;
using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
        private void NhapKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
        void LoadDonDatHang()
        {
            DataTable dt = HoaDonMuaDAO.Instance.GetHoaDonMua();
           
            dtgvDonDatHang.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                if(row["TrangThai"].ToString().Equals("Hoàn thành"))
                        {
                         continue;
                        }
                else {
                    dtgvDonDatHang.Rows.Add
                        (
                        row["ID_DonDatHang"],
                        row["NgayDat"],
                        row["MaNCC"],
                        row["GhiChu"],
                        row["TrangThai"]
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


           dtgvDonDatHang.Rows.Clear();
            DataTable dt = HoaDonMuaDAO.Instance.GetHoaDonMuaByNCC(MaNCC,Start,End);

            foreach (DataRow row in dt.Rows)
            {
                if (row["TrangThai"].ToString().Equals("Hoàn thành"))
                {
                    continue;
                }
                else
                {
                    dtgvDonDatHang.Rows.Add
                        (
                        row["ID_DonDatHang"],
                        row["NgayDat"],
                        row["MaNCC"],
                        row["GhiChu"],
                        row["TrangThai"]
                        );
                }

            }


        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            Form_Load();
            DataTable dt = HoaDonMuaDAO.Instance.GetHoaDonMua();
            dtgvDonDatHang.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                if (row["TrangThai"].ToString().Equals("Hoàn thành"))
                {
                    continue;
                }
                else
                {
                    dtgvDonDatHang.Rows.Add
                        (
                        row["ID_DonDatHang"],
                        row["NgayDat"],
                        row["MaNCC"],
                        row["GhiChu"],
                        row["TrangThai"]
                        );
                }

            }
        }

        private void dtgvDonDatHang_Choose(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvDonDatHang.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["MaDonMua"].Value);

              
                fChiTietNhapKho CTNKho = new fChiTietNhapKho(id);

                CTNKho.Show();
                

            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dtgvDonDatHang.SelectedRows.Count > 0)
            {
                // Trigger the row selection event to navigate to the detail form
                dtgvDonDatHang_Choose(sender, new DataGridViewCellEventArgs(0, dtgvDonDatHang.SelectedRows[0].Index));
            }
            else if (dtgvDonDatHang.SelectedCells.Count > 0)
            {
                dtgvDonDatHang_Choose(sender, new DataGridViewCellEventArgs(0, dtgvDonDatHang.SelectedCells[0].RowIndex));

            }
        }

        

        private void NhapKho_Load(object sender, EventArgs e)
        {
            Form_Load();
            LoadDonDatHang();
            LoadNCC();
        }
    }
}
