namespace GUI
{
    partial class frmChiTietDonDatHang
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
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.ID_ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMain
            // 
            this.dtgMain.AllowUserToOrderColumns = true;
            this.dtgMain.AllowUserToResizeRows = false;
            this.dtgMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMain.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ChiTiet,
            this.MaSp,
            this.TenSP,
            this.SoLuong,
            this.GiaNhap,
            this.ThanhTien});
            this.dtgMain.Location = new System.Drawing.Point(109, 93);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.RowHeadersWidth = 62;
            this.dtgMain.RowTemplate.Height = 28;
            this.dtgMain.Size = new System.Drawing.Size(912, 494);
            this.dtgMain.TabIndex = 24;
            // 
            // ID_ChiTiet
            // 
            this.ID_ChiTiet.HeaderText = "ID Chi tiết đơn đặt";
            this.ID_ChiTiet.MinimumWidth = 8;
            this.ID_ChiTiet.Name = "ID_ChiTiet";
            // 
            // MaSp
            // 
            this.MaSp.HeaderText = "Mã sản phẩm";
            this.MaSp.MinimumWidth = 8;
            this.MaSp.Name = "MaSp";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 8;
            this.GiaNhap.Name = "GiaNhap";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTongSo.Location = new System.Drawing.Point(105, 70);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(139, 20);
            this.lblTongSo.TabIndex = 41;
            this.lblTongSo.Text = "Tổng số: 0 bản ghi";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(702, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(109, 32);
            this.btnTim.TabIndex = 40;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.ForeColor = System.Drawing.Color.LightGray;
            this.txtTuKhoa.Location = new System.Drawing.Point(258, 19);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(438, 35);
            this.txtTuKhoa.TabIndex = 33;
            this.txtTuKhoa.Text = "Từ khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Từ khóa:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(916, 619);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 38);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmChiTietDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 677);
            this.Controls.Add(this.dtgMain);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label5);
            this.Name = "frmChiTietDonDatHang";
            this.Text = "frmChiTietDonDatHang";
            this.Load += new System.EventHandler(this.frmChiTietDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMain;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnThoat;
    }
}