namespace GUI
{
    partial class InforNCC
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
            this.grbDanhSachNCC = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNCC = new System.Windows.Forms.DataGridView();
            this.grbTacVu = new System.Windows.Forms.GroupBox();
            this.btnTTim = new System.Windows.Forms.Button();
            this.cmbTGTTim = new System.Windows.Forms.ComboBox();
            this.txtTTimKiem = new System.Windows.Forms.TextBox();
            this.btnInForReset = new System.Windows.Forms.Button();
            this.btnInFoXoa = new System.Windows.Forms.Button();
            this.btnInFoThem = new System.Windows.Forms.Button();
            this.btnInFoChiTiet = new System.Windows.Forms.Button();
            this.grbDanhSachNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNCC)).BeginInit();
            this.grbTacVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhSachNCC
            // 
            this.grbDanhSachNCC.Controls.Add(this.dgvDanhSachNCC);
            this.grbDanhSachNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDanhSachNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachNCC.Location = new System.Drawing.Point(0, 0);
            this.grbDanhSachNCC.Name = "grbDanhSachNCC";
            this.grbDanhSachNCC.Size = new System.Drawing.Size(892, 411);
            this.grbDanhSachNCC.TabIndex = 9;
            this.grbDanhSachNCC.TabStop = false;
            this.grbDanhSachNCC.Text = "Danh sách các nhà cung cấp";
            // 
            // dgvDanhSachNCC
            // 
            this.dgvDanhSachNCC.AllowUserToOrderColumns = true;
            this.dgvDanhSachNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachNCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNCC.Location = new System.Drawing.Point(3, 29);
            this.dgvDanhSachNCC.Name = "dgvDanhSachNCC";
            this.dgvDanhSachNCC.RowHeadersWidth = 51;
            this.dgvDanhSachNCC.RowTemplate.Height = 24;
            this.dgvDanhSachNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNCC.Size = new System.Drawing.Size(886, 382);
            this.dgvDanhSachNCC.TabIndex = 1;
            // 
            // grbTacVu
            // 
            this.grbTacVu.Controls.Add(this.btnInForReset);
            this.grbTacVu.Controls.Add(this.btnInFoXoa);
            this.grbTacVu.Controls.Add(this.btnInFoThem);
            this.grbTacVu.Controls.Add(this.btnInFoChiTiet);
            this.grbTacVu.Location = new System.Drawing.Point(126, 494);
            this.grbTacVu.Name = "grbTacVu";
            this.grbTacVu.Size = new System.Drawing.Size(630, 121);
            this.grbTacVu.TabIndex = 10;
            this.grbTacVu.TabStop = false;
            this.grbTacVu.Text = "Tác vụ";
            // 
            // btnTTim
            // 
            this.btnTTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTim.Location = new System.Drawing.Point(617, 438);
            this.btnTTim.Name = "btnTTim";
            this.btnTTim.Size = new System.Drawing.Size(114, 43);
            this.btnTTim.TabIndex = 25;
            this.btnTTim.Text = "Tìm";
            this.btnTTim.UseVisualStyleBackColor = true;
            this.btnTTim.Click += new System.EventHandler(this.btnTTim_Click);
            // 
            // cmbTGTTim
            // 
            this.cmbTGTTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTGTTim.FormattingEnabled = true;
            this.cmbTGTTim.Location = new System.Drawing.Point(121, 437);
            this.cmbTGTTim.Name = "cmbTGTTim";
            this.cmbTGTTim.Size = new System.Drawing.Size(149, 30);
            this.cmbTGTTim.TabIndex = 24;
            this.cmbTGTTim.Text = "Giá trị tìm";
            this.cmbTGTTim.Enter += new System.EventHandler(this.cmbTGTTim_Enter);
            this.cmbTGTTim.Leave += new System.EventHandler(this.cmbTGTTim_Leave);
            // 
            // txtTTimKiem
            // 
            this.txtTTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTimKiem.Location = new System.Drawing.Point(317, 438);
            this.txtTTimKiem.Name = "txtTTimKiem";
            this.txtTTimKiem.Size = new System.Drawing.Size(250, 30);
            this.txtTTimKiem.TabIndex = 23;
            this.txtTTimKiem.Text = "Tìm kiếm";
            this.txtTTimKiem.Enter += new System.EventHandler(this.txtTTimKiem_Enter);
            this.txtTTimKiem.Leave += new System.EventHandler(this.txtTTimKiem_Leave);
            // 
            // btnInForReset
            // 
            this.btnInForReset.Image = global::GUI.Properties.Resources.icons8_refresh_32;
            this.btnInForReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInForReset.Location = new System.Drawing.Point(491, 47);
            this.btnInForReset.Name = "btnInForReset";
            this.btnInForReset.Size = new System.Drawing.Size(127, 50);
            this.btnInForReset.TabIndex = 0;
            this.btnInForReset.Text = "    Reset";
            this.btnInForReset.UseVisualStyleBackColor = true;
            this.btnInForReset.Click += new System.EventHandler(this.btnInForReset_Click);
            // 
            // btnInFoXoa
            // 
            this.btnInFoXoa.Image = global::GUI.Properties.Resources.icons8_remove_24;
            this.btnInFoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInFoXoa.Location = new System.Drawing.Point(342, 47);
            this.btnInFoXoa.Name = "btnInFoXoa";
            this.btnInFoXoa.Size = new System.Drawing.Size(127, 50);
            this.btnInFoXoa.TabIndex = 0;
            this.btnInFoXoa.Text = "    Xóa";
            this.btnInFoXoa.UseVisualStyleBackColor = true;
            this.btnInFoXoa.Click += new System.EventHandler(this.btnInFoXoa_Click);
            // 
            // btnInFoThem
            // 
            this.btnInFoThem.Image = global::GUI.Properties.Resources.icons8_add_list_24;
            this.btnInFoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInFoThem.Location = new System.Drawing.Point(194, 47);
            this.btnInFoThem.Name = "btnInFoThem";
            this.btnInFoThem.Size = new System.Drawing.Size(127, 50);
            this.btnInFoThem.TabIndex = 0;
            this.btnInFoThem.Text = "      Thêm ";
            this.btnInFoThem.UseVisualStyleBackColor = true;
            this.btnInFoThem.Click += new System.EventHandler(this.btnInFoThem_Click);
            // 
            // btnInFoChiTiet
            // 
            this.btnInFoChiTiet.Image = global::GUI.Properties.Resources.icons8_details_32;
            this.btnInFoChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInFoChiTiet.Location = new System.Drawing.Point(28, 47);
            this.btnInFoChiTiet.Name = "btnInFoChiTiet";
            this.btnInFoChiTiet.Size = new System.Drawing.Size(127, 50);
            this.btnInFoChiTiet.TabIndex = 0;
            this.btnInFoChiTiet.Text = "      Chi tiết";
            this.btnInFoChiTiet.UseVisualStyleBackColor = true;
            this.btnInFoChiTiet.Click += new System.EventHandler(this.btnInFoChiTiet_Click);
            // 
            // InforNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 656);
            this.Controls.Add(this.btnTTim);
            this.Controls.Add(this.cmbTGTTim);
            this.Controls.Add(this.txtTTimKiem);
            this.Controls.Add(this.grbTacVu);
            this.Controls.Add(this.grbDanhSachNCC);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InforNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhà cung cấp";
            this.Load += new System.EventHandler(this.InforNCC_Load);
            this.grbDanhSachNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNCC)).EndInit();
            this.grbTacVu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachNCC;
        private System.Windows.Forms.DataGridView dgvDanhSachNCC;
        private System.Windows.Forms.GroupBox grbTacVu;
        private System.Windows.Forms.Button btnInFoXoa;
        private System.Windows.Forms.Button btnInFoThem;
        private System.Windows.Forms.Button btnInFoChiTiet;
        private System.Windows.Forms.Button btnTTim;
        private System.Windows.Forms.ComboBox cmbTGTTim;
        private System.Windows.Forms.TextBox txtTTimKiem;
        private System.Windows.Forms.Button btnInForReset;
    }
}