using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyKhachSan
{
    public partial class frmLogin : Form
    {
        private LinqToQLKSDataContext db;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            SQLHelper.TenTK = "";
            SQLHelper.MatKhau = "";
            SQLHelper.LoaiTK = 0;
            
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(record => record.TenTK == txtTaiKhoan.Text.Trim() && record.MatKhau == txtMatKhau.Text.Trim());
            if (tk != null)
            {
                SQLHelper.TenTK = tk.TenTK;
                SQLHelper.MatKhau = tk.MatKhau;
                SQLHelper.LoaiTK = tk.LoaiTK;
                MessageBox.Show("Xin chào " + tk.TenTK + ". Bạn đã đăng nhập thành công!");
                
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát chương trình", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
            //    "Xác nhận thoát chương trình",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);
            //if(result == DialogResult.Yes )
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
