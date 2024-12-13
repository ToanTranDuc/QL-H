namespace GUI
{
    partial class fChiTietNhapKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.lvDonDatHang = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbThongTinChung = new System.Windows.Forms.GroupBox();
            this.lbDateCreate = new System.Windows.Forms.Label();
            this.lbTenNhaCungCap = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.lbMaPhieuNhap = new System.Windows.Forms.Label();
            this.DtpDateCreate = new System.Windows.Forms.DateTimePicker();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.lbDanhSach = new System.Windows.Forms.Label();
            this.lvNhapHang = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtThanhTien1 = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbThongTinChung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbDanhSach);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 630);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudSoLuong);
            this.panel4.Controls.Add(this.cbTenSP);
            this.panel4.Controls.Add(this.txtTenSP);
            this.panel4.Controls.Add(this.lbTenSP);
            this.panel4.Controls.Add(this.lbSoLuong);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Location = new System.Drawing.Point(6, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1021, 178);
            this.panel4.TabIndex = 7;
            // 
            // cbTenSP
            // 
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbTenSP.Location = new System.Drawing.Point(28, 20);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(182, 21);
            this.cbTenSP.TabIndex = 18;
            this.cbTenSP.SelectedIndexChanged += new System.EventHandler(this.cbTenSP_SelectedIndexChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTenSP.Location = new System.Drawing.Point(141, 79);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(224, 24);
            this.txtTenSP.TabIndex = 17;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbTenSP.Location = new System.Drawing.Point(25, 82);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(110, 18);
            this.lbTenSP.TabIndex = 16;
            this.lbTenSP.Text = "Tên sản phẩm :";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbSoLuong.Location = new System.Drawing.Point(410, 82);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(75, 18);
            this.lbSoLuong.TabIndex = 14;
            this.lbSoLuong.Text = "Số lượng :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(920, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(6, 583);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 44);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(842, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(939, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtThanhTien1);
            this.panel5.Controls.Add(this.txtThanhTien);
            this.panel5.Controls.Add(this.lbThanhTien);
            this.panel5.Controls.Add(this.grbDanhSach);
            this.panel5.Location = new System.Drawing.Point(6, 364);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 213);
            this.panel5.TabIndex = 5;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtThanhTien.Location = new System.Drawing.Point(341, 173);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(189, 24);
            this.txtThanhTien.TabIndex = 11;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbThanhTien.Location = new System.Drawing.Point(259, 176);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(84, 18);
            this.lbThanhTien.TabIndex = 5;
            this.lbThanhTien.Text = "Thành tiền :";
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.lvNhapHang);
            this.grbDanhSach.Controls.Add(this.lvDonDatHang);
            this.grbDanhSach.Location = new System.Drawing.Point(7, 18);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(1014, 149);
            this.grbDanhSach.TabIndex = 4;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách";
            // 
            // lvDonDatHang
            // 
            this.lvDonDatHang.AutoArrange = false;
            this.lvDonDatHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDonDatHang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lvDonDatHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvDonDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lvDonDatHang.GridLines = true;
            this.lvDonDatHang.HideSelection = false;
            this.lvDonDatHang.LabelWrap = false;
            this.lvDonDatHang.Location = new System.Drawing.Point(3, 16);
            this.lvDonDatHang.Name = "lvDonDatHang";
            this.lvDonDatHang.Size = new System.Drawing.Size(520, 130);
            this.lvDonDatHang.TabIndex = 0;
            this.lvDonDatHang.UseCompatibleStateImageBehavior = false;
            this.lvDonDatHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sản phẩm";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grbThongTinChung);
            this.panel3.Location = new System.Drawing.Point(6, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1021, 123);
            this.panel3.TabIndex = 6;
            // 
            // grbThongTinChung
            // 
            this.grbThongTinChung.Controls.Add(this.txtGhiChu);
            this.grbThongTinChung.Controls.Add(this.label1);
            this.grbThongTinChung.Controls.Add(this.lbDateCreate);
            this.grbThongTinChung.Controls.Add(this.lbTenNhaCungCap);
            this.grbThongTinChung.Controls.Add(this.txtMaPhieuNhap);
            this.grbThongTinChung.Controls.Add(this.lbMaPhieuNhap);
            this.grbThongTinChung.Controls.Add(this.DtpDateCreate);
            this.grbThongTinChung.Controls.Add(this.txtTenNhaCungCap);
            this.grbThongTinChung.Location = new System.Drawing.Point(13, 12);
            this.grbThongTinChung.Name = "grbThongTinChung";
            this.grbThongTinChung.Size = new System.Drawing.Size(998, 108);
            this.grbThongTinChung.TabIndex = 3;
            this.grbThongTinChung.TabStop = false;
            this.grbThongTinChung.Text = "Tìm kiếm";
            // 
            // lbDateCreate
            // 
            this.lbDateCreate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbDateCreate.Location = new System.Drawing.Point(18, 64);
            this.lbDateCreate.Name = "lbDateCreate";
            this.lbDateCreate.Size = new System.Drawing.Size(134, 23);
            this.lbDateCreate.TabIndex = 7;
            this.lbDateCreate.Text = "Ngày nhập :";
            // 
            // lbTenNhaCungCap
            // 
            this.lbTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbTenNhaCungCap.Location = new System.Drawing.Point(18, 26);
            this.lbTenNhaCungCap.Name = "lbTenNhaCungCap";
            this.lbTenNhaCungCap.Size = new System.Drawing.Size(143, 23);
            this.lbTenNhaCungCap.TabIndex = 3;
            this.lbTenNhaCungCap.Text = "Tên nhà cung cấp :";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(531, 32);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.ReadOnly = true;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(189, 20);
            this.txtMaPhieuNhap.TabIndex = 10;
            // 
            // lbMaPhieuNhap
            // 
            this.lbMaPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbMaPhieuNhap.Location = new System.Drawing.Point(387, 29);
            this.lbMaPhieuNhap.Name = "lbMaPhieuNhap";
            this.lbMaPhieuNhap.Size = new System.Drawing.Size(149, 23);
            this.lbMaPhieuNhap.TabIndex = 9;
            this.lbMaPhieuNhap.Text = "Mã đơn đặt hàng :";
            // 
            // DtpDateCreate
            // 
            this.DtpDateCreate.Enabled = false;
            this.DtpDateCreate.Location = new System.Drawing.Point(167, 67);
            this.DtpDateCreate.Name = "DtpDateCreate";
            this.DtpDateCreate.Size = new System.Drawing.Size(189, 20);
            this.DtpDateCreate.TabIndex = 8;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(167, 29);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.ReadOnly = true;
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(204, 20);
            this.txtTenNhaCungCap.TabIndex = 4;
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.AutoEllipsis = true;
            this.lbDanhSach.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbDanhSach.Location = new System.Drawing.Point(383, 4);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(254, 44);
            this.lbDanhSach.TabIndex = 2;
            this.lbDanhSach.Text = "Chi tiết phiếu nhập";
            // 
            // lvNhapHang
            // 
            this.lvNhapHang.AutoArrange = false;
            this.lvNhapHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvNhapHang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lvNhapHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lvNhapHang.GridLines = true;
            this.lvNhapHang.HideSelection = false;
            this.lvNhapHang.LabelWrap = false;
            this.lvNhapHang.Location = new System.Drawing.Point(523, 16);
            this.lvNhapHang.Name = "lvNhapHang";
            this.lvNhapHang.Size = new System.Drawing.Size(481, 130);
            this.lvNhapHang.TabIndex = 1;
            this.lvNhapHang.UseCompatibleStateImageBehavior = false;
            this.lvNhapHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID ";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên sản phẩm";
            this.columnHeader6.Width = 180;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            this.columnHeader7.Width = 80;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(491, 82);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 20);
            this.nudSoLuong.TabIndex = 19;
            // 
            // txtThanhTien1
            // 
            this.txtThanhTien1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtThanhTien1.Location = new System.Drawing.Point(822, 176);
            this.txtThanhTien1.Name = "txtThanhTien1";
            this.txtThanhTien1.Size = new System.Drawing.Size(189, 24);
            this.txtThanhTien1.TabIndex = 12;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtGhiChu.HideSelection = false;
            this.txtGhiChu.Location = new System.Drawing.Point(531, 66);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(189, 24);
            this.txtGhiChu.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(390, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ghi chú :";
            // 
            // fChiTietNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.panel1);
            this.Name = "fChiTietNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Nhập Kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fChiTietNhapKho_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.grbDanhSach.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.grbThongTinChung.ResumeLayout(false);
            this.grbThongTinChung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDanhSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grbThongTinChung;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Label lbTenNhaCungCap;
        private System.Windows.Forms.Label lbDateCreate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label lbMaPhieuNhap;
        private System.Windows.Forms.DateTimePicker DtpDateCreate;
        private System.Windows.Forms.ListView lvDonDatHang;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.ListView lvNhapHang;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.TextBox txtThanhTien1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
    }
}