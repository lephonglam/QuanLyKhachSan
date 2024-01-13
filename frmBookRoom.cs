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
    public partial class frmBookRoom : Form
    {
        private LinqToQLKSDataContext db;
        private string soCMND;
        public frmBookRoom()
        {
            InitializeComponent();
        }

        private void ShowKhach()
        {
            List<Khach> khaches = db.Khaches.ToList();
            KhachbindingSource.DataSource = khaches;
        }

        private void ShowPhong()
        {
            List<Phong> phongs = db.Phongs.Where(record => record.TinhTrang == "Trống").ToList();
            PhongbindingSource.DataSource = phongs;
        }

        private void frmBookRoom_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            ShowKhach();
            ShowPhong();
            btnChonPhong.Enabled = false;
            btnThuePhong.Enabled = false;
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            List<Khach> khachs = db.Khaches.Where(record => record.CMT.Contains(txtCMND.Text)).ToList();
            KhachbindingSource.DataSource = khachs;
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            if(btnThemKhach.Text == "Thêm khách")
            {
                btnChonKhach.Enabled = false;
                btnThemKhach.Text = "Cập nhật bảng";
                frmCustomer customer = new frmCustomer();
                customer.Show();
            }
            else
            {
                KhachbindingSource.DataSource = null;
                ShowKhach();
                btnThemKhach.Text = "Thêm Khách";
                btnChonKhach.Enabled = true;
            }
        }

        private void btnChonKhach_Click(object sender, EventArgs e)
        {
            try
            {
                ThuePhongbindingSource.AddNew();
                dataGridViewThuePhong.BeginEdit(false);
                dataGridViewThuePhong.CurrentRow.Cells[0].Value = dataGridViewKhach.CurrentRow.Cells[0].Value.ToString();
                soCMND = dataGridViewKhach.CurrentRow.Cells[0].Value.ToString();
                btnChonKhach.Enabled = false;
                btnChonPhong.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Chưa chọn khách hàng", "Thông báo");
                ThuePhongbindingSource.CancelEdit();
            }
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Phong> phongs = db.Phongs.Where(record => record.LoaiPhong == cboLoaiPhong.Text).ToList();
            PhongbindingSource.DataSource = phongs;
        }

        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            if(dataGridViewPhong.CurrentRow.Cells[4].Value.ToString() == "Trống")
            {
                try
                {
                    if (dataGridViewThuePhong.CurrentRow.Cells[1].Value != null)
                    {
                        ThuePhongbindingSource.EndEdit();
                        ThuePhongbindingSource.AddNew();
                        dataGridViewThuePhong.BeginEdit(false);
                        dataGridViewThuePhong.CurrentRow.Cells[0].Value = soCMND;
                    }
                    dataGridViewThuePhong.CurrentRow.Cells[1].Value = dataGridViewPhong.CurrentRow.Cells[0].Value.ToString();
                    dataGridViewThuePhong.CurrentRow.Cells[2].Value = DateTime.Now.Date;
                    btnThuePhong.Enabled = true;
                    PhongbindingSource.RemoveCurrent();
                }
                catch
                {
                    MessageBox.Show("Chưa chọn phòng", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Phòng đã có khách thuê. Vui lòng chọn phòng khác!", "Thông báo");
            }
            
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            if(txtNhanVien.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên", "Lỗi");
            }
            else
            {
                try
                {
                    for (int i = 0; i < dataGridViewThuePhong.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = dataGridViewThuePhong.Rows[i];
                        row.Cells[4].Value = txtNhanVien.Text;
                        ThuePhong thuePhong = new ThuePhong();
                        thuePhong.CMT = row.Cells[0].Value.ToString();
                        thuePhong.MaPhong = row.Cells[1].Value.ToString();
                        thuePhong.NgayDen = DateTime.Now.Date;
                        thuePhong.TenNV = txtNhanVien.Text;
                        db.ThuePhongs.InsertOnSubmit(thuePhong);
                        Phong phong = db.Phongs.FirstOrDefault(record => record.MaPhong == row.Cells[1].Value.ToString());
                        phong.TinhTrang = "Có khách";
                        db.SubmitChanges();
                    }
                    MessageBox.Show("Thuê phòng thành công", "Thuê phòng");
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý", "Lỗi");
                }
                finally
                {
                    btnChonKhach.Enabled = true;
                    btnChonPhong.Enabled = false;
                    btnThuePhong.Enabled = false;
                    ThuePhongbindingSource.EndEdit();
                    ThuePhongbindingSource.DataSource = null;
                    txtNhanVien.Text = "";
                }
            }
        }

        private void txtCMND_Enter(object sender, EventArgs e)
        {
            txtCMND.Text = "";
        }
    }
}
