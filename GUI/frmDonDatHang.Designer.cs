namespace GUI
{
    partial class frmDonDatHang
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnTaoDonDatHang = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.ID_DonDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMain
            // 
            this.dtgMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DonDat,
            this.NgayDat,
            this.MaNCC,
            this.TenNCC,
            this.GhiChu,
            this.TongGia,
            this.TrangThai});
            this.dtgMain.Location = new System.Drawing.Point(16, 153);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.RowHeadersWidth = 62;
            this.dtgMain.RowTemplate.Height = 28;
            this.dtgMain.Size = new System.Drawing.Size(1351, 561);
            this.dtgMain.TabIndex = 32;
            this.dtgMain.SelectionChanged += new System.EventHandler(this.dtgMain_SelectionChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(619, 72);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(109, 32);
            this.btnTim.TabIndex = 35;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Từ khóa:";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTongSo.Location = new System.Drawing.Point(16, 130);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(139, 20);
            this.lblTongSo.TabIndex = 33;
            this.lblTongSo.Text = "Tổng số: 0 bản ghi";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(16, 735);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(134, 79);
            this.btnXemChiTiet.TabIndex = 37;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnTaoDonDatHang
            // 
            this.btnTaoDonDatHang.Location = new System.Drawing.Point(1037, 735);
            this.btnTaoDonDatHang.Name = "btnTaoDonDatHang";
            this.btnTaoDonDatHang.Size = new System.Drawing.Size(271, 79);
            this.btnTaoDonDatHang.TabIndex = 38;
            this.btnTaoDonDatHang.Text = "Tạo đơn đặt hàng";
            this.btnTaoDonDatHang.UseVisualStyleBackColor = true;
            this.btnTaoDonDatHang.Click += new System.EventHandler(this.btnTaoDonDatHang_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(128, 73);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(485, 26);
            this.txtTuKhoa.TabIndex = 36;
            // 
            // ID_DonDat
            // 
            this.ID_DonDat.HeaderText = "ID Đơn đặt hàng";
            this.ID_DonDat.MinimumWidth = 8;
            this.ID_DonDat.Name = "ID_DonDat";
            // 
            // NgayDat
            // 
            this.NgayDat.HeaderText = "Ngày đặt hàng";
            this.NgayDat.MinimumWidth = 8;
            this.NgayDat.Name = "NgayDat";
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 8;
            this.TenNCC.Name = "TenNCC";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            // 
            // TongGia
            // 
            this.TongGia.HeaderText = "Tổng giá";
            this.TongGia.MinimumWidth = 8;
            this.TongGia.Name = "TongGia";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1379, 826);
            this.Controls.Add(this.dtgMain);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnTaoDonDatHang);
            this.Controls.Add(this.txtTuKhoa);
            this.Name = "frmDonDatHang";
            this.Text = "frmDonDatHang";
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtgMain;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnTaoDonDatHang;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DonDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}