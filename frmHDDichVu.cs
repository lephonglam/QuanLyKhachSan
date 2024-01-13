using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmHDDichVu : Form
    {
        public frmHDDichVu()
        {
            InitializeComponent();
        }

        private void frmHDDichVu_Load(object sender, EventArgs e)
        {
            LinqToQLKSDataContext db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            rpvHDDichVu.ProcessingMode = ProcessingMode.Local;
            rpvHDDichVu.LocalReport.ReportPath = "dichvu.rdlc";
            if (SQLHelper.DsMaPhong.Count > 0)
            {
                DataTable dichVuDataTable = new DataTable("DichVuDataTable");
                dichVuDataTable.Columns.Add("CMT", typeof(string));
                dichVuDataTable.Columns.Add("HoTen", typeof(string));
                dichVuDataTable.Columns.Add("TenDV", typeof(string));
                dichVuDataTable.Columns.Add("GiaDV", typeof(int));
                dichVuDataTable.Columns.Add("SoLuong", typeof(int));
                dichVuDataTable.Columns.Add("NgaySD", typeof(DateTime));
                dichVuDataTable.Columns.Add("ThanhTien", typeof(int));
                foreach (string maPhong in SQLHelper.DsMaPhong)
                {
                    var data = db.HoaDonDichVu(SQLHelper.CMT, maPhong);
                    foreach(var item in data)
                    {
                        DataRow row = dichVuDataTable.NewRow();
                        row["CMT"] = item.CMT;
                        row["HoTen"] = item.HoTen;
                        row["TenDV"] = item.TenDV;
                        row["GiaDV"] = item.GiaDV;
                        row["SoLuong"] = item.SoLuong;
                        row["NgaySD"] = item.NgaySD;
                        row["ThanhTien"] = item.ThanhTien;
                        dichVuDataTable.Rows.Add(row);
                    }
                }
                this.rpvHDDichVu.Clear();
                rpvHDDichVu.LocalReport.DataSources.Add(new ReportDataSource("DataSetDichVu", dichVuDataTable));
                this.rpvHDDichVu.RefreshReport();
            }
        }

        private void frmHDDichVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LinqToQLKSDataContext db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            foreach(string maPhong in SQLHelper.DsMaPhong)
            {
                List<SDDV> dsSDDV = db.SDDVs.Where(record => record.CMT == SQLHelper.CMT && record.MaPhong == maPhong).ToList();
                db.SDDVs.DeleteAllOnSubmit(dsSDDV);
                db.SubmitChanges();
            }
            SQLHelper.DsMaPhong.Clear();
        }
    }
}
