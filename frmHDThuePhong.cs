using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyKhachSan.QuanLyKhachSanDataSetTableAdapters;

namespace QuanLyKhachSan
{
    public partial class frmHDThuePhong : Form
    {
        public frmHDThuePhong()
        {
            InitializeComponent();
        }

        private void frmHDThuePhong_Load(object sender, EventArgs e)
        {
            LinqToQLKSDataContext db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            rpvHDThuePhong.ProcessingMode = ProcessingMode.Local;
            rpvHDThuePhong.LocalReport.ReportPath = "traphong.rdlc";
            if (SQLHelper.DsMaHD.Count > 0)
            {
                var localReport = this.rpvHDThuePhong.LocalReport;
                DataTable traPhongDataTable = new DataTable("TraPhongDataTable");
                traPhongDataTable.Columns.Add("CMT", typeof(string));
                traPhongDataTable.Columns.Add("HoTen", typeof(string));
                traPhongDataTable.Columns.Add("TenPhong", typeof(string));
                traPhongDataTable.Columns.Add("NgayDen", typeof(DateTime));
                traPhongDataTable.Columns.Add("NgayDi", typeof(DateTime));
                traPhongDataTable.Columns.Add("GiaPhong", typeof(int));
                traPhongDataTable.Columns.Add("ThanhTien", typeof(int));
                foreach (int maHD in  SQLHelper.DsMaHD)
                {
                    var data = db.HoaDonThuePhong(maHD);
                    foreach(var item in data)
                    {
                        DataRow row = traPhongDataTable.NewRow();
                        row["CMT"] = item.CMT;
                        row["HoTen"] = item.HoTen;
                        row["TenPhong"] = item.TenPhong;
                        row["NgayDen"] = item.NgayDen;
                        row["NgayDi"] = item.NgayDi;
                        row["GiaPhong"] = item.GiaPhong;
                        row["ThanhTien"] = item.ThanhTien;
                        traPhongDataTable.Rows.Add(row);
                    }
                }
                this.rpvHDThuePhong.Clear();
                localReport.DataSources.Add(new ReportDataSource("DataSetTraPhong", traPhongDataTable));
                this.rpvHDThuePhong.RefreshReport();
            }
        }

        private void frmHDThuePhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            SQLHelper.DsMaHD.Clear();
        }
    }
}