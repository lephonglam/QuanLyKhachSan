namespace QuanLyKhachSan
{
    partial class frmHDDichVu
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
            this.rpvHDDichVu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvHDDichVu
            // 
            this.rpvHDDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHDDichVu.Location = new System.Drawing.Point(0, 0);
            this.rpvHDDichVu.Name = "rpvHDDichVu";
            this.rpvHDDichVu.ServerReport.BearerToken = null;
            this.rpvHDDichVu.Size = new System.Drawing.Size(800, 450);
            this.rpvHDDichVu.TabIndex = 0;
            // 
            // frmHDDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvHDDichVu);
            this.Name = "frmHDDichVu";
            this.Text = "Hóa đơn dịch vụ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHDDichVu_FormClosed);
            this.Load += new System.EventHandler(this.frmHDDichVu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHDDichVu;
    }
}