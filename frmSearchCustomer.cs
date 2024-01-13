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
    public partial class frmSearchCustomer : Form
    {
        private LinqToQLKSDataContext db;
        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            dataGridViewCustomer.AutoGenerateColumns = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radCMND.Checked)
            {
                List<Khach> khaches = db.Khaches.Where(record => record.CMT == txtTimKiem.Text.Trim()).ToList();
                if(khaches.Count > 0)
                {
                    CustomerbindingSource.DataSource = khaches;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
            else
            {
                List<Khach> khaches = db.Khaches.Where(record => record.HoTen.Contains(txtTimKiem.Text.Trim())).ToList();
                if(khaches.Count > 0)
                {
                    CustomerbindingSource.DataSource = khaches;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
