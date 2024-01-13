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
    public partial class frmAccount : Form
    {
        private LinqToQLKSDataContext db;
        public frmAccount()
        {
            InitializeComponent();
        }

        private void AnHien(bool value)
        {
            txtTenTaiKhoan.Enabled = value;
            txtMatKhau.Enabled = value;
            cboLoaiTaiKhoan.Enabled = value;
        }

        private void SetEmpty()
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cboLoaiTaiKhoan.Text = "";
        }

        private void KhoaCN(bool value)
        {
            btnThem.Enabled = value;
            btnSua.Enabled = value;
            btnXoa.Enabled = value;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            List<TaiKhoan> taiKhoans = db.TaiKhoans.ToList();
            AccountbindingSource.DataSource = taiKhoans;
            AnHien(false);
        }

        private void dataGridViewAccount_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dataGridViewAccount.CurrentRow;
                if (!Function.IsEmptyRow(currentRow))
                {
                    txtTenTaiKhoan.Text = currentRow.Cells[0].Value.ToString();
                    txtMatKhau.Text = currentRow.Cells[1].Value.ToString();
                    cboLoaiTaiKhoan.Text = currentRow.Cells[2].Value.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu lại";
                AnHien(true);
                SetEmpty();
                KhoaCN(false);
                btnThem.Enabled = true;
                txtTenTaiKhoan.Focus();
                dataGridViewAccount.BeginEdit(false);
            }
            else
            {
                if (txtTenTaiKhoan.Text.Trim() != "" && txtMatKhau.Text.Trim() != "" && cboLoaiTaiKhoan.Text.Trim() != "")
                {
                    if (Function.KiemTraLoaiNguoiDung(cboLoaiTaiKhoan.Text))
                    {
                        TaiKhoan KtTaiKhoan = db.TaiKhoans.SingleOrDefault(record => record.TenTK == txtTenTaiKhoan.Text.Trim());
                        if(KtTaiKhoan == null)
                        {
                            TaiKhoan taiKhoan = new TaiKhoan();
                            taiKhoan.TenTK = txtTenTaiKhoan.Text.Trim();
                            taiKhoan.MatKhau = txtMatKhau.Text.Trim();
                            taiKhoan.LoaiTK = int.Parse(cboLoaiTaiKhoan.Text.Trim());
                            db.TaiKhoans.InsertOnSubmit(taiKhoan);
                            db.SubmitChanges();
                            AnHien(false);
                            KhoaCN(true);
                            MessageBox.Show("Thêm tài khoản thành công", " Thông báo");
                            btnThem.Text = "Thêm";
                            AccountbindingSource.Add(taiKhoan);
                            AccountbindingSource.EndEdit();
                            //dataGridViewAccount.Refresh();
                        }
                        else
                        {
                            AccountbindingSource.CancelEdit();
                            MessageBox.Show("Tài khoản đã có trong danh sách. Vui lòng xem lại!");
                            SetEmpty();
                            cboLoaiTaiKhoan.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai loại người dùng", "Lỗi");
                        cboLoaiTaiKhoan.Text = "";
                        cboLoaiTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Lỗi");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dataGridViewAccount.SelectedRows.Count > 0)
            {
                if(btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Lưu lại";
                    AnHien(true); 
                    KhoaCN(false);
                    txtTenTaiKhoan.Enabled = false;
                    btnSua.Enabled = true;
                }
                else
                {
                    if (Function.KiemTraLoaiNguoiDung(cboLoaiTaiKhoan.Text.Trim()))
                    {
                        TaiKhoan taiKhoan = db.TaiKhoans.SingleOrDefault(record => record.TenTK == txtTenTaiKhoan.Text.Trim());
                        taiKhoan.MatKhau = txtMatKhau.Text.Trim();
                        taiKhoan.LoaiTK = int.Parse(cboLoaiTaiKhoan.Text.Trim());
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công", "Sửa");
                        AnHien(false);
                        KhoaCN(true);
                        btnSua.Text = "Sửa";
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai loại người dùng", "Lỗi");
                        cboLoaiTaiKhoan.Text = "";
                        cboLoaiTaiKhoan.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có tài khoản trong danh sách", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            AnHien(false);
            if (dataGridViewAccount.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa",
                "Xóa tài khoản",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    TaiKhoan taiKhoan = db.TaiKhoans.SingleOrDefault(record => record.TenTK == txtTenTaiKhoan.Text);
                    if(taiKhoan != null)
                    {
                        db.TaiKhoans.DeleteOnSubmit(taiKhoan);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công");
                        AccountbindingSource.Remove(taiKhoan);
                        dataGridViewAccount.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có tài khoản trong danh sách", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
