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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(SQLHelper.LoaiTK == 1)
            {
                mnuHeThongQLTaiKhoan.Visible = true;
            }
            else
            {
                mnuHeThongQLTaiKhoan.Visible = false;
            }
        }

        private void mnuQuanLyKhach_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.ShowDialog();
        }

        private void mnuQuanLyPhong_Click(object sender, EventArgs e)
        {
            frmRoom room = new frmRoom();
            room.ShowDialog();
        }

        private void mnuQuanLyDichVu_Click(object sender, EventArgs e)
        {
            frmService service = new frmService();
            service.ShowDialog();
        }

        private void mnuChucNangThuePhong_Click(object sender, EventArgs e)
        {
            frmBookRoom bookRoom = new frmBookRoom();
            bookRoom.ShowDialog();
        }

        private void mnuChucNangTraPhong_Click(object sender, EventArgs e)
        {
            frmCheckOut checkOut = new frmCheckOut();
            checkOut.ShowDialog();
        }

        private void mnuChucNangSDDichVu_Click(object sender, EventArgs e)
        {
            frmUseService useService = new frmUseService();
            useService.ShowDialog();
        }

        private void mnuTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            frmSearchCustomer searchCustomer = new frmSearchCustomer();
            searchCustomer.ShowDialog();
        }

        private void mnuTimKiemPhong_Click(object sender, EventArgs e)
        {
            frmSearchRoom searchRoom = new frmSearchRoom();
            searchRoom.ShowDialog();
        }

        private void mnuHeThongQLTaiKhoan_Click(object sender, EventArgs e)
        {
            frmAccount account = new frmAccount();
            account.ShowDialog();
        }

        private void mnuHeThongDangXuat_Click(object sender, EventArgs e)
        {
            SQLHelper.TenTK = "";
            SQLHelper.MatKhau = "";
            SQLHelper.LoaiTK = 0;
            SQLHelper.CMT = "";
            SQLHelper.MaPhong = "";
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void mnuHeThongThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
