namespace QuanLyKhachSan
{
    partial class frmHDThuePhong
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
            this.rpvHDThuePhong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvHDThuePhong
            // 
            this.rpvHDThuePhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHDThuePhong.Location = new System.Drawing.Point(0, 0);
            this.rpvHDThuePhong.Name = "rpvHDThuePhong";
            this.rpvHDThuePhong.ServerReport.BearerToken = null;
            this.rpvHDThuePhong.Size = new System.Drawing.Size(800, 450);
            this.rpvHDThuePhong.TabIndex = 0;
            // 
            // frmHDThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvHDThuePhong);
            this.Name = "frmHDThuePhong";
            this.Text = "Hóa đơn thuê phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHDThuePhong_FormClosed);
            this.Load += new System.EventHandler(this.frmHDThuePhong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHDThuePhong;
    }
}