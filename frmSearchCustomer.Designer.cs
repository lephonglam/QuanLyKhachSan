namespace QuanLyKhachSan
{
    partial class frmSearchCustomer
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
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.radTenKhachHang = new System.Windows.Forms.RadioButton();
            this.radCMND = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.grbTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grbKetQua);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 401);
            this.panel1.TabIndex = 0;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnThoat);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.txtTimKiem);
            this.grbTimKiem.Controls.Add(this.radTenKhachHang);
            this.grbTimKiem.Controls.Add(this.radCMND);
            this.grbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiem.Location = new System.Drawing.Point(12, 65);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(725, 129);
            this.grbTimKiem.TabIndex = 4;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(547, 74);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(407, 75);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 34);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(361, 29);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(314, 22);
            this.txtTimKiem.TabIndex = 2;
            // 
            // radTenKhachHang
            // 
            this.radTenKhachHang.AutoSize = true;
            this.radTenKhachHang.Location = new System.Drawing.Point(36, 74);
            this.radTenKhachHang.Name = "radTenKhachHang";
            this.radTenKhachHang.Size = new System.Drawing.Size(193, 20);
            this.radTenKhachHang.TabIndex = 1;
            this.radTenKhachHang.TabStop = true;
            this.radTenKhachHang.Text = "Tìm theo tên khách hàng";
            this.radTenKhachHang.UseVisualStyleBackColor = true;
            // 
            // radCMND
            // 
            this.radCMND.AutoSize = true;
            this.radCMND.Location = new System.Drawing.Point(36, 31);
            this.radCMND.Name = "radCMND";
            this.radCMND.Size = new System.Drawing.Size(154, 20);
            this.radCMND.TabIndex = 0;
            this.radCMND.TabStop = true;
            this.radCMND.Text = "Tìm theo số CMND";
            this.radCMND.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÌM KIẾM THÔNG TIN KHÁCH HÀNG";
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.dataGridViewCustomer);
            this.grbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKetQua.Location = new System.Drawing.Point(12, 211);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(725, 170);
            this.grbKetQua.TabIndex = 5;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả tìm kiếm";
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCMND,
            this.colHoTen,
            this.colDiaChi,
            this.colGioiTinh,
            this.colSoDienThoai});
            this.dataGridViewCustomer.DataSource = this.CustomerbindingSource;
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(719, 149);
            this.dataGridViewCustomer.TabIndex = 0;
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
            this.colSoDienThoai.HeaderText = "Số điện thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            // 
            // frmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(749, 401);
            this.Controls.Add(this.panel1);
            this.Name = "frmSearchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmSearchCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton radTenKhachHang;
        private System.Windows.Forms.RadioButton radCMND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.BindingSource CustomerbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
    }
}