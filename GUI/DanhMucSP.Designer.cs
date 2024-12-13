namespace GUI
{
    partial class DanhMucSP
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
            this.grbDanhMucSP = new System.Windows.Forms.GroupBox();
            this.btnDMThem = new System.Windows.Forms.Button();
            this.ptbDMAnhSP = new System.Windows.Forms.PictureBox();
            this.txtDMAnhLoad = new System.Windows.Forms.TextBox();
            this.btnDMTim = new System.Windows.Forms.Button();
            this.btnDMReset = new System.Windows.Forms.Button();
            this.btnDMXoa = new System.Windows.Forms.Button();
            this.txtDMTimKiem = new System.Windows.Forms.TextBox();
            this.cmbDMTheLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDanhSachSP = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachSP = new System.Windows.Forms.DataGridView();
            this.btnDMChiTiet = new System.Windows.Forms.Button();
            this.grbDanhMucSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDMAnhSP)).BeginInit();
            this.grbDanhSachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDanhMucSP
            // 
            this.grbDanhMucSP.Controls.Add(this.btnDMThem);
            this.grbDanhMucSP.Controls.Add(this.ptbDMAnhSP);
            this.grbDanhMucSP.Controls.Add(this.txtDMAnhLoad);
            this.grbDanhMucSP.Controls.Add(this.btnDMTim);
            this.grbDanhMucSP.Controls.Add(this.btnDMReset);
            this.grbDanhMucSP.Controls.Add(this.btnDMXoa);
            this.grbDanhMucSP.Controls.Add(this.txtDMTimKiem);
            this.grbDanhMucSP.Controls.Add(this.cmbDMTheLoai);
            this.grbDanhMucSP.Controls.Add(this.label5);
            this.grbDanhMucSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDanhMucSP.Location = new System.Drawing.Point(0, 0);
            this.grbDanhMucSP.Name = "grbDanhMucSP";
            this.grbDanhMucSP.Size = new System.Drawing.Size(892, 307);
            this.grbDanhMucSP.TabIndex = 0;
            this.grbDanhMucSP.TabStop = false;
            this.grbDanhMucSP.Text = "Danh mục sản phẩm";
            // 
            // btnDMThem
            // 
            this.btnDMThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDMThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMThem.Location = new System.Drawing.Point(714, 61);
            this.btnDMThem.Name = "btnDMThem";
            this.btnDMThem.Size = new System.Drawing.Size(115, 44);
            this.btnDMThem.TabIndex = 49;
            this.btnDMThem.Text = "Thêm";
            this.btnDMThem.UseVisualStyleBackColor = true;
            this.btnDMThem.Click += new System.EventHandler(this.btnDMThem_Click);
            // 
            // ptbDMAnhSP
            // 
            this.ptbDMAnhSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptbDMAnhSP.Location = new System.Drawing.Point(6, 29);
            this.ptbDMAnhSP.Name = "ptbDMAnhSP";
            this.ptbDMAnhSP.Size = new System.Drawing.Size(321, 223);
            this.ptbDMAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDMAnhSP.TabIndex = 48;
            this.ptbDMAnhSP.TabStop = false;
            // 
            // txtDMAnhLoad
            // 
            this.txtDMAnhLoad.Location = new System.Drawing.Point(37, 264);
            this.txtDMAnhLoad.Name = "txtDMAnhLoad";
            this.txtDMAnhLoad.ReadOnly = true;
            this.txtDMAnhLoad.Size = new System.Drawing.Size(233, 30);
            this.txtDMAnhLoad.TabIndex = 47;
            // 
            // btnDMTim
            // 
            this.btnDMTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMTim.Location = new System.Drawing.Point(419, 186);
            this.btnDMTim.Name = "btnDMTim";
            this.btnDMTim.Size = new System.Drawing.Size(114, 43);
            this.btnDMTim.TabIndex = 46;
            this.btnDMTim.Text = "Tìm";
            this.btnDMTim.UseVisualStyleBackColor = true;
            this.btnDMTim.Click += new System.EventHandler(this.btnDMTim_Click);
            // 
            // btnDMReset
            // 
            this.btnDMReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDMReset.Location = new System.Drawing.Point(714, 188);
            this.btnDMReset.Name = "btnDMReset";
            this.btnDMReset.Size = new System.Drawing.Size(115, 51);
            this.btnDMReset.TabIndex = 44;
            this.btnDMReset.Text = "Reset";
            this.btnDMReset.UseVisualStyleBackColor = true;
            this.btnDMReset.Click += new System.EventHandler(this.btnDMReset_Click);
            // 
            // btnDMXoa
            // 
            this.btnDMXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDMXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMXoa.Location = new System.Drawing.Point(714, 123);
            this.btnDMXoa.Name = "btnDMXoa";
            this.btnDMXoa.Size = new System.Drawing.Size(115, 51);
            this.btnDMXoa.TabIndex = 43;
            this.btnDMXoa.Text = "Xóa";
            this.btnDMXoa.UseVisualStyleBackColor = true;
            // 
            // txtDMTimKiem
            // 
            this.txtDMTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDMTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDMTimKiem.Location = new System.Drawing.Point(366, 118);
            this.txtDMTimKiem.Name = "txtDMTimKiem";
            this.txtDMTimKiem.Size = new System.Drawing.Size(237, 30);
            this.txtDMTimKiem.TabIndex = 42;
            this.txtDMTimKiem.Text = "Tìm kiếm";
            this.txtDMTimKiem.Enter += new System.EventHandler(this.txtDMTimKiem_Enter);
            this.txtDMTimKiem.Leave += new System.EventHandler(this.txtDMTimKiem_Leave);
            // 
            // cmbDMTheLoai
            // 
            this.cmbDMTheLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDMTheLoai.FormattingEnabled = true;
            this.cmbDMTheLoai.Location = new System.Drawing.Point(366, 61);
            this.cmbDMTheLoai.Name = "cmbDMTheLoai";
            this.cmbDMTheLoai.Size = new System.Drawing.Size(184, 30);
            this.cmbDMTheLoai.TabIndex = 40;
            this.cmbDMTheLoai.SelectedIndexChanged += new System.EventHandler(this.cmbDMTheLoai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Danh mục";
            // 
            // grbDanhSachSP
            // 
            this.grbDanhSachSP.Controls.Add(this.dgvDanhSachSP);
            this.grbDanhSachSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDanhSachSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachSP.Location = new System.Drawing.Point(0, 307);
            this.grbDanhSachSP.Name = "grbDanhSachSP";
            this.grbDanhSachSP.Size = new System.Drawing.Size(892, 295);
            this.grbDanhSachSP.TabIndex = 9;
            this.grbDanhSachSP.TabStop = false;
            this.grbDanhSachSP.Text = "Danh sách sản phẩm";
            // 
            // dgvDanhSachSP
            // 
            this.dgvDanhSachSP.AllowUserToOrderColumns = true;
            this.dgvDanhSachSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSP.Location = new System.Drawing.Point(3, 29);
            this.dgvDanhSachSP.Name = "dgvDanhSachSP";
            this.dgvDanhSachSP.RowHeadersWidth = 51;
            this.dgvDanhSachSP.RowTemplate.Height = 24;
            this.dgvDanhSachSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSP.Size = new System.Drawing.Size(886, 260);
            this.dgvDanhSachSP.TabIndex = 1;
            this.dgvDanhSachSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSP_CellClick);
            this.dgvDanhSachSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSP_CellContentClick);
            // 
            // btnDMChiTiet
            // 
            this.btnDMChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMChiTiet.Location = new System.Drawing.Point(748, 608);
            this.btnDMChiTiet.Name = "btnDMChiTiet";
            this.btnDMChiTiet.Size = new System.Drawing.Size(141, 39);
            this.btnDMChiTiet.TabIndex = 10;
            this.btnDMChiTiet.Text = "Chi tiết";
            this.btnDMChiTiet.UseVisualStyleBackColor = true;
            this.btnDMChiTiet.Click += new System.EventHandler(this.btnDMChiTiet_Click);
            // 
            // DanhMucSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 656);
            this.Controls.Add(this.btnDMChiTiet);
            this.Controls.Add(this.grbDanhSachSP);
            this.Controls.Add(this.grbDanhMucSP);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DanhMucSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục sản phẩm";
            this.grbDanhMucSP.ResumeLayout(false);
            this.grbDanhMucSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDMAnhSP)).EndInit();
            this.grbDanhSachSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhMucSP;
        private System.Windows.Forms.Button btnDMThem;
        private System.Windows.Forms.PictureBox ptbDMAnhSP;
        private System.Windows.Forms.TextBox txtDMAnhLoad;
        private System.Windows.Forms.Button btnDMTim;
        private System.Windows.Forms.Button btnDMReset;
        private System.Windows.Forms.Button btnDMXoa;
        private System.Windows.Forms.TextBox txtDMTimKiem;
        private System.Windows.Forms.ComboBox cmbDMTheLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbDanhSachSP;
        private System.Windows.Forms.DataGridView dgvDanhSachSP;
        private System.Windows.Forms.Button btnDMChiTiet;
    }
}