namespace GUI
{
    partial class ThemHopDong
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
            this.btnCTDong = new System.Windows.Forms.Button();
            this.dtpCTHDNHH = new System.Windows.Forms.DateTimePicker();
            this.dtpCTHDNgayKy = new System.Windows.Forms.DateTimePicker();
            this.dtpCTHDNHL = new System.Windows.Forms.DateTimePicker();
            this.btnCTHDHuy = new System.Windows.Forms.Button();
            this.txtCTHDNguoiKy = new System.Windows.Forms.TextBox();
            this.txtCTHDGiaTri = new System.Windows.Forms.TextBox();
            this.txtCTHDMoTa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCTHDTenHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCTHDMHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbCTHopDong = new System.Windows.Forms.GroupBox();
            this.cmbTTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTHD = new System.Windows.Forms.Button();
            this.cmbTTenNCC = new System.Windows.Forms.ComboBox();
            this.grbCTHopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCTDong
            // 
            this.btnCTDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTDong.Location = new System.Drawing.Point(783, 377);
            this.btnCTDong.Name = "btnCTDong";
            this.btnCTDong.Size = new System.Drawing.Size(110, 52);
            this.btnCTDong.TabIndex = 12;
            this.btnCTDong.Text = "Đóng";
            this.btnCTDong.UseVisualStyleBackColor = true;
            this.btnCTDong.Click += new System.EventHandler(this.btnCTDong_Click);
            // 
            // dtpCTHDNHH
            // 
            this.dtpCTHDNHH.Location = new System.Drawing.Point(161, 260);
            this.dtpCTHDNHH.Name = "dtpCTHDNHH";
            this.dtpCTHDNHH.Size = new System.Drawing.Size(200, 30);
            this.dtpCTHDNHH.TabIndex = 12;
            // 
            // dtpCTHDNgayKy
            // 
            this.dtpCTHDNgayKy.Location = new System.Drawing.Point(468, 48);
            this.dtpCTHDNgayKy.Name = "dtpCTHDNgayKy";
            this.dtpCTHDNgayKy.Size = new System.Drawing.Size(200, 30);
            this.dtpCTHDNgayKy.TabIndex = 12;
            // 
            // dtpCTHDNHL
            // 
            this.dtpCTHDNHL.Location = new System.Drawing.Point(161, 207);
            this.dtpCTHDNHL.Name = "dtpCTHDNHL";
            this.dtpCTHDNHL.Size = new System.Drawing.Size(200, 30);
            this.dtpCTHDNHL.TabIndex = 12;
            // 
            // btnCTHDHuy
            // 
            this.btnCTHDHuy.Image = global::GUI.Properties.Resources.icons8_cancel_32;
            this.btnCTHDHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTHDHuy.Location = new System.Drawing.Point(439, 377);
            this.btnCTHDHuy.Name = "btnCTHDHuy";
            this.btnCTHDHuy.Size = new System.Drawing.Size(110, 52);
            this.btnCTHDHuy.TabIndex = 10;
            this.btnCTHDHuy.Text = "   Hủy";
            this.btnCTHDHuy.UseVisualStyleBackColor = true;
            this.btnCTHDHuy.Click += new System.EventHandler(this.btnCTHDHuy_Click);
            // 
            // txtCTHDNguoiKy
            // 
            this.txtCTHDNguoiKy.Location = new System.Drawing.Point(468, 94);
            this.txtCTHDNguoiKy.Name = "txtCTHDNguoiKy";
            this.txtCTHDNguoiKy.Size = new System.Drawing.Size(200, 30);
            this.txtCTHDNguoiKy.TabIndex = 6;
            // 
            // txtCTHDGiaTri
            // 
            this.txtCTHDGiaTri.Location = new System.Drawing.Point(468, 150);
            this.txtCTHDGiaTri.Name = "txtCTHDGiaTri";
            this.txtCTHDGiaTri.Size = new System.Drawing.Size(200, 30);
            this.txtCTHDGiaTri.TabIndex = 7;
            // 
            // txtCTHDMoTa
            // 
            this.txtCTHDMoTa.Location = new System.Drawing.Point(161, 155);
            this.txtCTHDMoTa.Name = "txtCTHDMoTa";
            this.txtCTHDMoTa.Size = new System.Drawing.Size(192, 30);
            this.txtCTHDMoTa.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên nhà cùng cấp";
            // 
            // txtCTHDTenHD
            // 
            this.txtCTHDTenHD.Location = new System.Drawing.Point(161, 94);
            this.txtCTHDTenHD.Name = "txtCTHDTenHD";
            this.txtCTHDTenHD.Size = new System.Drawing.Size(192, 30);
            this.txtCTHDTenHD.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Trạng thái";
            // 
            // txtCTHDMHD
            // 
            this.txtCTHDMHD.Location = new System.Drawing.Point(161, 45);
            this.txtCTHDMHD.Name = "txtCTHDMHD";
            this.txtCTHDMHD.ReadOnly = true;
            this.txtCTHDMHD.Size = new System.Drawing.Size(192, 30);
            this.txtCTHDMHD.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giá trị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày hết hạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Người ký";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày hiệu lực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã hợp đồng";
            // 
            // grbCTHopDong
            // 
            this.grbCTHopDong.Controls.Add(this.cmbTTenNCC);
            this.grbCTHopDong.Controls.Add(this.cmbTTrangThai);
            this.grbCTHopDong.Controls.Add(this.dtpCTHDNHH);
            this.grbCTHopDong.Controls.Add(this.dtpCTHDNgayKy);
            this.grbCTHopDong.Controls.Add(this.dtpCTHDNHL);
            this.grbCTHopDong.Controls.Add(this.txtCTHDNguoiKy);
            this.grbCTHopDong.Controls.Add(this.txtCTHDGiaTri);
            this.grbCTHopDong.Controls.Add(this.txtCTHDMoTa);
            this.grbCTHopDong.Controls.Add(this.label10);
            this.grbCTHopDong.Controls.Add(this.txtCTHDTenHD);
            this.grbCTHopDong.Controls.Add(this.label8);
            this.grbCTHopDong.Controls.Add(this.txtCTHDMHD);
            this.grbCTHopDong.Controls.Add(this.label7);
            this.grbCTHopDong.Controls.Add(this.label9);
            this.grbCTHopDong.Controls.Add(this.label4);
            this.grbCTHopDong.Controls.Add(this.label6);
            this.grbCTHopDong.Controls.Add(this.label3);
            this.grbCTHopDong.Controls.Add(this.label5);
            this.grbCTHopDong.Controls.Add(this.label2);
            this.grbCTHopDong.Controls.Add(this.label1);
            this.grbCTHopDong.Location = new System.Drawing.Point(25, 12);
            this.grbCTHopDong.Name = "grbCTHopDong";
            this.grbCTHopDong.Size = new System.Drawing.Size(868, 337);
            this.grbCTHopDong.TabIndex = 11;
            this.grbCTHopDong.TabStop = false;
            this.grbCTHopDong.Text = "Thông tin chi tiết hợp đồng";
            // 
            // cmbTTrangThai
            // 
            this.cmbTTrangThai.FormattingEnabled = true;
            this.cmbTTrangThai.Location = new System.Drawing.Point(468, 199);
            this.cmbTTrangThai.Name = "cmbTTrangThai";
            this.cmbTTrangThai.Size = new System.Drawing.Size(200, 30);
            this.cmbTTrangThai.TabIndex = 13;
            // 
            // btnTHD
            // 
            this.btnTHD.Image = global::GUI.Properties.Resources.icons8_add_list_24;
            this.btnTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTHD.Location = new System.Drawing.Point(602, 377);
            this.btnTHD.Name = "btnTHD";
            this.btnTHD.Size = new System.Drawing.Size(110, 52);
            this.btnTHD.TabIndex = 10;
            this.btnTHD.Text = "Lưu";
            this.btnTHD.UseVisualStyleBackColor = true;
            this.btnTHD.Click += new System.EventHandler(this.btnTHD_Click);
            // 
            // cmbTTenNCC
            // 
            this.cmbTTenNCC.FormattingEnabled = true;
            this.cmbTTenNCC.Location = new System.Drawing.Point(547, 263);
            this.cmbTTenNCC.Name = "cmbTTenNCC";
            this.cmbTTenNCC.Size = new System.Drawing.Size(181, 30);
            this.cmbTTenNCC.TabIndex = 14;
            // 
            // ThemHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 551);
            this.Controls.Add(this.btnCTDong);
            this.Controls.Add(this.grbCTHopDong);
            this.Controls.Add(this.btnTHD);
            this.Controls.Add(this.btnCTHDHuy);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hợp đồng";
            this.grbCTHopDong.ResumeLayout(false);
            this.grbCTHopDong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCTDong;
        private System.Windows.Forms.DateTimePicker dtpCTHDNHH;
        private System.Windows.Forms.DateTimePicker dtpCTHDNgayKy;
        private System.Windows.Forms.DateTimePicker dtpCTHDNHL;
        private System.Windows.Forms.Button btnCTHDHuy;
        private System.Windows.Forms.TextBox txtCTHDNguoiKy;
        private System.Windows.Forms.TextBox txtCTHDGiaTri;
        private System.Windows.Forms.TextBox txtCTHDMoTa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCTHDTenHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCTHDMHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbCTHopDong;
        private System.Windows.Forms.Button btnTHD;
        private System.Windows.Forms.ComboBox cmbTTrangThai;
        private System.Windows.Forms.ComboBox cmbTTenNCC;
    }
}