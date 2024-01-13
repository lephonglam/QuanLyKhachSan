using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmCustomer : Form
    {
        private LinqToQLKSDataContext db;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void AnHien(bool value)
        {
            txtSoCMND.Enabled  = value;
            txtHoTen.Enabled = value;
            txtDiaChi.Enabled = value;
            txtSoDienThoai.Enabled = value;
            cboGioiTinh.Enabled = value;
        }

        private void SetEmpty()
        {
            txtSoCMND.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            cboGioiTinh.Text = "";
        }

        private void KhoaCN(bool value)
        {
            btnThem.Enabled = value;
            btnSua.Enabled = value;
            btnXoa.Enabled = value;
        }

        

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            db = new LinqToQLKSDataContext(SQLHelper.ConnectString);
            List<Khach> list = db.Khaches.ToList();
            KhachbindingSource.DataSource = list;
            AnHien(false);
            dataGridViewKhachHang.AutoGenerateColumns = false;
            //foreach (DataGridViewColumn column in dataGridViewKhachHang.Columns)
            //{
            //    Console.WriteLine(column.Name);
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu lại";
                SetEmpty();
                AnHien(true);
                KhoaCN(false);
                dataGridViewKhachHang.BeginEdit(true);
                txtSoCMND.Focus();
                btnThem.Enabled = true;
            }
            else
            {
                if (txtSoCMND.Text.Trim() != "" && txtHoTen.Text.Trim() != "" && txtDiaChi.Text.Trim() != ""
                && txtSoDienThoai.Text.Trim() != "" && cboGioiTinh.Text.Trim() != "")
                {
                    if (Function.KiemTraCMND(txtSoCMND.Text.Trim()))
                    {
                        if (Function.KiemTraSDT(txtSoDienThoai.Text.Trim()))
                        {
                            Khach ktKhach = db.Khaches.Where(record => record.CMT == txtSoCMND.Text).SingleOrDefault();
                            if (ktKhach == null)
                            {
                                
                                Khach khach = new Khach();
                                khach.CMT = txtSoCMND.Text.Trim();
                                khach.HoTen = txtHoTen.Text.Trim();
                                khach.DiaChi = txtDiaChi.Text.Trim();
                                khach.GioiTinh = cboGioiTinh.Text.Trim();
                                khach.SDT = txtSoDienThoai.Text.Trim();
                                db.Khaches.InsertOnSubmit(khach);
                                db.SubmitChanges();
                                AnHien(false);
                                MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                                btnThem.Text = "Thêm";
                                KhoaCN(true);
                                KhachbindingSource.Add(khach);
                                KhachbindingSource.EndEdit();
                            }
                            else
                            {
                                KhachbindingSource.CancelEdit();
                                MessageBox.Show("Số CMND đã được đăng ký. Vui lòng kiểm tra lại!");
                                SetEmpty();
                                txtSoCMND.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập số điện thoại không đúng", "Lỗi");
                            txtSoDienThoai.Text = "";
                            txtSoDienThoai.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập số CMND không đúng", "Lỗi");
                        txtSoCMND.Text = "";
                        txtSoCMND.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy điền đầy đủ các trường thông tin", "Lỗi");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu lại";
                AnHien(true);
                KhoaCN(false);
                txtSoCMND.Enabled = false;
                btnSua.Enabled = true;
            }
            else
            {
                if(dataGridViewKhachHang.SelectedRows.Count > 0)
                {
                    if (Function.KiemTraSDT(txtSoDienThoai.Text.Trim()))
                    {
                        Khach khach = db.Khaches.FirstOrDefault(record => record.CMT == txtSoCMND.Text.Trim());
                        khach.HoTen = txtHoTen.Text.Trim();
                        khach.DiaChi = txtDiaChi.Text.Trim();
                        khach.GioiTinh = cboGioiTinh.Text.Trim();
                        khach.SDT = txtSoDienThoai.Text.Trim();
                        db.SubmitChanges();
                        AnHien(false);
                        MessageBox.Show("Sửa thành công!");
                        btnSua.Text = "Sửa";
                        KhoaCN(true);
                    }
                    else
                    {
                        MessageBox.Show("Nhập số điện thoại không đúng", "Lỗi");
                        txtSoDienThoai.Text = "";
                        txtSoDienThoai.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Không có khách hàng trong danh sách");
                    AnHien(false);
                    KhoaCN(true);
                    btnSua.Text = "Sửa";
                }
            }
        }

        private void dataGridViewKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewKhachHang.CurrentRow;
            txtSoCMND.Text = currentRow.Cells[0].Value.ToString();
            txtHoTen.Text = currentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = currentRow.Cells[2].Value.ToString();
            cboGioiTinh.Text = currentRow.Cells[3].Value.ToString();
            if(currentRow.Cells[4].Value != null)
            {
                txtSoDienThoai.Text = currentRow.Cells[4].Value.ToString();
            }
            else
            {
                txtSoDienThoai.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            AnHien(false);
            if(dataGridViewKhachHang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có thực sự muốn xóa",
                    "Xóa khách hàng",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.OK)
                {
                    List<ThuePhong> dsThuePhong = db.ThuePhongs.Where(record => record.CMT == txtSoCMND.Text.Trim()).ToList();
                    if (dsThuePhong != null)
                    {
                        db.ThuePhongs.DeleteAllOnSubmit(dsThuePhong);
                        db.SubmitChanges();
                    }

                    List<SDDV> dsSDDV = db.SDDVs.Where(record => record.CMT == txtSoCMND.Text.Trim()).ToList();
                    if (dsSDDV != null)
                    {
                        db.SDDVs.DeleteAllOnSubmit(dsSDDV);
                        db.SubmitChanges();
                    }

                    Khach khach = db.Khaches.Where(record => record.CMT == txtSoCMND.Text.Trim()).SingleOrDefault();
                    if (khach != null)
                    {
                        db.Khaches.DeleteOnSubmit(khach);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công!", "Xóa khách hàng");
                        KhachbindingSource.Remove(khach);
                        dataGridViewKhachHang.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có khách hàng trong danh sách");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridViewKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dataGridViewKhachHang.SelectedRows[0];
                if(!Function.IsEmptyRow(currentRow))
                {
                    txtSoCMND.Text = currentRow.Cells[0].Value.ToString();
                    txtHoTen.Text = currentRow.Cells[1].Value.ToString();
                    txtDiaChi.Text = currentRow.Cells[2].Value.ToString();
                    cboGioiTinh.Text = currentRow.Cells[3].Value.ToString();
                    if (currentRow.Cells[4].Value != null)
                    {
                        txtSoDienThoai.Text = currentRow.Cells[4].Value.ToString();
                    }
                    else
                    {
                        txtSoDienThoai.Text = "";
                    }
                }
            }
        }
    }
}
