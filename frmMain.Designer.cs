namespace QuanLyKhachSan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongQLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangTraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangSDDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy,
            this.mnuChucNang,
            this.mnuTimKiem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThongQLTaiKhoan,
            this.mnuHeThongDangXuat,
            this.mnuHeThongThoat});
            this.mnuHeThong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(78, 21);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuHeThongQLTaiKhoan
            // 
            this.mnuHeThongQLTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHeThongQLTaiKhoan.Name = "mnuHeThongQLTaiKhoan";
            this.mnuHeThongQLTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.mnuHeThongQLTaiKhoan.Text = "Quản lý tài khoản";
            this.mnuHeThongQLTaiKhoan.Click += new System.EventHandler(this.mnuHeThongQLTaiKhoan_Click);
            // 
            // mnuHeThongDangXuat
            // 
            this.mnuHeThongDangXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHeThongDangXuat.Name = "mnuHeThongDangXuat";
            this.mnuHeThongDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuHeThongDangXuat.Size = new System.Drawing.Size(180, 22);
            this.mnuHeThongDangXuat.Text = "Đăng xuất";
            this.mnuHeThongDangXuat.Click += new System.EventHandler(this.mnuHeThongDangXuat_Click);
            // 
            // mnuHeThongThoat
            // 
            this.mnuHeThongThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHeThongThoat.Name = "mnuHeThongThoat";
            this.mnuHeThongThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuHeThongThoat.Size = new System.Drawing.Size(180, 22);
            this.mnuHeThongThoat.Text = "Thoát";
            this.mnuHeThongThoat.Click += new System.EventHandler(this.mnuHeThongThoat_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyKhach,
            this.mnuQuanLyPhong,
            this.mnuQuanLyDichVu});
            this.mnuQuanLy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(116, 21);
            this.mnuQuanLy.Text = "Quản lý dữ liệu";
            // 
            // mnuQuanLyKhach
            // 
            this.mnuQuanLyKhach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanLyKhach.Name = "mnuQuanLyKhach";
            this.mnuQuanLyKhach.Size = new System.Drawing.Size(165, 22);
            this.mnuQuanLyKhach.Text = "Quản lý khách";
            this.mnuQuanLyKhach.Click += new System.EventHandler(this.mnuQuanLyKhach_Click);
            // 
            // mnuQuanLyPhong
            // 
            this.mnuQuanLyPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanLyPhong.Name = "mnuQuanLyPhong";
            this.mnuQuanLyPhong.Size = new System.Drawing.Size(165, 22);
            this.mnuQuanLyPhong.Text = "Quản lý phòng";
            this.mnuQuanLyPhong.Click += new System.EventHandler(this.mnuQuanLyPhong_Click);
            // 
            // mnuQuanLyDichVu
            // 
            this.mnuQuanLyDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanLyDichVu.Name = "mnuQuanLyDichVu";
            this.mnuQuanLyDichVu.Size = new System.Drawing.Size(165, 22);
            this.mnuQuanLyDichVu.Text = "Quản lý dịch vụ";
            this.mnuQuanLyDichVu.Click += new System.EventHandler(this.mnuQuanLyDichVu_Click);
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNangThuePhong,
            this.mnuChucNangTraPhong,
            this.mnuChucNangSDDichVu});
            this.mnuChucNang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(86, 21);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuChucNangThuePhong
            // 
            this.mnuChucNangThuePhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuChucNangThuePhong.Name = "mnuChucNangThuePhong";
            this.mnuChucNangThuePhong.Size = new System.Drawing.Size(170, 22);
            this.mnuChucNangThuePhong.Text = "Thuê phòng";
            this.mnuChucNangThuePhong.Click += new System.EventHandler(this.mnuChucNangThuePhong_Click);
            // 
            // mnuChucNangTraPhong
            // 
            this.mnuChucNangTraPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuChucNangTraPhong.Name = "mnuChucNangTraPhong";
            this.mnuChucNangTraPhong.Size = new System.Drawing.Size(170, 22);
            this.mnuChucNangTraPhong.Text = "Trả phòng";
            this.mnuChucNangTraPhong.Click += new System.EventHandler(this.mnuChucNangTraPhong_Click);
            // 
            // mnuChucNangSDDichVu
            // 
            this.mnuChucNangSDDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuChucNangSDDichVu.Name = "mnuChucNangSDDichVu";
            this.mnuChucNangSDDichVu.Size = new System.Drawing.Size(170, 22);
            this.mnuChucNangSDDichVu.Text = "Sử dụng dịch vụ";
            this.mnuChucNangSDDichVu.Click += new System.EventHandler(this.mnuChucNangSDDichVu_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimKiemKhachHang,
            this.mnuTimKiemPhong});
            this.mnuTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(78, 21);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuTimKiemKhachHang
            // 
            this.mnuTimKiemKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiemKhachHang.Name = "mnuTimKiemKhachHang";
            this.mnuTimKiemKhachHang.Size = new System.Drawing.Size(198, 22);
            this.mnuTimKiemKhachHang.Text = "Tìm kiếm khách hàng";
            this.mnuTimKiemKhachHang.Click += new System.EventHandler(this.mnuTimKiemKhachHang_Click);
            // 
            // mnuTimKiemPhong
            // 
            this.mnuTimKiemPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiemPhong.Name = "mnuTimKiemPhong";
            this.mnuTimKiemPhong.Size = new System.Drawing.Size(198, 22);
            this.mnuTimKiemPhong.Text = "Tìm kiếm phòng";
            this.mnuTimKiemPhong.Click += new System.EventHandler(this.mnuTimKiemPhong_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý thuê phòng khách sạn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongQLTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyKhach;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangThuePhong;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangTraPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangSDDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemPhong;
    }
}