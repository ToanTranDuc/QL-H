namespace GUI
{
    partial class Contract
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
            this.grbHDTTCoBan = new System.Windows.Forms.GroupBox();
            this.btnHDThem = new System.Windows.Forms.Button();
            this.btnHDTim = new System.Windows.Forms.Button();
            this.btnHDReset = new System.Windows.Forms.Button();
            this.btnHDXoa = new System.Windows.Forms.Button();
            this.txtHDNguoiKy = new System.Windows.Forms.TextBox();
            this.txtHDNgayKy = new System.Windows.Forms.TextBox();
            this.txtHDTimKiem = new System.Windows.Forms.TextBox();
            this.txtHDTenHD = new System.Windows.Forms.TextBox();
            this.txtHDMHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbHDNCC = new System.Windows.Forms.GroupBox();
            this.dgvHDDSNCC = new System.Windows.Forms.DataGridView();
            this.btnHDChiTiet = new System.Windows.Forms.Button();
            this.grbHDTTCoBan.SuspendLayout();
            this.grbHDNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDSNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHDTTCoBan
            // 
            this.grbHDTTCoBan.Controls.Add(this.btnHDThem);
            this.grbHDTTCoBan.Controls.Add(this.btnHDTim);
            this.grbHDTTCoBan.Controls.Add(this.btnHDReset);
            this.grbHDTTCoBan.Controls.Add(this.btnHDXoa);
            this.grbHDTTCoBan.Controls.Add(this.txtHDNguoiKy);
            this.grbHDTTCoBan.Controls.Add(this.txtHDNgayKy);
            this.grbHDTTCoBan.Controls.Add(this.txtHDTimKiem);
            this.grbHDTTCoBan.Controls.Add(this.txtHDTenHD);
            this.grbHDTTCoBan.Controls.Add(this.txtHDMHD);
            this.grbHDTTCoBan.Controls.Add(this.label4);
            this.grbHDTTCoBan.Controls.Add(this.label3);
            this.grbHDTTCoBan.Controls.Add(this.label5);
            this.grbHDTTCoBan.Controls.Add(this.label2);
            this.grbHDTTCoBan.Controls.Add(this.label1);
            this.grbHDTTCoBan.Location = new System.Drawing.Point(57, 46);
            this.grbHDTTCoBan.Name = "grbHDTTCoBan";
            this.grbHDTTCoBan.Size = new System.Drawing.Size(831, 262);
            this.grbHDTTCoBan.TabIndex = 0;
            this.grbHDTTCoBan.TabStop = false;
            this.grbHDTTCoBan.Text = "Thông tin cơ bản ";
            // 
            // btnHDThem
            // 
            this.btnHDThem.Image = global::GUI.Properties.Resources.icons8_add_list_24;
            this.btnHDThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDThem.Location = new System.Drawing.Point(715, 50);
            this.btnHDThem.Name = "btnHDThem";
            this.btnHDThem.Size = new System.Drawing.Size(110, 52);
            this.btnHDThem.TabIndex = 2;
            this.btnHDThem.Text = "   Thêm";
            this.btnHDThem.UseVisualStyleBackColor = true;
            // 
            // btnHDTim
            // 
            this.btnHDTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDTim.Location = new System.Drawing.Point(418, 181);
            this.btnHDTim.Name = "btnHDTim";
            this.btnHDTim.Size = new System.Drawing.Size(101, 42);
            this.btnHDTim.TabIndex = 2;
            this.btnHDTim.Text = "Tìm";
            this.btnHDTim.UseVisualStyleBackColor = true;
            this.btnHDTim.Click += new System.EventHandler(this.btnHDTim_Click);
            // 
            // btnHDReset
            // 
            this.btnHDReset.Image = global::GUI.Properties.Resources.icons8_refresh_32;
            this.btnHDReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDReset.Location = new System.Drawing.Point(713, 181);
            this.btnHDReset.Name = "btnHDReset";
            this.btnHDReset.Size = new System.Drawing.Size(110, 52);
            this.btnHDReset.TabIndex = 2;
            this.btnHDReset.Text = "    Reset";
            this.btnHDReset.UseVisualStyleBackColor = true;
            this.btnHDReset.Click += new System.EventHandler(this.btnHDReset_Click);
            // 
            // btnHDXoa
            // 
            this.btnHDXoa.Image = global::GUI.Properties.Resources.icons8_remove_24;
            this.btnHDXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDXoa.Location = new System.Drawing.Point(713, 114);
            this.btnHDXoa.Name = "btnHDXoa";
            this.btnHDXoa.Size = new System.Drawing.Size(110, 52);
            this.btnHDXoa.TabIndex = 2;
            this.btnHDXoa.Text = "Xóa";
            this.btnHDXoa.UseVisualStyleBackColor = true;
            this.btnHDXoa.Click += new System.EventHandler(this.btnHDXoa_Click);
            // 
            // txtHDNguoiKy
            // 
            this.txtHDNguoiKy.Location = new System.Drawing.Point(505, 111);
            this.txtHDNguoiKy.Name = "txtHDNguoiKy";
            this.txtHDNguoiKy.Size = new System.Drawing.Size(192, 35);
            this.txtHDNguoiKy.TabIndex = 1;
            // 
            // txtHDNgayKy
            // 
            this.txtHDNgayKy.Location = new System.Drawing.Point(505, 57);
            this.txtHDNgayKy.Name = "txtHDNgayKy";
            this.txtHDNgayKy.Size = new System.Drawing.Size(192, 35);
            this.txtHDNgayKy.TabIndex = 1;
            // 
            // txtHDTimKiem
            // 
            this.txtHDTimKiem.Location = new System.Drawing.Point(198, 188);
            this.txtHDTimKiem.Name = "txtHDTimKiem";
            this.txtHDTimKiem.Size = new System.Drawing.Size(192, 35);
            this.txtHDTimKiem.TabIndex = 1;
            // 
            // txtHDTenHD
            // 
            this.txtHDTenHD.Location = new System.Drawing.Point(198, 111);
            this.txtHDTenHD.Name = "txtHDTenHD";
            this.txtHDTenHD.Size = new System.Drawing.Size(192, 35);
            this.txtHDTenHD.TabIndex = 1;
            // 
            // txtHDMHD
            // 
            this.txtHDMHD.Location = new System.Drawing.Point(198, 62);
            this.txtHDMHD.Name = "txtHDMHD";
            this.txtHDMHD.Size = new System.Drawing.Size(192, 35);
            this.txtHDMHD.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Người ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hợp đồng";
            // 
            // grbHDNCC
            // 
            this.grbHDNCC.Controls.Add(this.dgvHDDSNCC);
            this.grbHDNCC.Location = new System.Drawing.Point(57, 314);
            this.grbHDNCC.Name = "grbHDNCC";
            this.grbHDNCC.Size = new System.Drawing.Size(823, 249);
            this.grbHDNCC.TabIndex = 1;
            this.grbHDNCC.TabStop = false;
            this.grbHDNCC.Text = "Danh sách hợp đồng";
            // 
            // dgvHDDSNCC
            // 
            this.dgvHDDSNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHDDSNCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHDDSNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDDSNCC.Location = new System.Drawing.Point(6, 29);
            this.dgvHDDSNCC.Name = "dgvHDDSNCC";
            this.dgvHDDSNCC.RowHeadersWidth = 51;
            this.dgvHDDSNCC.RowTemplate.Height = 24;
            this.dgvHDDSNCC.Size = new System.Drawing.Size(819, 210);
            this.dgvHDDSNCC.TabIndex = 0;
            this.dgvHDDSNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDDSNCC_CellContentClick);
            // 
            // btnHDChiTiet
            // 
            this.btnHDChiTiet.Image = global::GUI.Properties.Resources.icons8_details_32;
            this.btnHDChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDChiTiet.Location = new System.Drawing.Point(764, 569);
            this.btnHDChiTiet.Name = "btnHDChiTiet";
            this.btnHDChiTiet.Size = new System.Drawing.Size(116, 52);
            this.btnHDChiTiet.TabIndex = 2;
            this.btnHDChiTiet.TabStop = false;
            this.btnHDChiTiet.Text = "    Chi tiết";
            this.btnHDChiTiet.UseVisualStyleBackColor = true;
            this.btnHDChiTiet.Click += new System.EventHandler(this.btnHDChiTiet_Click);
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 656);
            this.Controls.Add(this.btnHDChiTiet);
            this.Controls.Add(this.grbHDNCC);
            this.Controls.Add(this.grbHDTTCoBan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Contract";
            this.Text = "Hợp đồng";
            this.Load += new System.EventHandler(this.Contract_Load);
            this.grbHDTTCoBan.ResumeLayout(false);
            this.grbHDTTCoBan.PerformLayout();
            this.grbHDNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDSNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHDTTCoBan;
        private System.Windows.Forms.GroupBox grbHDNCC;
        private System.Windows.Forms.Button btnHDChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHDNguoiKy;
        private System.Windows.Forms.TextBox txtHDNgayKy;
        private System.Windows.Forms.TextBox txtHDTenHD;
        private System.Windows.Forms.TextBox txtHDMHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHDThem;
        private System.Windows.Forms.Button btnHDReset;
        private System.Windows.Forms.Button btnHDXoa;
        private System.Windows.Forms.Button btnHDTim;
        private System.Windows.Forms.TextBox txtHDTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHDDSNCC;
    }
}