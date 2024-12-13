namespace GUI
{
    partial class frmTaiKhoan
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtID_DangNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbQuyen = new System.Windows.Forms.GroupBox();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbQuanLy = new System.Windows.Forms.RadioButton();
            this.ckbKhongGH = new System.Windows.Forms.CheckBox();
            this.ckbKho = new System.Windows.Forms.CheckBox();
            this.ckbBanHang = new System.Windows.Forms.CheckBox();
            this.ckbSanPham = new System.Windows.Forms.CheckBox();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgMain
            // 
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenDangNhap,
            this.ID_NhanVien,
            this.TenNguoiDung,
            this.MatKhau});
            this.dtgMain.Location = new System.Drawing.Point(20, 83);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.RowHeadersWidth = 62;
            this.dtgMain.RowTemplate.Height = 28;
            this.dtgMain.Size = new System.Drawing.Size(580, 627);
            this.dtgMain.TabIndex = 53;
            this.dtgMain.SelectionChanged += new System.EventHandler(this.dtgMain_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Tài khoản";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 8;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 150;
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.HeaderText = "ID Nhân viên";
            this.ID_NhanVien.MinimumWidth = 8;
            this.ID_NhanVien.Name = "ID_NhanVien";
            this.ID_NhanVien.Width = 150;
            // 
            // TenNguoiDung
            // 
            this.TenNguoiDung.HeaderText = "Tên người dùng";
            this.TenNguoiDung.MinimumWidth = 8;
            this.TenNguoiDung.Name = "TenNguoiDung";
            this.TenNguoiDung.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 8;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(157, 61);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(257, 26);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // txtID_DangNhap
            // 
            this.txtID_DangNhap.Location = new System.Drawing.Point(157, 14);
            this.txtID_DangNhap.Name = "txtID_DangNhap";
            this.txtID_DangNhap.Size = new System.Drawing.Size(257, 26);
            this.txtID_DangNhap.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên người dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID tài khoản:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1152, 537);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 38);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1152, 83);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 38);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbbTrangThai);
            this.panel1.Controls.Add(this.txtTenNguoiDung);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.txtID_DangNhap);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(606, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 627);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.grbQuyen);
            this.panel2.Location = new System.Drawing.Point(18, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 254);
            this.panel2.TabIndex = 4;
            // 
            // grbQuyen
            // 
            this.grbQuyen.Controls.Add(this.rdbNhanVien);
            this.grbQuyen.Controls.Add(this.rdbQuanLy);
            this.grbQuyen.Controls.Add(this.ckbKhongGH);
            this.grbQuyen.Controls.Add(this.ckbKho);
            this.grbQuyen.Controls.Add(this.ckbBanHang);
            this.grbQuyen.Controls.Add(this.ckbSanPham);
            this.grbQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuyen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbQuyen.Location = new System.Drawing.Point(13, 10);
            this.grbQuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbQuyen.Name = "grbQuyen";
            this.grbQuyen.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbQuyen.Size = new System.Drawing.Size(480, 209);
            this.grbQuyen.TabIndex = 0;
            this.grbQuyen.TabStop = false;
            this.grbQuyen.Text = "Quyền sử dụng hệ thống";
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.ForeColor = System.Drawing.Color.Green;
            this.rdbNhanVien.Location = new System.Drawing.Point(313, 46);
            this.rdbNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(128, 26);
            this.rdbNhanVien.TabIndex = 4;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân Viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            this.rdbNhanVien.CheckedChanged += new System.EventHandler(this.rdbNhanVien_CheckedChanged);
            // 
            // rdbQuanLy
            // 
            this.rdbQuanLy.AutoSize = true;
            this.rdbQuanLy.ForeColor = System.Drawing.Color.Green;
            this.rdbQuanLy.Location = new System.Drawing.Point(94, 46);
            this.rdbQuanLy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbQuanLy.Name = "rdbQuanLy";
            this.rdbQuanLy.Size = new System.Drawing.Size(173, 26);
            this.rdbQuanLy.TabIndex = 1;
            this.rdbQuanLy.TabStop = true;
            this.rdbQuanLy.Text = "Quản trị tối cao";
            this.rdbQuanLy.UseVisualStyleBackColor = true;
            this.rdbQuanLy.CheckedChanged += new System.EventHandler(this.rdbQuanLy_CheckedChanged);
            // 
            // ckbKhongGH
            // 
            this.ckbKhongGH.AutoSize = true;
            this.ckbKhongGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKhongGH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbKhongGH.Location = new System.Drawing.Point(96, 83);
            this.ckbKhongGH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbKhongGH.Name = "ckbKhongGH";
            this.ckbKhongGH.Size = new System.Drawing.Size(149, 24);
            this.ckbKhongGH.TabIndex = 3;
            this.ckbKhongGH.Text = "Không giới hạng";
            this.ckbKhongGH.UseVisualStyleBackColor = true;
            // 
            // ckbKho
            // 
            this.ckbKho.AutoSize = true;
            this.ckbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbKho.Location = new System.Drawing.Point(313, 119);
            this.ckbKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbKho.Name = "ckbKho";
            this.ckbKho.Size = new System.Drawing.Size(63, 24);
            this.ckbKho.TabIndex = 0;
            this.ckbKho.Text = "Kho";
            this.ckbKho.UseVisualStyleBackColor = true;
            // 
            // ckbBanHang
            // 
            this.ckbBanHang.AutoSize = true;
            this.ckbBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBanHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbBanHang.Location = new System.Drawing.Point(313, 83);
            this.ckbBanHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbBanHang.Name = "ckbBanHang";
            this.ckbBanHang.Size = new System.Drawing.Size(104, 24);
            this.ckbBanHang.TabIndex = 5;
            this.ckbBanHang.Text = "Bán hàng";
            this.ckbBanHang.UseVisualStyleBackColor = true;
            // 
            // ckbSanPham
            // 
            this.ckbSanPham.AutoSize = true;
            this.ckbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbSanPham.Location = new System.Drawing.Point(313, 151);
            this.ckbSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbSanPham.Name = "ckbSanPham";
            this.ckbSanPham.Size = new System.Drawing.Size(108, 24);
            this.ckbSanPham.TabIndex = 1;
            this.ckbSanPham.Text = "Sản phẩm";
            this.ckbSanPham.UseVisualStyleBackColor = true;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(157, 242);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(257, 28);
            this.cbbTrangThai.TabIndex = 4;
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(157, 117);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(257, 26);
            this.txtTenNguoiDung.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(157, 176);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(257, 26);
            this.txtMatKhau.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1152, 224);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 38);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTongSo.Location = new System.Drawing.Point(16, 51);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(139, 20);
            this.lblTongSo.TabIndex = 46;
            this.lblTongSo.Text = "Tổng số: 0 bản ghi";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.ForeColor = System.Drawing.Color.LightGray;
            this.txtTuKhoa.Location = new System.Drawing.Point(127, 7);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(365, 35);
            this.txtTuKhoa.TabIndex = 44;
            this.txtTuKhoa.Text = "Tìm kiếm tài khoản";
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(1152, 268);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(105, 38);
            this.btnGhi.TabIndex = 3;
            this.btnGhi.Text = "Ghi dữ liệu";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Từ khóa:";
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThongTinCaNhan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(989, 26);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(268, 35);
            this.btnThongTinCaNhan.TabIndex = 54;
            this.btnThongTinCaNhan.Text = "Xem thông tin cá nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = false;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1283, 725);
            this.Controls.Add(this.btnThongTinCaNhan);
            this.Controls.Add(this.dtgMain);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.label5);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grbQuyen.ResumeLayout(false);
            this.grbQuyen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMain;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtID_DangNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbQuyen;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.RadioButton rdbQuanLy;
        private System.Windows.Forms.CheckBox ckbKhongGH;
        private System.Windows.Forms.CheckBox ckbKho;
        private System.Windows.Forms.CheckBox ckbBanHang;
        private System.Windows.Forms.CheckBox ckbSanPham;
        private System.Windows.Forms.Button btnThongTinCaNhan;
    }
}