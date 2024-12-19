using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class NhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.cbTenNCC = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbDateStart = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dtgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.MaDonMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDanhSach = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grbTimKiem);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lbDanhSach);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(9, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 197);
            this.panel3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvPhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // dtgvPhieuNhap
            // 
            this.dtgvPhieuNhap.AllowUserToAddRows = false;
            this.dtgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dtgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.NgayLap,
            this.MaNCC1,
            this.GhiChu1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvPhieuNhap.Location = new System.Drawing.Point(24, 23);
            this.dtgvPhieuNhap.Name = "dtgvPhieuNhap";
            this.dtgvPhieuNhap.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvPhieuNhap.Size = new System.Drawing.Size(732, 148);
            this.dtgvPhieuNhap.TabIndex = 0;
            // 
            // MaPN
            // 
            this.MaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            this.MaPN.Width = 80;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 200;
            // 
            // MaNCC1
            // 
            this.MaNCC1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNCC1.HeaderText = "Mã nhà cung cấp";
            this.MaNCC1.Name = "MaNCC1";
            this.MaNCC1.ReadOnly = true;
            // 
            // GhiChu1
            // 
            this.GhiChu1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GhiChu1.HeaderText = "Ghi chú";
            this.GhiChu1.Name = "GhiChu1";
            this.GhiChu1.ReadOnly = true;
            this.GhiChu1.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Location = new System.Drawing.Point(11, 548);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 49);
            this.panel2.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(597, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 43);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(678, 3);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 43);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Nhập hàng";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.cbTenNCC);
            this.grbTimKiem.Controls.Add(this.dtpEnd);
            this.grbTimKiem.Controls.Add(this.label1);
            this.grbTimKiem.Controls.Add(this.dtpStart);
            this.grbTimKiem.Controls.Add(this.btnRefresh);
            this.grbTimKiem.Controls.Add(this.lbTimKiem);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.lbDateStart);
            this.grbTimKiem.Location = new System.Drawing.Point(17, 35);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(764, 108);
            this.grbTimKiem.TabIndex = 3;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // cbTenNCC
            // 
            this.cbTenNCC.FormattingEnabled = true;
            this.cbTenNCC.Location = new System.Drawing.Point(262, 33);
            this.cbTenNCC.Name = "cbTenNCC";
            this.cbTenNCC.Size = new System.Drawing.Size(187, 21);
            this.cbTenNCC.TabIndex = 11;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(556, 69);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(196, 20);
            this.dtpEnd.TabIndex = 10;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(436, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày kết thúc :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(221, 69);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(196, 20);
            this.dtpStart.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(666, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbTimKiem.Location = new System.Drawing.Point(107, 30);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(149, 23);
            this.lbTimKiem.TabIndex = 3;
            this.lbTimKiem.Text = "Tên nhà cung cấp :";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(534, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbDateStart
            // 
            this.lbDateStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbDateStart.Location = new System.Drawing.Point(107, 66);
            this.lbDateStart.Name = "lbDateStart";
            this.lbDateStart.Size = new System.Drawing.Size(129, 23);
            this.lbDateStart.TabIndex = 7;
            this.lbDateStart.Text = "Ngày bắt đầu :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grbDanhSach);
            this.panel5.Location = new System.Drawing.Point(9, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(786, 197);
            this.panel5.TabIndex = 5;
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dtgvDonDatHang);
            this.grbDanhSach.Location = new System.Drawing.Point(4, 13);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(768, 177);
            this.grbDanhSach.TabIndex = 4;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách đơn mua";
            // 
            // dtgvDonDatHang
            // 
            this.dtgvDonDatHang.AllowUserToAddRows = false;
            this.dtgvDonDatHang.AllowUserToDeleteRows = false;
            this.dtgvDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvDonDatHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonMua,
            this.NgayNhap,
            this.MaNCC,
            this.GhiChu,
            this.TrangThai});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDonDatHang.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvDonDatHang.Location = new System.Drawing.Point(24, 23);
            this.dtgvDonDatHang.Name = "dtgvDonDatHang";
            this.dtgvDonDatHang.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDonDatHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvDonDatHang.Size = new System.Drawing.Size(732, 148);
            this.dtgvDonDatHang.TabIndex = 0;
            // 
            // MaDonMua
            // 
            this.MaDonMua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaDonMua.HeaderText = "Mã đơn mua";
            this.MaDonMua.Name = "MaDonMua";
            this.MaDonMua.ReadOnly = true;
            this.MaDonMua.Width = 80;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayNhap.HeaderText = "Ngày lập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 200;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Width = 200;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbDanhSach.Location = new System.Drawing.Point(322, 0);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(144, 41);
            this.lbDanhSach.TabIndex = 2;
            this.lbDanhSach.Text = "Nhập hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 624);
            this.Controls.Add(this.panel1);
            this.Name = "NhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhapKho_FormClosing);
            this.Load += new System.EventHandler(this.NhapKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonDatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private Panel panel1;
        private Label lbDanhSach;
        private GroupBox grbTimKiem;
        private Label lbDateStart;
        private Button btnRefresh;
        private Button btnTimKiem;
        private Button btnChange;
        private Button button1;
        private Panel panel2;
        private Panel panel5;
        private GroupBox grbDanhSach;
        private DataGridView dtgvDonDatHang;
        private DateTimePicker dtpEnd;
        private Label label1;
        private DateTimePicker dtpStart;
        private Label lbTimKiem;
        private ComboBox cbTenNCC;
        private DataGridViewTextBoxColumn MaDonMua;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn MaNCC;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn TrangThai;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dtgvPhieuNhap;
        private DataGridViewTextBoxColumn MaPN;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn MaNCC1;
        private DataGridViewTextBoxColumn GhiChu1;
        private Button btnView;
    }
}

