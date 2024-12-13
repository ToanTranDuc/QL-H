namespace GUI
{
    partial class frmDanhSachNhanVien
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
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Dien_Thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trang_Thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
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
            this.ID_NhanVien,
            this.Ho_Ten,
            this.Ngay_Sinh,
            this.Gioi_Tinh,
            this.Dia_Chi,
            this.So_Dien_Thoai,
            this.Ten_ChucVu,
            this.Trang_Thai});
            this.dtgMain.Location = new System.Drawing.Point(33, 141);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.RowHeadersWidth = 62;
            this.dtgMain.RowTemplate.Height = 28;
            this.dtgMain.Size = new System.Drawing.Size(1094, 368);
            this.dtgMain.TabIndex = 25;
            this.dtgMain.SelectionChanged += new System.EventHandler(this.dtgMain_SelectionChanged);
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.FillWeight = 62.61499F;
            this.ID_NhanVien.HeaderText = "ID nhân viên";
            this.ID_NhanVien.MinimumWidth = 8;
            this.ID_NhanVien.Name = "ID_NhanVien";
            // 
            // Ho_Ten
            // 
            this.Ho_Ten.FillWeight = 122.0992F;
            this.Ho_Ten.HeaderText = "Họ tên";
            this.Ho_Ten.MinimumWidth = 8;
            this.Ho_Ten.Name = "Ho_Ten";
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.FillWeight = 96.7803F;
            this.Ngay_Sinh.HeaderText = "Ngày sinh";
            this.Ngay_Sinh.MinimumWidth = 8;
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            // 
            // Gioi_Tinh
            // 
            this.Gioi_Tinh.FillWeight = 54.9888F;
            this.Gioi_Tinh.HeaderText = "Giới tính";
            this.Gioi_Tinh.MinimumWidth = 8;
            this.Gioi_Tinh.Name = "Gioi_Tinh";
            // 
            // Dia_Chi
            // 
            this.Dia_Chi.FillWeight = 122.0992F;
            this.Dia_Chi.HeaderText = "Địa chỉ";
            this.Dia_Chi.MinimumWidth = 8;
            this.Dia_Chi.Name = "Dia_Chi";
            // 
            // So_Dien_Thoai
            // 
            this.So_Dien_Thoai.FillWeight = 122.0992F;
            this.So_Dien_Thoai.HeaderText = "Số điện thoại";
            this.So_Dien_Thoai.MinimumWidth = 8;
            this.So_Dien_Thoai.Name = "So_Dien_Thoai";
            // 
            // Ten_ChucVu
            // 
            this.Ten_ChucVu.FillWeight = 119.3182F;
            this.Ten_ChucVu.HeaderText = "Chức vụ";
            this.Ten_ChucVu.MinimumWidth = 8;
            this.Ten_ChucVu.Name = "Ten_ChucVu";
            // 
            // Trang_Thai
            // 
            this.Trang_Thai.HeaderText = "Trạng thái";
            this.Trang_Thai.MinimumWidth = 8;
            this.Trang_Thai.Name = "Trang_Thai";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(636, 60);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(109, 32);
            this.btnTim.TabIndex = 28;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Từ khóa:";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTongSo.Location = new System.Drawing.Point(33, 118);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(139, 20);
            this.lblTongSo.TabIndex = 26;
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
            this.btnXemChiTiet.Location = new System.Drawing.Point(33, 515);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(134, 79);
            this.btnXemChiTiet.TabIndex = 30;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(856, 515);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(271, 79);
            this.btnThemNhanVien.TabIndex = 31;
            this.btnThemNhanVien.Text = "Thêm nhân viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(145, 61);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(485, 26);
            this.txtTuKhoa.TabIndex = 29;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // frmDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 653);
            this.Controls.Add(this.dtgMain);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.txtTuKhoa);
            this.Name = "frmDanhSachNhanVien";
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.frmHoSoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Dien_Thoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trang_Thai;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.TextBox txtTuKhoa;
    }
}