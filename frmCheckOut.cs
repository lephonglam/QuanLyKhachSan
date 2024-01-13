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
    public partial class frmCheckOut : Form
    {
        private LinqToQLKSDataContext db;
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            btnThanhToan.Enabled = false;
            btnTraPhong.Enabled = false;
            dataGridViewKhach.AutoGenerateColumns = false;
            dataGridViewThuePhong.AutoGenerateColumns = false;
        }

        private void ShowKhach(string ten)
        {
            List<Khach> khaches = db.Khaches.Where(record => record.HoTen.Contains(ten)).ToList();
            KhachbindingSource.DataSource = khaches;
        }

        private void ShowThuePhong(string cmt)
        {
            List<ThuePhong> thuePhongs = db.ThuePhongs.Where(record => record.CMT == cmt && record.NgayDi == null).ToList();
            ThuePhongbindingSource.DataSource = thuePhongs;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ShowKhach(txtTenKhach.Text.Trim());
        }

        private void dataGridViewKhach_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewKhach.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dataGridViewKhach.CurrentRow;
                if (!Function.IsEmptyRow(currentRow))
                {
                    Khach khach = db.Khaches.SingleOrDefault(record => record.CMT == currentRow.Cells[0].Value.ToString());
                    if (khach != null)
                    {
                        txtCMND.Text = khach.CMT;
                        txtHoTen.Text = khach.HoTen;
                        txtDiaChi.Text = khach.DiaChi;
                        txtGioiTinh.Text = khach.GioiTinh;
                        txtDienThoai.Text = khach.SDT;
                        ShowThuePhong(currentRow.Cells[0].Value.ToString());
                    }
                }
            }
        }

        private void dataGridViewThuePhong_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewThuePhong.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dataGridViewThuePhong.CurrentRow;
                if (!Function.IsEmptyRow(currentRow))
                {
                    //txtMaPhong.Text = currentRow.Cells[2].Value.ToString();
                    btnTraPhong.Enabled = true;
                }
                else
                {
                    btnTraPhong.Enabled = false;
                }
            }
            else
            {
                //txtMaPhong.Text = "";
                btnTraPhong.Enabled = false;
            }
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            dataGridViewKhach.Enabled = false;
            DialogResult result = MessageBox.Show(
                                "Bạn có muốn trả phòng đã chọn không?",
                                "Trả phòng",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question
                            );
            if (result == DialogResult.OK)
            {
                if (dataGridViewThuePhong.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewThuePhong.SelectedRows)
                    {
                        if (!Function.IsEmptyRow(row))
                        {
                            if (!SQLHelper.DsMaPhong.Contains(row.Cells[2].Value.ToString()))
                            {
                                SQLHelper.DsMaPhong.Add(row.Cells[2].Value.ToString());
                            }

                            if (!SQLHelper.DsMaHD.Contains(int.Parse(row.Cells[0].Value.ToString())))
                            {
                                SQLHelper.DsMaHD.Add(int.Parse(row.Cells[0].Value.ToString()));
                            }

                            Phong phong = db.Phongs.SingleOrDefault(record => record.MaPhong == row.Cells[2].Value.ToString());
                            try
                            {
                                ThuePhong traPhong = db.ThuePhongs
                                .SingleOrDefault(record => record.MaHD == int.Parse(row.Cells[0].Value.ToString()));
                                traPhong.NgayDi = DateTime.Now.Date;
                                phong.TinhTrang = "Trống";
                                db.SubmitChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(
                                "Trả phòng thất bại: " + ex.Message
                                );
                            }
                        }
                    }
                        btnThanhToan.Enabled = true;
                    MessageBox.Show(
                        "Trả phòng thành công. Vui lòng Thanh toán!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                                    "Chưa chọn phòng",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            dataGridViewKhach.Enabled = true;
            SQLHelper.CMT = txtCMND.Text;
            //SQLHelper.MaPhong = txtMaPhong.Text;
            //SQLHelper.MaHD = dataGridViewThuePhong.CurrentRow.Cells[0].Value.ToString();
            frmHDThuePhong hDThuePhong = new frmHDThuePhong();
            hDThuePhong.Show();
            int count = 0;
            int rowNumber = dataGridViewThuePhong.SelectedRows.Count;
            if (rowNumber > 0)
            {
                foreach(DataGridViewRow row in dataGridViewThuePhong.SelectedRows)
                {
                    if (!Function.IsEmptyRow(row))
                    {
                        List<SDDV> dsSDDV = db.SDDVs.Where(record => record.CMT == txtCMND.Text 
                        && record.MaPhong == row.Cells[2].Value.ToString()).ToList();
                        count += dsSDDV.Count;
                    }
                }
            }
            
            if(count > 0)
            {
                frmHDDichVu hDDichVu = new frmHDDichVu();
                hDDichVu.Show();
            }
            ShowThuePhong(txtCMND.Text);
        }
    }
}
