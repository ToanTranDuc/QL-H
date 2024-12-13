namespace GUI
{
    partial class XuatKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbDateStart = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dtgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.lbDanhSach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grbTimKiem);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lbDanhSach);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 434);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.btnDeleteItem);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Location = new System.Drawing.Point(9, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 49);
            this.panel2.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(601, 18);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 28);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(520, 18);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Xóa";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(682, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 28);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.dtpEnd);
            this.grbTimKiem.Controls.Add(this.label1);
            this.grbTimKiem.Controls.Add(this.dtpStart);
            this.grbTimKiem.Controls.Add(this.btnRefresh);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.lbDateStart);
            this.grbTimKiem.Location = new System.Drawing.Point(17, 35);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(752, 108);
            this.grbTimKiem.TabIndex = 3;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(469, 52);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(196, 20);
            this.dtpEnd.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(349, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày kết thúc :";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(137, 51);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(196, 20);
            this.dtpStart.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(671, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(671, 32);
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
            this.lbDateStart.Location = new System.Drawing.Point(23, 48);
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
            this.panel5.Size = new System.Drawing.Size(760, 209);
            this.panel5.TabIndex = 5;
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dtgvPhieuXuat);
            this.grbDanhSach.Location = new System.Drawing.Point(4, 13);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(753, 177);
            this.grbDanhSach.TabIndex = 4;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách";
            // 
            // dtgvPhieuXuat
            // 
            this.dtgvPhieuXuat.AllowUserToAddRows = false;
            this.dtgvPhieuXuat.AllowUserToDeleteRows = false;
            this.dtgvPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvPhieuXuat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhieuXuat.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvPhieuXuat.Location = new System.Drawing.Point(16, 19);
            this.dtgvPhieuXuat.Name = "dtgvPhieuXuat";
            this.dtgvPhieuXuat.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhieuXuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvPhieuXuat.Size = new System.Drawing.Size(723, 154);
            this.dtgvPhieuXuat.TabIndex = 0;
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbDanhSach.Location = new System.Drawing.Point(273, 0);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(265, 41);
            this.lbDanhSach.TabIndex = 2;
            this.lbDanhSach.Text = "Danh sách phiếu xuất";
            // 
            // XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "XuatKho";
            this.Text = "XuatKho";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbDateStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dtgvPhieuXuat;
        private System.Windows.Forms.Label lbDanhSach;
    }
}