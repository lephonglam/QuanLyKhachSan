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
    public partial class frmSearchRoom : Form
    {
        private LinqToQLKSDataContext db;
        public frmSearchRoom()
        {
            InitializeComponent();
        }

        private void frmSearchRoom_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            dataGridViewRoom.AutoGenerateColumns = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(chkLoaiPhong.Checked && !chkTinhTrangPhong.Checked)
            {
                List<Phong> phongs = db.Phongs.Where(record => record.LoaiPhong == cboLoaiPhong.Text.Trim()).ToList();
                if(phongs.Count > 0)
                {
                    RoombindingSource.DataSource = phongs;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
            else if(chkTinhTrangPhong.Checked && !chkLoaiPhong.Checked)
            {
                List<Phong> phongs = db.Phongs.Where(record => record.TinhTrang == cboTinhTrang.Text.Trim()).ToList();
                if(phongs.Count > 0)
                {
                    RoombindingSource.DataSource = phongs;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
            else
            {
                List<Phong> phongs = db.Phongs.Where(record => record.LoaiPhong == cboLoaiPhong.Text.Trim()
                && record.TinhTrang == cboTinhTrang.Text).ToList();
                if(phongs.Count > 0)
                {
                    RoombindingSource.DataSource = phongs;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng",
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
