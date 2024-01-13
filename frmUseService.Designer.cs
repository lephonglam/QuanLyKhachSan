namespace QuanLyKhachSan
{
    partial class frmUseService
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbDanhSachSuDung = new System.Windows.Forms.GroupBox();
            this.dataGridViewSDDV = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDDVbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbChonDichVu = new System.Windows.Forms.GroupBox();
            this.dataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.colMaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVubindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tvKhachHang = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.grbDanhSachSuDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSDDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDDVbindingSource)).BeginInit();
            this.grbChonDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVubindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.grbDanhSachSuDung);
            this.panel1.Controls.Add(this.grbChonDichVu);
            this.panel1.Controls.Add(this.tvKhachHang);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(787, 171);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 38);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(445, 171);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 38);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(284, 171);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 38);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(615, 171);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 38);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grbDanhSachSuDung
            // 
            this.grbDanhSachSuDung.Controls.Add(this.dataGridViewSDDV);
            this.grbDanhSachSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachSuDung.Location = new System.Drawing.Point(179, 222);
            this.grbDanhSachSuDung.Name = "grbDanhSachSuDung";
            this.grbDanhSachSuDung.Size = new System.Drawing.Size(803, 216);
            this.grbDanhSachSuDung.TabIndex = 9;
            this.grbDanhSachSuDung.TabStop = false;
            this.grbDanhSachSuDung.Text = "Danh sách sử dụng";
            // 
            // dataGridViewSDDV
            // 
            this.dataGridViewSDDV.AutoGenerateColumns = false;
            this.dataGridViewSDDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSDDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colCMND,
            this.colMaDV,
            this.colSoLuong,
            this.colNgaySuDung,
            this.colMaPhong});
            this.dataGridViewSDDV.DataSource = this.SDDVbindingSource;
            this.dataGridViewSDDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSDDV.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewSDDV.Name = "dataGridViewSDDV";
            this.dataGridViewSDDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSDDV.Size = new System.Drawing.Size(797, 195);
            this.dataGridViewSDDV.TabIndex = 0;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.DataPropertyName = "MaHDDV";
            this.colMaHoaDon.HeaderText = "Mã hóa đơn";
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.ReadOnly = true;
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "CMT";
            this.colCMND.HeaderText = "Số CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.ReadOnly = true;
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "MaDV";
            this.colMaDV.HeaderText = "Mã dịch vụ";
            this.colMaDV.Name = "colMaDV";
            this.colMaDV.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colNgaySuDung
            // 
            this.colNgaySuDung.DataPropertyName = "NgaySD";
            this.colNgaySuDung.HeaderText = "Ngày sử dụng";
            this.colNgaySuDung.Name = "colNgaySuDung";
            this.colNgaySuDung.ReadOnly = true;
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            // 
            // grbChonDichVu
            // 
            this.grbChonDichVu.Controls.Add(this.dataGridViewDichVu);
            this.grbChonDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChonDichVu.Location = new System.Drawing.Point(179, 12);
            this.grbChonDichVu.Name = "grbChonDichVu";
            this.grbChonDichVu.Size = new System.Drawing.Size(803, 148);
            this.grbChonDichVu.TabIndex = 8;
            this.grbChonDichVu.TabStop = false;
            this.grbChonDichVu.Text = "Chọn dịch vụ";
            // 
            // dataGridViewDichVu
            // 
            this.dataGridViewDichVu.AutoGenerateColumns = false;
            this.dataGridViewDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDichVu,
            this.colTenDichVu,
            this.colGiaDichVu,
            this.colDonViTinh});
            this.dataGridViewDichVu.DataSource = this.DichVubindingSource;
            this.dataGridViewDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDichVu.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewDichVu.Name = "dataGridViewDichVu";
            this.dataGridViewDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDichVu.Size = new System.Drawing.Size(797, 127);
            this.dataGridViewDichVu.TabIndex = 0;
            // 
            // colMaDichVu
            // 
            this.colMaDichVu.DataPropertyName = "MaDV";
            this.colMaDichVu.HeaderText = "Mã dịch vụ";
            this.colMaDichVu.Name = "colMaDichVu";
            this.colMaDichVu.ReadOnly = true;
            // 
            // colTenDichVu
            // 
            this.colTenDichVu.DataPropertyName = "TenDV";
            this.colTenDichVu.HeaderText = "Tên dịch vụ";
            this.colTenDichVu.Name = "colTenDichVu";
            this.colTenDichVu.ReadOnly = true;
            // 
            // colGiaDichVu
            // 
            this.colGiaDichVu.DataPropertyName = "GiaDV";
            this.colGiaDichVu.HeaderText = "Giá dịch vụ";
            this.colGiaDichVu.Name = "colGiaDichVu";
            this.colGiaDichVu.ReadOnly = true;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.DataPropertyName = "DVT";
            this.colDonViTinh.HeaderText = "Đơn vị tính";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            // 
            // tvKhachHang
            // 
            this.tvKhachHang.Location = new System.Drawing.Point(13, 12);
            this.tvKhachHang.Name = "tvKhachHang";
            this.tvKhachHang.Size = new System.Drawing.Size(149, 426);
            this.tvKhachHang.TabIndex = 7;
            this.tvKhachHang.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhachHang_AfterSelect);
            // 
            // frmUseService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmUseService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.frmUseService_Load);
            this.panel1.ResumeLayout(false);
            this.grbDanhSachSuDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSDDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDDVbindingSource)).EndInit();
            this.grbChonDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVubindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbDanhSachSuDung;
        private System.Windows.Forms.DataGridView dataGridViewSDDV;
        private System.Windows.Forms.GroupBox grbChonDichVu;
        private System.Windows.Forms.DataGridView dataGridViewDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.BindingSource DichVubindingSource;
        private System.Windows.Forms.TreeView tvKhachHang;
        private System.Windows.Forms.BindingSource SDDVbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
    }
}