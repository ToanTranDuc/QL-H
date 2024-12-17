namespace GUI
{
    partial class frmTrangChu
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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NhanVienContainer = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnDMChucVu = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnDSNhanVien = new System.Windows.Forms.Button();
            this.SanPhamContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDanhSachSanPham = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDanhMucSanPham = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNCC = new System.Windows.Forms.Button();
            this.KhoContainer = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnKho = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnDonDatHang = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnTonKho = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblChaoMung = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlBody = new System.Windows.Forms.Panel();
            this.SanPhamTimer = new System.Windows.Forms.Timer(this.components);
            this.NhanVienTimer = new System.Windows.Forms.Timer(this.components);
            this.KhoTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.NhanVienContainer.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SanPhamContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.KhoContainer.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.NhanVienContainer);
            this.sidebar.Controls.Add(this.SanPhamContainer);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.KhoContainer);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(304, 966);
            this.sidebar.MinimumSize = new System.Drawing.Size(63, 966);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(304, 966);
            this.sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picMenu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 100);
            this.panel2.TabIndex = 1;
            // 
            // picMenu
            // 
            this.picMenu.Image = global::GUI.Properties.Resources.icons8_menu_48;
            this.picMenu.Location = new System.Drawing.Point(6, 20);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(44, 42);
            this.picMenu.TabIndex = 1;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // NhanVienContainer
            // 
            this.NhanVienContainer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NhanVienContainer.Controls.Add(this.panel10);
            this.NhanVienContainer.Controls.Add(this.panel29);
            this.NhanVienContainer.Controls.Add(this.panel11);
            this.NhanVienContainer.Controls.Add(this.panel12);
            this.NhanVienContainer.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NhanVienContainer.Location = new System.Drawing.Point(3, 103);
            this.NhanVienContainer.MaximumSize = new System.Drawing.Size(301, 289);
            this.NhanVienContainer.MinimumSize = new System.Drawing.Size(301, 70);
            this.NhanVienContainer.Name = "NhanVienContainer";
            this.NhanVienContainer.Size = new System.Drawing.Size(301, 70);
            this.NhanVienContainer.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Controls.Add(this.btnNhanVien);
            this.panel10.Location = new System.Drawing.Point(-3, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(323, 70);
            this.panel10.TabIndex = 2;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNhanVien.Image = global::GUI.Properties.Resources.icons8_person_30;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(-17, -15);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(360, 104);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click_1);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.btnTaiKhoan);
            this.panel29.Location = new System.Drawing.Point(1, 198);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(323, 70);
            this.panel29.TabIndex = 2;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(-21, -12);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(360, 104);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnDMChucVu);
            this.panel11.Location = new System.Drawing.Point(-1, 134);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(323, 70);
            this.panel11.TabIndex = 2;
            // 
            // btnDMChucVu
            // 
            this.btnDMChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMChucVu.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnDMChucVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMChucVu.Location = new System.Drawing.Point(-19, -13);
            this.btnDMChucVu.Name = "btnDMChucVu";
            this.btnDMChucVu.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDMChucVu.Size = new System.Drawing.Size(360, 104);
            this.btnDMChucVu.TabIndex = 1;
            this.btnDMChucVu.Text = "Danh mục chức vụ";
            this.btnDMChucVu.UseVisualStyleBackColor = true;
            this.btnDMChucVu.Click += new System.EventHandler(this.btnDMChucVu_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnDSNhanVien);
            this.panel12.Location = new System.Drawing.Point(-3, 67);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(323, 70);
            this.panel12.TabIndex = 2;
            // 
            // btnDSNhanVien
            // 
            this.btnDSNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSNhanVien.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnDSNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSNhanVien.Location = new System.Drawing.Point(-17, -13);
            this.btnDSNhanVien.Name = "btnDSNhanVien";
            this.btnDSNhanVien.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDSNhanVien.Size = new System.Drawing.Size(360, 104);
            this.btnDSNhanVien.TabIndex = 1;
            this.btnDSNhanVien.Text = "Danh sách nhân viên";
            this.btnDSNhanVien.UseVisualStyleBackColor = true;
            this.btnDSNhanVien.Click += new System.EventHandler(this.btnDSNhanVien_Click);
            // 
            // SanPhamContainer
            // 
            this.SanPhamContainer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SanPhamContainer.Controls.Add(this.panel1);
            this.SanPhamContainer.Controls.Add(this.panel8);
            this.SanPhamContainer.Controls.Add(this.panel7);
            this.SanPhamContainer.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.SanPhamContainer.Location = new System.Drawing.Point(3, 179);
            this.SanPhamContainer.MaximumSize = new System.Drawing.Size(301, 206);
            this.SanPhamContainer.MinimumSize = new System.Drawing.Size(301, 70);
            this.SanPhamContainer.Name = "SanPhamContainer";
            this.SanPhamContainer.Size = new System.Drawing.Size(301, 70);
            this.SanPhamContainer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 70);
            this.panel1.TabIndex = 2;
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSanPham.Image = global::GUI.Properties.Resources.icons8_product_32;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(-17, -13);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(360, 104);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Quản lý sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnDanhSachSanPham);
            this.panel8.Location = new System.Drawing.Point(-1, 134);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(323, 70);
            this.panel8.TabIndex = 2;
            // 
            // btnDanhSachSanPham
            // 
            this.btnDanhSachSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachSanPham.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnDanhSachSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachSanPham.Location = new System.Drawing.Point(-17, -13);
            this.btnDanhSachSanPham.Name = "btnDanhSachSanPham";
            this.btnDanhSachSanPham.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDanhSachSanPham.Size = new System.Drawing.Size(360, 104);
            this.btnDanhSachSanPham.TabIndex = 1;
            this.btnDanhSachSanPham.Text = "Danh sách sản phẩm";
            this.btnDanhSachSanPham.UseVisualStyleBackColor = true;
            this.btnDanhSachSanPham.Click += new System.EventHandler(this.btnDanhSachSanPham_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDanhMucSanPham);
            this.panel7.Location = new System.Drawing.Point(-3, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(323, 70);
            this.panel7.TabIndex = 2;
            // 
            // btnDanhMucSanPham
            // 
            this.btnDanhMucSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMucSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMucSanPham.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnDanhMucSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMucSanPham.Location = new System.Drawing.Point(-17, -13);
            this.btnDanhMucSanPham.Name = "btnDanhMucSanPham";
            this.btnDanhMucSanPham.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDanhMucSanPham.Size = new System.Drawing.Size(360, 104);
            this.btnDanhMucSanPham.TabIndex = 1;
            this.btnDanhMucSanPham.Text = "Danh mục sản phẩm";
            this.btnDanhMucSanPham.UseVisualStyleBackColor = true;
            this.btnDanhMucSanPham.Click += new System.EventHandler(this.btnDanhMucSanPham_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNCC);
            this.panel3.Location = new System.Drawing.Point(3, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 70);
            this.panel3.TabIndex = 2;
            // 
            // btnNCC
            // 
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.Image = global::GUI.Properties.Resources.icons8_industrial_32;
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(-17, -13);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNCC.Size = new System.Drawing.Size(360, 104);
            this.btnNCC.TabIndex = 1;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // KhoContainer
            // 
            this.KhoContainer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.KhoContainer.Controls.Add(this.panel18);
            this.KhoContainer.Controls.Add(this.panel13);
            this.KhoContainer.Controls.Add(this.panel9);
            this.KhoContainer.Controls.Add(this.panel19);
            this.KhoContainer.Controls.Add(this.panel20);
            this.KhoContainer.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.KhoContainer.Location = new System.Drawing.Point(3, 331);
            this.KhoContainer.MaximumSize = new System.Drawing.Size(301, 357);
            this.KhoContainer.MinimumSize = new System.Drawing.Size(301, 70);
            this.KhoContainer.Name = "KhoContainer";
            this.KhoContainer.Size = new System.Drawing.Size(301, 70);
            this.KhoContainer.TabIndex = 3;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Black;
            this.panel18.Controls.Add(this.btnKho);
            this.panel18.Location = new System.Drawing.Point(-3, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(323, 70);
            this.panel18.TabIndex = 2;
            // 
            // btnKho
            // 
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKho.Image = global::GUI.Properties.Resources.icons8_house_32;
            this.btnKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKho.Location = new System.Drawing.Point(-17, -16);
            this.btnKho.Name = "btnKho";
            this.btnKho.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKho.Size = new System.Drawing.Size(360, 104);
            this.btnKho.TabIndex = 1;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnDonDatHang);
            this.panel13.Location = new System.Drawing.Point(3, 262);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(323, 70);
            this.panel13.TabIndex = 2;
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonDatHang.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnDonDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonDatHang.Location = new System.Drawing.Point(-23, -12);
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDonDatHang.Size = new System.Drawing.Size(360, 104);
            this.btnDonDatHang.TabIndex = 1;
            this.btnDonDatHang.Text = "Đặt hàng NCC";
            this.btnDonDatHang.UseVisualStyleBackColor = true;
            this.btnDonDatHang.Click += new System.EventHandler(this.btnDonDatHang_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnTonKho);
            this.panel9.Location = new System.Drawing.Point(1, 199);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(323, 70);
            this.panel9.TabIndex = 2;
            // 
            // btnTonKho
            // 
            this.btnTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTonKho.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnTonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTonKho.Location = new System.Drawing.Point(-21, -13);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTonKho.Size = new System.Drawing.Size(360, 104);
            this.btnTonKho.TabIndex = 1;
            this.btnTonKho.Text = "Tồn kho";
            this.btnTonKho.UseVisualStyleBackColor = true;
            this.btnTonKho.Click += new System.EventHandler(this.btnTonKho_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnXuatKho);
            this.panel19.Location = new System.Drawing.Point(-1, 134);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(323, 70);
            this.panel19.TabIndex = 2;
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatKho.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnXuatKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatKho.Location = new System.Drawing.Point(-19, -13);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnXuatKho.Size = new System.Drawing.Size(360, 104);
            this.btnXuatKho.TabIndex = 1;
            this.btnXuatKho.Text = "Xuất kho";
            this.btnXuatKho.UseVisualStyleBackColor = true;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnNhapKho);
            this.panel20.Location = new System.Drawing.Point(-3, 67);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(323, 70);
            this.panel20.TabIndex = 2;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.Image = global::GUI.Properties.Resources.icons8_menu_16;
            this.btnNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.Location = new System.Drawing.Point(-17, -13);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNhapKho.Size = new System.Drawing.Size(360, 104);
            this.btnNhapKho.TabIndex = 1;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnBanHang);
            this.panel5.Location = new System.Drawing.Point(3, 407);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 70);
            this.panel5.TabIndex = 2;
            // 
            // btnBanHang
            // 
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.Image = global::GUI.Properties.Resources.icons8_shop_32;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(-17, -13);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBanHang.Size = new System.Drawing.Size(360, 104);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnThongKe);
            this.panel6.Location = new System.Drawing.Point(3, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 70);
            this.panel6.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::GUI.Properties.Resources.icons8_bar_chart_32;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-17, -13);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(360, 104);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDangXuat);
            this.panel4.Location = new System.Drawing.Point(3, 559);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 70);
            this.panel4.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::GUI.Properties.Resources.icons8_logout_32;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(-17, -13);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(360, 104);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Controls.Add(this.lblChaoMung);
            this.flowLayoutPanel2.Controls.Add(this.panel14);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(304, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1114, 100);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblChaoMung
            // 
            this.lblChaoMung.AutoSize = true;
            this.lblChaoMung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaoMung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChaoMung.Location = new System.Drawing.Point(3, 0);
            this.lblChaoMung.Name = "lblChaoMung";
            this.lblChaoMung.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblChaoMung.Size = new System.Drawing.Size(100, 37);
            this.lblChaoMung.TabIndex = 0;
            this.lblChaoMung.Text = "Chào mừng";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.lblTitle);
            this.panel14.Location = new System.Drawing.Point(109, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(559, 91);
            this.panel14.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(212, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang chủ";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pnlBody
            // 
            this.pnlBody.AutoSize = true;
            this.pnlBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(304, 100);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1114, 676);
            this.pnlBody.TabIndex = 2;
            // 
            // SanPhamTimer
            // 
            this.SanPhamTimer.Interval = 10;
            this.SanPhamTimer.Tick += new System.EventHandler(this.SanPhamTimer_Tick);
            // 
            // NhanVienTimer
            // 
            this.NhanVienTimer.Interval = 10;
            this.NhanVienTimer.Tick += new System.EventHandler(this.NhanVienTimer_Tick);
            // 
            // KhoTimer
            // 
            this.KhoTimer.Interval = 10;
            this.KhoTimer.Tick += new System.EventHandler(this.KhoTimer_Tick);
            // 
            // frmTrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1418, 776);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrangChu";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.NhanVienContainer.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.SanPhamContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.KhoContainer.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel SanPhamContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDanhMucSanPham;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDanhSachSanPham;
        private System.Windows.Forms.Timer SanPhamTimer;
        private System.Windows.Forms.Panel NhanVienContainer;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnDMChucVu;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnDSNhanVien;
        private System.Windows.Forms.Panel KhoContainer;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Timer NhanVienTimer;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnDonDatHang;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnTonKho;
        private System.Windows.Forms.Timer KhoTimer;
        private System.Windows.Forms.Label lblChaoMung;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblTitle;
    }
}