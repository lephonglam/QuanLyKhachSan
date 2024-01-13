namespace QuanLyKhachSan
{
    partial class frmSearchRoom
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
            this.grbTimKiemPhong = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.chkTinhTrangPhong = new System.Windows.Forms.CheckBox();
            this.chkLoaiPhong = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoombindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.grbTimKiemPhong.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoombindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.grbTimKiemPhong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grbKetQua);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 395);
            this.panel1.TabIndex = 0;
            // 
            // grbTimKiemPhong
            // 
            this.grbTimKiemPhong.Controls.Add(this.btnThoat);
            this.grbTimKiemPhong.Controls.Add(this.btnTimKiem);
            this.grbTimKiemPhong.Controls.Add(this.cboTinhTrang);
            this.grbTimKiemPhong.Controls.Add(this.cboLoaiPhong);
            this.grbTimKiemPhong.Controls.Add(this.chkTinhTrangPhong);
            this.grbTimKiemPhong.Controls.Add(this.chkLoaiPhong);
            this.grbTimKiemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemPhong.Location = new System.Drawing.Point(13, 68);
            this.grbTimKiemPhong.Name = "grbTimKiemPhong";
            this.grbTimKiemPhong.Size = new System.Drawing.Size(690, 123);
            this.grbTimKiemPhong.TabIndex = 4;
            this.grbTimKiemPhong.TabStop = false;
            this.grbTimKiemPhong.Text = "Tìm kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(587, 73);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 24);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(587, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 24);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.AutoCompleteCustomSource.AddRange(new string[] {
            "Trống",
            "Có khách"});
            this.cboTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Trống",
            "Có khách"});
            this.cboTinhTrang.Location = new System.Drawing.Point(242, 73);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(312, 24);
            this.cboTinhTrang.TabIndex = 3;
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
            this.cboLoaiPhong.Location = new System.Drawing.Point(242, 28);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(312, 24);
            this.cboLoaiPhong.TabIndex = 2;
            // 
            // chkTinhTrangPhong
            // 
            this.chkTinhTrangPhong.AutoSize = true;
            this.chkTinhTrangPhong.Location = new System.Drawing.Point(38, 77);
            this.chkTinhTrangPhong.Name = "chkTinhTrangPhong";
            this.chkTinhTrangPhong.Size = new System.Drawing.Size(176, 20);
            this.chkTinhTrangPhong.TabIndex = 1;
            this.chkTinhTrangPhong.Text = "Theo tình trạng phòng";
            this.chkTinhTrangPhong.UseVisualStyleBackColor = true;
            // 
            // chkLoaiPhong
            // 
            this.chkLoaiPhong.AutoSize = true;
            this.chkLoaiPhong.Location = new System.Drawing.Point(38, 32);
            this.chkLoaiPhong.Name = "chkLoaiPhong";
            this.chkLoaiPhong.Size = new System.Drawing.Size(139, 20);
            this.chkLoaiPhong.TabIndex = 0;
            this.chkLoaiPhong.Text = "Theo loại phòng";
            this.chkLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÌM KIẾM THÔNG TIN PHÒNG THUÊ";
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.dataGridViewRoom);
            this.grbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKetQua.Location = new System.Drawing.Point(13, 211);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(690, 167);
            this.grbKetQua.TabIndex = 5;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả tìm kiếm";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AutoGenerateColumns = false;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colLoaiPhong,
            this.colGiaPhong,
            this.colTinhTrang});
            this.dataGridViewRoom.DataSource = this.RoombindingSource;
            this.dataGridViewRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRoom.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.Size = new System.Drawing.Size(684, 146);
            this.dataGridViewRoom.TabIndex = 0;
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
            // frmSearchRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(717, 395);
            this.Controls.Add(this.panel1);
            this.Name = "frmSearchRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thông tin phòng thuê";
            this.Load += new System.EventHandler(this.frmSearchRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbTimKiemPhong.ResumeLayout(false);
            this.grbTimKiemPhong.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoombindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbTimKiemPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.CheckBox chkTinhTrangPhong;
        private System.Windows.Forms.CheckBox chkLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.BindingSource RoombindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
    }
}