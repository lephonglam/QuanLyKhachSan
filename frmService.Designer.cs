namespace QuanLyKhachSan
{
    partial class frmService
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
            this.grbDanhSachDichVu = new System.Windows.Forms.GroupBox();
            this.dataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.colMaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVubindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbThongTinDV = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiaDichVu = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbDanhSachDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVubindingSource)).BeginInit();
            this.grbThongTinDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.grbDanhSachDichVu);
            this.panel1.Controls.Add(this.grbThongTinDV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 409);
            this.panel1.TabIndex = 0;
            // 
            // grbDanhSachDichVu
            // 
            this.grbDanhSachDichVu.Controls.Add(this.dataGridViewDichVu);
            this.grbDanhSachDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachDichVu.Location = new System.Drawing.Point(44, 230);
            this.grbDanhSachDichVu.Name = "grbDanhSachDichVu";
            this.grbDanhSachDichVu.Size = new System.Drawing.Size(606, 163);
            this.grbDanhSachDichVu.TabIndex = 5;
            this.grbDanhSachDichVu.TabStop = false;
            this.grbDanhSachDichVu.Text = "Danh sách dịch vụ";
            // 
            // dataGridViewDichVu
            // 
            this.dataGridViewDichVu.AutoGenerateColumns = false;
            this.dataGridViewDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDichVu,
            this.colTenDichVu,
            this.colDonViTinh,
            this.colGiaDichVu});
            this.dataGridViewDichVu.DataSource = this.DichVubindingSource;
            this.dataGridViewDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDichVu.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewDichVu.MultiSelect = false;
            this.dataGridViewDichVu.Name = "dataGridViewDichVu";
            this.dataGridViewDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDichVu.Size = new System.Drawing.Size(600, 142);
            this.dataGridViewDichVu.TabIndex = 0;
            this.dataGridViewDichVu.SelectionChanged += new System.EventHandler(this.dataGridViewDichVu_SelectionChanged);
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
            // colDonViTinh
            // 
            this.colDonViTinh.DataPropertyName = "DVT";
            this.colDonViTinh.HeaderText = "Đơn vị tính";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            // 
            // colGiaDichVu
            // 
            this.colGiaDichVu.DataPropertyName = "GiaDV";
            this.colGiaDichVu.HeaderText = "Giá dịch vụ";
            this.colGiaDichVu.Name = "colGiaDichVu";
            this.colGiaDichVu.ReadOnly = true;
            // 
            // grbThongTinDV
            // 
            this.grbThongTinDV.Controls.Add(this.btnThoat);
            this.grbThongTinDV.Controls.Add(this.btnXoa);
            this.grbThongTinDV.Controls.Add(this.btnSua);
            this.grbThongTinDV.Controls.Add(this.btnThem);
            this.grbThongTinDV.Controls.Add(this.txtGiaDichVu);
            this.grbThongTinDV.Controls.Add(this.txtDonViTinh);
            this.grbThongTinDV.Controls.Add(this.txtTenDichVu);
            this.grbThongTinDV.Controls.Add(this.txtMaDichVu);
            this.grbThongTinDV.Controls.Add(this.label5);
            this.grbThongTinDV.Controls.Add(this.label4);
            this.grbThongTinDV.Controls.Add(this.label3);
            this.grbThongTinDV.Controls.Add(this.label2);
            this.grbThongTinDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinDV.Location = new System.Drawing.Point(44, 65);
            this.grbThongTinDV.Name = "grbThongTinDV";
            this.grbThongTinDV.Size = new System.Drawing.Size(606, 143);
            this.grbThongTinDV.TabIndex = 4;
            this.grbThongTinDV.TabStop = false;
            this.grbThongTinDV.Text = "Thông tin dịch vụ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(464, 101);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 27);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(340, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 27);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(211, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 27);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(81, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 27);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGiaDichVu
            // 
            this.txtGiaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaDichVu.Location = new System.Drawing.Point(426, 63);
            this.txtGiaDichVu.Name = "txtGiaDichVu";
            this.txtGiaDichVu.Size = new System.Drawing.Size(150, 22);
            this.txtGiaDichVu.TabIndex = 7;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(426, 20);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(150, 22);
            this.txtDonViTinh.TabIndex = 6;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDichVu.Location = new System.Drawing.Point(148, 63);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(150, 22);
            this.txtTenDichVu.TabIndex = 5;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDichVu.Location = new System.Drawing.Point(148, 20);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(150, 22);
            this.txtMaDichVu.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(695, 409);
            this.Controls.Add(this.panel1);
            this.Name = "frmService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.frmService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbDanhSachDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DichVubindingSource)).EndInit();
            this.grbThongTinDV.ResumeLayout(false);
            this.grbThongTinDV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbDanhSachDichVu;
        private System.Windows.Forms.BindingSource DichVubindingSource;
        private System.Windows.Forms.DataGridView dataGridViewDichVu;
        private System.Windows.Forms.GroupBox grbThongTinDV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiaDichVu;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaDichVu;
    }
}