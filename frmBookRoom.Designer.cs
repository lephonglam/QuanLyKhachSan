namespace QuanLyKhachSan
{
    partial class frmBookRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDanhSachThuePhong = new System.Windows.Forms.GroupBox();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.dataGridViewThuePhong = new System.Windows.Forms.DataGridView();
            this.colSoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhongThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuePhongbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbThongTinThuePhong = new System.Windows.Forms.GroupBox();
            this.btnChonPhong = new System.Windows.Forms.Button();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbThongTinKH = new System.Windows.Forms.GroupBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnChonKhach = new System.Windows.Forms.Button();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.dataGridViewKhach = new System.Windows.Forms.DataGridView();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.grbDanhSachThuePhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuePhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuePhongbindingSource)).BeginInit();
            this.grbThongTinThuePhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhongbindingSource)).BeginInit();
            this.grbThongTinKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.grbDanhSachThuePhong);
            this.panel1.Controls.Add(this.grbThongTinThuePhong);
            this.panel1.Controls.Add(this.grbThongTinKH);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 544);
            this.panel1.TabIndex = 0;
            // 
            // grbDanhSachThuePhong
            // 
            this.grbDanhSachThuePhong.Controls.Add(this.btnThuePhong);
            this.grbDanhSachThuePhong.Controls.Add(this.label1);
            this.grbDanhSachThuePhong.Controls.Add(this.txtNhanVien);
            this.grbDanhSachThuePhong.Controls.Add(this.dataGridViewThuePhong);
            this.grbDanhSachThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachThuePhong.Location = new System.Drawing.Point(24, 368);
            this.grbDanhSachThuePhong.Name = "grbDanhSachThuePhong";
            this.grbDanhSachThuePhong.Size = new System.Drawing.Size(992, 162);
            this.grbDanhSachThuePhong.TabIndex = 5;
            this.grbDanhSachThuePhong.TabStop = false;
            this.grbDanhSachThuePhong.Text = "Danh sách thuê phòng";
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThuePhong.Location = new System.Drawing.Point(842, 101);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(124, 27);
            this.btnThuePhong.TabIndex = 3;
            this.btnThuePhong.Text = "Thuê phòng";
            this.btnThuePhong.UseVisualStyleBackColor = true;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhân viên";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(842, 58);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(124, 22);
            this.txtNhanVien.TabIndex = 1;
            // 
            // dataGridViewThuePhong
            // 
            this.dataGridViewThuePhong.AutoGenerateColumns = false;
            this.dataGridViewThuePhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoCMND,
            this.colMaPhongThue,
            this.colNgayDen,
            this.colNgayDi,
            this.colNhanVien});
            this.dataGridViewThuePhong.DataSource = this.ThuePhongbindingSource;
            this.dataGridViewThuePhong.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewThuePhong.MultiSelect = false;
            this.dataGridViewThuePhong.Name = "dataGridViewThuePhong";
            this.dataGridViewThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThuePhong.Size = new System.Drawing.Size(792, 135);
            this.dataGridViewThuePhong.TabIndex = 0;
            // 
            // colSoCMND
            // 
            this.colSoCMND.DataPropertyName = "CMT";
            this.colSoCMND.HeaderText = "Số CMND";
            this.colSoCMND.Name = "colSoCMND";
            this.colSoCMND.ReadOnly = true;
            // 
            // colMaPhongThue
            // 
            this.colMaPhongThue.DataPropertyName = "MaPhong";
            this.colMaPhongThue.HeaderText = "Mã phòng";
            this.colMaPhongThue.Name = "colMaPhongThue";
            this.colMaPhongThue.ReadOnly = true;
            // 
            // colNgayDen
            // 
            this.colNgayDen.DataPropertyName = "NgayDen";
            this.colNgayDen.HeaderText = "Ngày đến";
            this.colNgayDen.Name = "colNgayDen";
            this.colNgayDen.ReadOnly = true;
            // 
            // colNgayDi
            // 
            this.colNgayDi.DataPropertyName = "NgayDi";
            this.colNgayDi.HeaderText = "Ngày đi";
            this.colNgayDi.Name = "colNgayDi";
            this.colNgayDi.ReadOnly = true;
            // 
            // colNhanVien
            // 
            this.colNhanVien.DataPropertyName = "TenNV";
            this.colNhanVien.HeaderText = "Tên nhân viên";
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.ReadOnly = true;
            // 
            // grbThongTinThuePhong
            // 
            this.grbThongTinThuePhong.Controls.Add(this.btnChonPhong);
            this.grbThongTinThuePhong.Controls.Add(this.cboLoaiPhong);
            this.grbThongTinThuePhong.Controls.Add(this.dataGridViewPhong);
            this.grbThongTinThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinThuePhong.Location = new System.Drawing.Point(24, 189);
            this.grbThongTinThuePhong.Name = "grbThongTinThuePhong";
            this.grbThongTinThuePhong.Size = new System.Drawing.Size(992, 162);
            this.grbThongTinThuePhong.TabIndex = 4;
            this.grbThongTinThuePhong.TabStop = false;
            this.grbThongTinThuePhong.Text = "Thông tin thuê phòng";
            // 
            // btnChonPhong
            // 
            this.btnChonPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChonPhong.Location = new System.Drawing.Point(842, 102);
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.Size = new System.Drawing.Size(124, 27);
            this.btnChonPhong.TabIndex = 2;
            this.btnChonPhong.Text = "Chọn phòng";
            this.btnChonPhong.UseVisualStyleBackColor = true;
            this.btnChonPhong.Click += new System.EventHandler(this.btnChonPhong_Click);
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Đơn thường",
            "Đôi thường",
            "Ba thường",
            "VIP đơn",
            "VIP đôi",
            "VIP ba"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(842, 55);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(124, 24);
            this.cboLoaiPhong.TabIndex = 1;
            this.cboLoaiPhong.Text = "--Chọn loại--";
            this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhong_SelectedIndexChanged);
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.AutoGenerateColumns = false;
            this.dataGridViewPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colLoaiPhong,
            this.colGiaPhong,
            this.colTinhTrang});
            this.dataGridViewPhong.DataSource = this.PhongbindingSource;
            this.dataGridViewPhong.Location = new System.Drawing.Point(17, 23);
            this.dataGridViewPhong.MultiSelect = false;
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhong.Size = new System.Drawing.Size(792, 135);
            this.dataGridViewPhong.TabIndex = 0;
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            // 
            // colTenPhong
            // 
            this.colTenPhong.DataPropertyName = "TenPhong";
            this.colTenPhong.HeaderText = "Tên phòng";
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.ReadOnly = true;
            // 
            // colLoaiPhong
            // 
            this.colLoaiPhong.DataPropertyName = "LoaiPhong";
            this.colLoaiPhong.HeaderText = "Loại phòng";
            this.colLoaiPhong.Name = "colLoaiPhong";
            this.colLoaiPhong.ReadOnly = true;
            // 
            // colGiaPhong
            // 
            this.colGiaPhong.DataPropertyName = "GiaPhong";
            this.colGiaPhong.HeaderText = "Giá phòng";
            this.colGiaPhong.Name = "colGiaPhong";
            this.colGiaPhong.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.DataPropertyName = "TinhTrang";
            this.colTinhTrang.HeaderText = "Tình trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
            // 
            // grbThongTinKH
            // 
            this.grbThongTinKH.Controls.Add(this.txtCMND);
            this.grbThongTinKH.Controls.Add(this.btnChonKhach);
            this.grbThongTinKH.Controls.Add(this.btnThemKhach);
            this.grbThongTinKH.Controls.Add(this.dataGridViewKhach);
            this.grbThongTinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinKH.Location = new System.Drawing.Point(24, 14);
            this.grbThongTinKH.Name = "grbThongTinKH";
            this.grbThongTinKH.Size = new System.Drawing.Size(992, 162);
            this.grbThongTinKH.TabIndex = 3;
            this.grbThongTinKH.TabStop = false;
            this.grbThongTinKH.Text = "Thông tin khách hàng";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(842, 21);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(124, 22);
            this.txtCMND.TabIndex = 4;
            this.txtCMND.Text = "Nhập số CMND";
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            this.txtCMND.Enter += new System.EventHandler(this.txtCMND_Enter);
            // 
            // btnChonKhach
            // 
            this.btnChonKhach.Location = new System.Drawing.Point(842, 114);
            this.btnChonKhach.Name = "btnChonKhach";
            this.btnChonKhach.Size = new System.Drawing.Size(124, 27);
            this.btnChonKhach.TabIndex = 3;
            this.btnChonKhach.Text = "Chọn khách";
            this.btnChonKhach.UseVisualStyleBackColor = true;
            this.btnChonKhach.Click += new System.EventHandler(this.btnChonKhach_Click);
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(842, 67);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(124, 27);
            this.btnThemKhach.TabIndex = 2;
            this.btnThemKhach.Text = "Thêm Khách";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // dataGridViewKhach
            // 
            this.dataGridViewKhach.AutoGenerateColumns = false;
            this.dataGridViewKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCMND,
            this.colHoTen,
            this.colDiaChi,
            this.colGioiTinh,
            this.colSoDienThoai});
            this.dataGridViewKhach.DataSource = this.KhachbindingSource;
            this.dataGridViewKhach.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewKhach.MultiSelect = false;
            this.dataGridViewKhach.Name = "dataGridViewKhach";
            this.dataGridViewKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhach.Size = new System.Drawing.Size(792, 135);
            this.dataGridViewKhach.TabIndex = 0;
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "CMT";
            this.colCMND.HeaderText = "Số CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.DataPropertyName = "SDT";
            this.colSoDienThoai.HeaderText = "Điện thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            // 
            // frmBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1041, 544);
            this.Controls.Add(this.panel1);
            this.Name = "frmBookRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê phòng";
            this.Load += new System.EventHandler(this.frmBookRoom_Load);
            this.panel1.ResumeLayout(false);
            this.grbDanhSachThuePhong.ResumeLayout(false);
            this.grbDanhSachThuePhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuePhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuePhongbindingSource)).EndInit();
            this.grbThongTinThuePhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhongbindingSource)).EndInit();
            this.grbThongTinKH.ResumeLayout(false);
            this.grbThongTinKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbDanhSachThuePhong;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.DataGridView dataGridViewThuePhong;
        private System.Windows.Forms.GroupBox grbThongTinThuePhong;
        private System.Windows.Forms.Button btnChonPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.BindingSource PhongbindingSource;
        private System.Windows.Forms.GroupBox grbThongTinKH;
        private System.Windows.Forms.Button btnChonKhach;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.DataGridView dataGridViewKhach;
        private System.Windows.Forms.BindingSource KhachbindingSource;
        private System.Windows.Forms.BindingSource ThuePhongbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhongThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVien;
    }
}