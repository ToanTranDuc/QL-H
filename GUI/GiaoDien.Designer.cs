namespace GUI
{
    partial class GiaoDien
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
            this.QLNCCContainer = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.QLSPTimer = new System.Windows.Forms.Timer(this.components);
            this.QLSPContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.sidebarControl = new System.Windows.Forms.FlowLayoutPanel();
            this.QLNCCTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGDSanPham = new System.Windows.Forms.Button();
            this.btnGĐanhMucSP = new System.Windows.Forms.Button();
            this.btnGDQLSP = new System.Windows.Forms.Button();
            this.btnGDQLNCC = new System.Windows.Forms.Button();
            this.btnDGThongTinNCC = new System.Windows.Forms.Button();
            this.QLNCCContainer.SuspendLayout();
            this.QLSPContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidebarControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QLNCCContainer
            // 
            this.QLNCCContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QLNCCContainer.Controls.Add(this.btnGDQLNCC);
            this.QLNCCContainer.Controls.Add(this.btnDGThongTinNCC);
            this.QLNCCContainer.Location = new System.Drawing.Point(3, 208);
            this.QLNCCContainer.MaximumSize = new System.Drawing.Size(292, 129);
            this.QLNCCContainer.MinimumSize = new System.Drawing.Size(292, 64);
            this.QLNCCContainer.Name = "QLNCCContainer";
            this.QLNCCContainer.Size = new System.Drawing.Size(292, 64);
            this.QLNCCContainer.TabIndex = 1;
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(290, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(910, 703);
            this.panel_body.TabIndex = 1;
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 5;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // QLSPTimer
            // 
            this.QLSPTimer.Interval = 10;
            this.QLSPTimer.Tick += new System.EventHandler(this.QLSPTimer_Tick_1);
            // 
            // QLSPContainer
            // 
            this.QLSPContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QLSPContainer.Controls.Add(this.btnGDSanPham);
            this.QLSPContainer.Controls.Add(this.btnGĐanhMucSP);
            this.QLSPContainer.Controls.Add(this.btnGDQLSP);
            this.QLSPContainer.Location = new System.Drawing.Point(3, 142);
            this.QLSPContainer.MaximumSize = new System.Drawing.Size(292, 177);
            this.QLSPContainer.MinimumSize = new System.Drawing.Size(292, 60);
            this.QLSPContainer.Name = "QLSPContainer";
            this.QLSPContainer.Size = new System.Drawing.Size(292, 60);
            this.QLSPContainer.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 133);
            this.panel2.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.ForeColor = System.Drawing.Color.LightCoral;
            this.btnMenu.Location = new System.Drawing.Point(3, 78);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(73, 43);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // sidebarControl
            // 
            this.sidebarControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidebarControl.Controls.Add(this.panel2);
            this.sidebarControl.Controls.Add(this.QLSPContainer);
            this.sidebarControl.Controls.Add(this.QLNCCContainer);
            this.sidebarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl.MaximumSize = new System.Drawing.Size(290, 703);
            this.sidebarControl.MinimumSize = new System.Drawing.Size(65, 703);
            this.sidebarControl.Name = "sidebarControl";
            this.sidebarControl.Size = new System.Drawing.Size(290, 703);
            this.sidebarControl.TabIndex = 0;
            // 
            // QLNCCTimer
            // 
            this.QLNCCTimer.Interval = 10;
            this.QLNCCTimer.Tick += new System.EventHandler(this.QLNCCTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Dong_ho_Rolex_Submariner_Date_126613LB_3;
            this.pictureBox1.Location = new System.Drawing.Point(82, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGDSanPham
            // 
            this.btnGDSanPham.ForeColor = System.Drawing.Color.Red;
            this.btnGDSanPham.Image = global::GUI.Properties.Resources.icons8_task_30;
            this.btnGDSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGDSanPham.Location = new System.Drawing.Point(0, 58);
            this.btnGDSanPham.Name = "btnGDSanPham";
            this.btnGDSanPham.Size = new System.Drawing.Size(310, 60);
            this.btnGDSanPham.TabIndex = 2;
            this.btnGDSanPham.Text = "               Sản phẩm";
            this.btnGDSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGDSanPham.UseVisualStyleBackColor = true;
            this.btnGDSanPham.Click += new System.EventHandler(this.btnGDSanPham_Click_1);
            // 
            // btnGĐanhMucSP
            // 
            this.btnGĐanhMucSP.ForeColor = System.Drawing.Color.Red;
            this.btnGĐanhMucSP.Image = global::GUI.Properties.Resources.icons8_task_30;
            this.btnGĐanhMucSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGĐanhMucSP.Location = new System.Drawing.Point(0, 112);
            this.btnGĐanhMucSP.Name = "btnGĐanhMucSP";
            this.btnGĐanhMucSP.Size = new System.Drawing.Size(344, 65);
            this.btnGĐanhMucSP.TabIndex = 2;
            this.btnGĐanhMucSP.Text = "              Danh mục sản phẩm";
            this.btnGĐanhMucSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGĐanhMucSP.UseVisualStyleBackColor = true;
            this.btnGĐanhMucSP.Click += new System.EventHandler(this.btnGĐanhMucSP_Click);
            // 
            // btnGDQLSP
            // 
            this.btnGDQLSP.ForeColor = System.Drawing.Color.Red;
            this.btnGDQLSP.Image = global::GUI.Properties.Resources.icons8_task_30;
            this.btnGDQLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGDQLSP.Location = new System.Drawing.Point(0, 0);
            this.btnGDQLSP.Name = "btnGDQLSP";
            this.btnGDQLSP.Size = new System.Drawing.Size(310, 61);
            this.btnGDQLSP.TabIndex = 2;
            this.btnGDQLSP.Text = "              Quản lý sản phẩm";
            this.btnGDQLSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGDQLSP.UseVisualStyleBackColor = true;
            this.btnGDQLSP.Click += new System.EventHandler(this.btnGDQLSP_Click_1);
            // 
            // btnGDQLNCC
            // 
            this.btnGDQLNCC.ForeColor = System.Drawing.Color.Red;
            this.btnGDQLNCC.Image = global::GUI.Properties.Resources.icons8_supplier_24;
            this.btnGDQLNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGDQLNCC.Location = new System.Drawing.Point(0, -11);
            this.btnGDQLNCC.Name = "btnGDQLNCC";
            this.btnGDQLNCC.Size = new System.Drawing.Size(303, 73);
            this.btnGDQLNCC.TabIndex = 2;
            this.btnGDQLNCC.Text = "Quản lý nhà cung cấp";
            this.btnGDQLNCC.UseVisualStyleBackColor = true;
            this.btnGDQLNCC.Click += new System.EventHandler(this.btnGDQLNCC_Click);
            // 
            // btnDGThongTinNCC
            // 
            this.btnDGThongTinNCC.ForeColor = System.Drawing.Color.Red;
            this.btnDGThongTinNCC.Image = global::GUI.Properties.Resources.icons8_information_32;
            this.btnDGThongTinNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDGThongTinNCC.Location = new System.Drawing.Point(0, 62);
            this.btnDGThongTinNCC.Name = "btnDGThongTinNCC";
            this.btnDGThongTinNCC.Size = new System.Drawing.Size(299, 67);
            this.btnDGThongTinNCC.TabIndex = 3;
            this.btnDGThongTinNCC.Text = "Thông tin nhà cung cấp";
            this.btnDGThongTinNCC.UseVisualStyleBackColor = true;
            this.btnDGThongTinNCC.Click += new System.EventHandler(this.btnDGThongTinNCC_Click);
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.sidebarControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoDien";
            this.QLNCCContainer.ResumeLayout(false);
            this.QLSPContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.sidebarControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnGDQLSP;
        private System.Windows.Forms.Panel QLNCCContainer;
        private System.Windows.Forms.Button btnGDQLNCC;
        private System.Windows.Forms.Timer timerSidebar;
        private System.Windows.Forms.Timer QLSPTimer;
        private System.Windows.Forms.Button btnDGThongTinNCC;
        private System.Windows.Forms.Panel QLSPContainer;
        private System.Windows.Forms.Button btnGDSanPham;
        private System.Windows.Forms.Button btnGĐanhMucSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebarControl;
        private System.Windows.Forms.Timer QLNCCTimer;
    }
}