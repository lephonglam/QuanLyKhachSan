namespace QuanLyKhachSan
{
    partial class frmCheckOut
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
            this.grbTimKH = new System.Windows.Forms.GroupBox();
            this.dataGridViewKhach = new System.Windows.Forms.DataGridView();
            this.colSoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.rgbThongTinKH = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.dataGridViewThuePhong = new System.Windows.Forms.DataGridView();
            this.colMaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuePhongbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbTimKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachbindingSource)).BeginInit();
            this.rgbThongTinKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuePhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuePhongbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.grbTimKH);
            this.panel1.Controls.Add(this.rgbThongTinKH);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 490);
            this.panel1.TabIndex = 0;
            // 
            // grbTimKH
            // 
            this.grbTimKH.Controls.Add(this.dataGridViewKhach);
            this.grbTimKH.Controls.Add(this.btnTimKiem);
            this.grbTimKH.Controls.Add(this.txtTenKhach);
            this.grbTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKH.Location = new System.Drawing.Point(22, 12);
            this.grbTimKH.Name = "grbTimKH";
            this.grbTimKH.Size = new System.Drawing.Size(930, 131);
            this.grbTimKH.TabIndex = 2;
            this.grbTimKH.TabStop = false;
            this.grbTimKH.Text = "Tìm kiếm khách hàng";
            // 
            // dataGridViewKhach
            // 
            this.dataGridViewKhach.AutoGenerateColumns = false;
            this.dataGridViewKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoCMND,
            this.colHoTen});
            this.dataGridViewKhach.DataSource = this.KhachbindingSource;
            this.dataGridViewKhach.Location = new System.Drawing.Point(459, 11);
            this.dataGridViewKhach.MultiSelect = false;
            this.dataGridViewKhach.Name = "dataGridViewKhach";
            this.dataGridViewKhach.ReadOnly = true;
            this.dataGridViewKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhach.Size = new System.Drawing.Size(399, 114);
            this.dataGridViewKhach.TabIndex = 2;
            this.dataGridViewKhach.SelectionChanged += new System.EventHandler(this.dataGridViewKhach_SelectionChanged);
            // 
            // colSoCMND
            // 
            this.colSoCMND.DataPropertyName = "CMT";
            this.colSoCMND.HeaderText = "Số CMND";
            this.colSoCMND.Name = "colSoCMND";
            this.colSoCMND.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(166, 77);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(140, 31);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(124, 36);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(219, 22);
            this.txtTenKhach.TabIndex = 0;
            this.txtTenKhach.Text = "Nhập tên khách hàng";
            // 
            // rgbThongTinKH
            // 
            this.rgbThongTinKH.Controls.Add(this.btnThanhToan);
            this.rgbThongTinKH.Controls.Add(this.btnTraPhong);
            this.rgbThongTinKH.Controls.Add(this.dataGridViewThuePhong);
            this.rgbThongTinKH.Controls.Add(this.txtDiaChi);
            this.rgbThongTinKH.Controls.Add(this.txtHoTen);
            this.rgbThongTinKH.Controls.Add(this.txtDienThoai);
            this.rgbThongTinKH.Controls.Add(this.txtGioiTinh);
            this.rgbThongTinKH.Controls.Add(this.txtCMND);
            this.rgbThongTinKH.Controls.Add(this.label5);
            this.rgbThongTinKH.Controls.Add(this.label4);
            this.rgbThongTinKH.Controls.Add(this.label3);
            this.rgbThongTinKH.Controls.Add(this.label2);
            this.rgbThongTinKH.Controls.Add(this.label1);
            this.rgbThongTinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbThongTinKH.Location = new System.Drawing.Point(22, 158);
            this.rgbThongTinKH.Name = "rgbThongTinKH";
            this.rgbThongTinKH.Size = new System.Drawing.Size(930, 320);
            this.rgbThongTinKH.TabIndex = 3;
            this.rgbThongTinKH.TabStop = false;
            this.rgbThongTinKH.Text = "Thông tin khách thuê";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Location = new System.Drawing.Point(830, 243);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(94, 31);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTraPhong.Location = new System.Drawing.Point(830, 190);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(94, 31);
            this.btnTraPhong.TabIndex = 13;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // dataGridViewThuePhong
            // 
            this.dataGridViewThuePhong.AutoGenerateColumns = false;
            this.dataGridViewThuePhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHopDong,
            this.colCMND,
            this.colMaPhong,
            this.colNgayDen,
            this.colNgayDi,
            this.colTenNhanVien});
            this.dataGridViewThuePhong.DataSource = this.ThuePhongbindingSource;
            this.dataGridViewThuePhong.Location = new System.Drawing.Point(17, 161);
            this.dataGridViewThuePhong.Name = "dataGridViewThuePhong";
            this.dataGridViewThuePhong.ReadOnly = true;
            this.dataGridViewThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThuePhong.Size = new System.Drawing.Size(807, 150);
            this.dataGridViewThuePhong.TabIndex = 12;
            this.dataGridViewThuePhong.SelectionChanged += new System.EventHandler(this.dataGridViewThuePhong_SelectionChanged);
            // 
            // colMaHopDong
            // 
            this.colMaHopDong.DataPropertyName = "MaHD";
            this.colMaHopDong.HeaderText = "Mã hợp đồng";
            this.colMaHopDong.Name = "colMaHopDong";
            this.colMaHopDong.ReadOnly = true;
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "CMT";
            this.colCMND.HeaderText = "Số CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.ReadOnly = true;
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
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
            // colTenNhanVien
            // 
            this.colTenNhanVien.DataPropertyName = "TenNV";
            this.colTenNhanVien.HeaderText = "Tên nhân viên";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.ReadOnly = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(682, 74);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(242, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(682, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(242, 22);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(157, 118);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(242, 22);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(157, 74);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(242, 22);
            this.txtGioiTinh.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(157, 33);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(242, 22);
            this.txtCMND.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số CMND";
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(975, 490);
            this.Controls.Add(this.panel1);
            this.Name = "frmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.grbTimKH.ResumeLayout(false);
            this.grbTimKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachbindingSource)).EndInit();
            this.rgbThongTinKH.ResumeLayout(false);
            this.rgbThongTinKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuePhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuePhongbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbTimKH;
        private System.Windows.Forms.DataGridView dataGridViewKhach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.GroupBox rgbThongTinKH;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.DataGridView dataGridViewThuePhong;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.BindingSource ThuePhongbindingSource;
        private System.Windows.Forms.BindingSource KhachbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
    }
}