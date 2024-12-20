﻿using BLL;
using DTO;
using GUI;
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
    public partial class frmDonDatHang : Form
    {
        private DonDatHangBLL donDatHangBLL = new DonDatHangBLL();
        private List<DonDatHang> donDatHangList = new List<DonDatHang>();
        private DonDatHang selectedDonDatHang = null;
        public frmDonDatHang()
        {
            InitializeComponent();
        }

        private void LoadDataToGrid(List<DonDatHang> donDatHangs)
        {
            dtgMain.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView
            foreach (var donDat in donDatHangs)
            {
                dtgMain.Rows.Add(
                    donDat.ID_DonDatHang,
                    donDat.NgayDat.ToShortDateString(),
                    donDat.MaNCC,
                    donDat.TenNCC,
                    donDat.GhiChu,
                    donDat.TongGia.ToString("N0") + " VND",
                    donDat.TrangThai
                );
            }
            lblTongSo.Text = "Tổng số: " + donDatHangs.Count + " bản ghi";
        }
        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            donDatHangList = donDatHangBLL.GetListDonDatHang();
            LoadDataToGrid(donDatHangList);
        }
        private void dtgMain_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgMain.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgMain.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID_DonDat"].Value);
                selectedDonDatHang = donDatHangList.FirstOrDefault(don => don.ID_DonDatHang == id);
                btnXemChiTiet.Enabled = true;
            }
            else
            {
                selectedDonDatHang = null;
                btnXemChiTiet.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower(); 
            DateTime ngayDat;
            bool isDate = DateTime.TryParse(tuKhoa, out ngayDat); 

            var ketQuaTimKiem = donDatHangList
                .Where(don => don.ID_DonDatHang.ToString().Equals(tuKhoa, StringComparison.OrdinalIgnoreCase) ||
                              (isDate && don.NgayDat.Date == ngayDat.Date) || 
                              don.TrangThai.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0 || 
                              don.MaNCC.ToString().Equals(tuKhoa, StringComparison.OrdinalIgnoreCase) ||
                              don.TenNCC.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList(); 

            dtgMain.Rows.Clear(); 

            if (ketQuaTimKiem.Count > 0)
            {
                LoadDataToGrid(ketQuaTimKiem);
                lblTongSo.Text = $"Tổng số: {ketQuaTimKiem.Count} bản ghi"; 
            }
            else
            {
                MessageBox.Show("Không tìm thấy đơn đặt hàng nào với từ khóa: " + txtTuKhoa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTongSo.Text = "Tổng số: 0 bản ghi"; 
            }
        }

        private void btnTaoDonDatHang_Click(object sender, EventArgs e)
        {
            frmTaoDonDatHang frm = new frmTaoDonDatHang();
            frm.ShowDialog();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (selectedDonDatHang != null)
            {
                frmChiTietDonDatHang frm = new frmChiTietDonDatHang(selectedDonDatHang.ID_DonDatHang);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn đặt hàng trước!", "Thông báo");
            }
        }

    }
}
